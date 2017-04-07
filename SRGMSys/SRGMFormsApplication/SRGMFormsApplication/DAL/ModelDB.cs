using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using SRGMFormsApplication.Entity;


namespace SRGMFormsApplication.DAL
{
    public class ModelDB
    {
        public DataSet getModelType()
        {
            string sql = "select mt.typeID as 编号,mt.name as 类型名 from modeltype mt";
            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql);
            return ds;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_modelName"></param>
        /// <returns></returns>
        public Model getModelByid(string p_modelName)
        {
            Model model = new Model();
            model.Name = p_modelName;
            string sql = "select * from model" +
               " where modelname=@modelname";
            SqlParameter sp1 = new SqlParameter("@modelname", p_modelName);
            SqlParameter[] para = new SqlParameter[] { sp1 };
            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql, para);
            model.Path = ds.Tables[0].Rows[0]["path"].ToString();
            model.Owner = (int)ds.Tables[0].Rows[0]["permission"];
            model.Type = new ModelType();
            model.Type.TypeID = (int)ds.Tables[0].Rows[0]["typeID"];
            if (!Convert.IsDBNull( ds.Tables[0].Rows[0]["paranum"]))
            {
                model.ParaNum = (int)ds.Tables[0].Rows[0]["paranum"];
            }
            return model;
        }
        #region 得到系统自带Model信息，返回DataSet
        /// <summary>
        /// 得到系统自带Model信息
        /// </summary>
        /// <returns></returns>
        public DataSet getModelsforSystem()
        {
            string sql = "select m.modelname as 名称,mt.name as 类型,m.paranum as param0个数 from model m,modeltype mt" +
               " where m.permission=0 and m.typeID=mt.typeID";
            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql);
            return ds;
        }

        #endregion
        #region 得到系统的Model信息，返回List集合，断开式
        /// <summary>
        /// 得到系统的Model信息
        /// </summary>
        /// <returns></returns>
        public List<Model> getModelsforSystemL()
        {
            List<Model> list = new List<Model>();
            string sql = "select * from model" +
               " where permission= 0";
            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Model model = new Model();
                model.Name = dr["modelname"].ToString();

                list.Add(model);
            }
            return list;
        }
        #endregion

        #region 得到当前用户拥有的Model信息，返回DataSet
        /// <summary>
        /// 得到当前用户拥有的Model信息
        /// </summary>
        /// <param name="p_account"></param>
        /// <param name="p_type"></param>
        /// <returns></returns>
        public DataSet getModelsforUser(Account p_account, int p_type)
        {
            string sql = "select m.modelname as 名称,mt.name as 类型,m.paranum as param0个数 from model m,modeltype mt" +
                " where m.username=@userName and m.permission=@permission and m.typeID=mt.typeID ";
            SqlParameter sp1 = new SqlParameter("@userName", p_account.UserName);
            SqlParameter sp2 = new SqlParameter("@permission", p_type);

            SqlParameter[] para = new SqlParameter[] { sp1, sp2 };
            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql, para);
            return ds;
        }
        #endregion

        /// <summary>
        /// 为系统添加模型
        /// </summary>
        /// <param name="p_model"></param>
        /// <returns></returns>
        public int addDataSetsforSystem(Model p_model)
        {
            string sql = "insert into model values(@modelname,@path,@permission,@username,@shape,@typeID,@parameters,@paranum)";

            SqlParameter sp1 = new SqlParameter("@modelname", p_model.Name);
            SqlParameter sp2 = new SqlParameter("@path", p_model.Path);
            SqlParameter sp3 = new SqlParameter("@permission", Convert.ToInt32(0));
            SqlParameter sp4 = new SqlParameter("@username", (object)DBNull.Value);
            SqlParameter sp5 = new SqlParameter("@shape",(object)DBNull.Value);
            SqlParameter sp6 = new SqlParameter("@typeID", p_model.Type.TypeID);
            SqlParameter sp7 = new SqlParameter("@parameters", (object)DBNull.Value);
            SqlParameter sp8 = new SqlParameter("@paranum", p_model.ParaNum);

            SqlParameter[] para = new SqlParameter[] { sp1, sp2, sp3, sp4, sp5, sp6,sp7,sp8 };

            return SqlHelper.ExecuteNonQuery(sql, para);
        }

        /// <summary>
        /// 按用户类型添加模型
        /// </summary>
        /// <param name="p_model"></param>
        /// <param name="p_userType"></param>
        /// <returns></returns>
        public int addModelsforUser(Model p_model, Account p_account, int p_userType)
        {
            string sql = "insert into model values(@modelname,@path,@permission,@username,@shape,@typeID,@parameters,@paranum)";

            SqlParameter sp1 = new SqlParameter("@modelname", p_model.Name);
            SqlParameter sp2 = new SqlParameter("@path", p_model.Path);
            SqlParameter sp3 = new SqlParameter("@permission", p_userType);
            SqlParameter sp4 = new SqlParameter("@username", p_account.UserName);
            SqlParameter sp5 = new SqlParameter("@shape", (object)DBNull.Value);
            SqlParameter sp6 = new SqlParameter("@typeID", p_model.Type.TypeID);
            SqlParameter sp7 = new SqlParameter("@parameters", (object)DBNull.Value);
            SqlParameter sp8 = new SqlParameter("@paranum", p_model.ParaNum);

            SqlParameter[] para = new SqlParameter[] { sp1, sp2, sp3, sp4, sp5, sp6,sp7,sp8 };

            return SqlHelper.ExecuteNonQuery(sql, para);
        }

        #region 删除系统模型
        /// <summary>
        /// 删除系统模型
        /// </summary>
        /// <param name="p_model"></param>
        /// <returns></returns>
        public int deleteModelsforSystem(Model p_model)
        {
            //删除初值记录
            deleteValue0forModel(p_model);
            string sql = "delete from model where modelname=@modelname and username is null and permission=@permission";
            SqlParameter sp1 = new SqlParameter("@modelname", p_model.Name);
           // SqlParameter sp2 = new SqlParameter("@username", (object)DBNull.Value);
            SqlParameter sp3 = new SqlParameter("@permission", Convert.ToInt32(0));

            SqlParameter[] para = new SqlParameter[] { sp1, sp3 };

            return SqlHelper.ExecuteNonQuery(sql, para);
        }
        #endregion

        #region 删除用户模型
        /// <summary>
        /// 删除用户模型
        /// </summary>
        /// <param name="p_model"></param>
        /// <param name="p_account"></param>
        /// <param name="p_userType"></param>
        /// <returns></returns>
        public int deleteModelsforUser(Model p_model, Account p_account, int p_userType)
        {
            //删除初值记录
            deleteValue0forModel(p_model);
            string sql = "delete from model where modelname=@modelname and username=@username and permission=@permission";
            SqlParameter sp1 = new SqlParameter("@modelname", p_model.Name);
            SqlParameter sp2 = new SqlParameter("@username", p_account.UserName);
            SqlParameter sp3 = new SqlParameter("@permission", p_userType);

            SqlParameter[] para = new SqlParameter[] { sp1, sp2, sp3 };

            return SqlHelper.ExecuteNonQuery(sql, para);
        }
        #endregion

        public DataSet getAllValue0()
        {
            string sql = "select modelname as 模型,dsname as 数据集,value0 as 参数初值 from value0 ";
            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql);
            return ds;
        }


        public DataSet getValue0(FDataSet p_dataSet,Model p_model)
        {
            string sql = "select * from value0 where modelname=@modelname and dsname=@dsname";
            SqlParameter sp1 = new SqlParameter("@modelname", p_model.Name);
            SqlParameter sp2 = new SqlParameter("@dsname", p_dataSet.Name);

            SqlParameter[] para = new SqlParameter[] { sp1, sp2 };
            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql, para);
            return ds;
        }


        public int addValue0(Model p_model, FDataSet p_dataSet, string value0)
        {
            string sql = "insert into value0 values(@modelname,@dsname,@value0,@value)";

            SqlParameter sp1 = new SqlParameter("@modelname", p_model.Name);
            SqlParameter sp2 = new SqlParameter("@dsname", p_dataSet.Name);
            SqlParameter sp3 = new SqlParameter("@value0", value0);
            SqlParameter sp4 = new SqlParameter("@value", (object)DBNull.Value);

            SqlParameter[] para = new SqlParameter[] { sp1, sp2, sp3,sp4 };
            return SqlHelper.ExecuteNonQuery(sql, para);
        }

        public int deleteValue0forModel(Model p_model)
        {
            string sql = "delete from value0 where modelname = @modelname";

            SqlParameter sp1 = new SqlParameter("@modelname", p_model.Name);

            SqlParameter[] para = new SqlParameter[] { sp1 };
            return SqlHelper.ExecuteNonQuery(sql, para);
        }
        public int deleteValue0Item(Model p_model,FDataSet p_dataSet,string p_value0)
        {
            string sql = "delete from value0 where dsname =@dsname  and modelname=@modelname  and value0=@value0 ";

            SqlParameter sp1 = new SqlParameter("@dsname", p_dataSet.Name);
            SqlParameter sp2 = new SqlParameter("@modelname", p_model.Name);
            SqlParameter sp3 = new SqlParameter("@value0", p_value0);

            SqlParameter[] para = new SqlParameter[] { sp1,sp2,sp3 };
            return SqlHelper.ExecuteNonQuery(sql, para);
        }
    }
}
