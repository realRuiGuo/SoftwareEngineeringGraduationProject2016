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
    public class FDataSetDB
    {
        public DataSet getDataSetType()
        {
            string sql = "select dt.typeID as 编号,dt.wt as 有无wt,dt.ct as 有无ct from dstype dt";
            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql);
            return ds;
        }

        public FDataSet getDataSetByid(string p_dsName)
        {
            FDataSet dataSet = new FDataSet();
            dataSet.Name = p_dsName;
            string sql = "select * from dataset" +
               " where dsname=@dsname";
            SqlParameter sp1 = new SqlParameter("@dsname",p_dsName);
            SqlParameter[] para = new SqlParameter[] { sp1};
            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql, para);
            dataSet.Path = ds.Tables[0].Rows[0]["path"].ToString();
            dataSet.Type = new FDataSetType();
            dataSet.Type.TypeID = (int)ds.Tables[0].Rows[0]["typeID"];
            if (!Convert.IsDBNull(ds.Tables[0].Rows[0]["cp"]))//数据库返回值不为空
            {
                dataSet.Cp = (int)ds.Tables[0].Rows[0]["cp"];
            }
            return dataSet;
        }
        #region 得到系统自带FDataSet信息，返回DataSet
        /// <summary>
        /// 得到系统自带FDataSet信息
        /// </summary>
        /// <returns></returns>
        public DataSet getDataSetsforSystem()
        {
            string sql = "select dsname as 名称,source as 来源,date as 发布日期,typeID as 类型,cp as 变化点 from dataset" +
               " where permission= 0" ;
            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql);
            return ds;
        }
        #endregion

        #region 得到当前用户拥有的FDataSet信息，返回DataSet
        /// <summary>
        /// 得到当前用户拥有的FDataSet信息
        /// </summary>
        /// <param name="p_account"></param>
        /// <param name="p_type"></param>
        /// <returns></returns>
        public DataSet getDataSetsforUser(Account p_account, int p_type)
        {
            string sql = "select dsname as 名称,source as 来源,date as 发布日期,typeID as 类型,cp as 变化点 from dataset" +
                " where username=@userName and permission=@permission";
            SqlParameter sp1 = new SqlParameter("@userName", p_account.UserName);
            SqlParameter sp2 = new SqlParameter("@permission", p_type);

            SqlParameter[] para = new SqlParameter[] { sp1, sp2 };
            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql,para);
            return ds;
        }
        #endregion

        #region 得到系统的FDataSet信息，返回List集合，断开式
        /// <summary>
        /// 得到系统的FDataSet信息
        /// </summary>
        /// <returns></returns>
        public List<FDataSet> getDataSetsforSystemL()
        {
            List<FDataSet> list = new List<FDataSet>();
            string sql = "select * from dataset" +
               " where permission= 0";
            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                FDataSet FDataSet = new FDataSet();
                FDataSet.Name = dr["dsname"].ToString();
                FDataSet.Path = dr["path"].ToString();
                list.Add(FDataSet);
            }
            return list;
        }
        #endregion

        #region 得到当前用户拥有的FDataSet信息，返回List集合，断开式
        /// <summary>
        /// 得到当前用户拥有的FDataSet信息
        /// </summary>
        /// <param name="p_account"></param>
        /// <param name="p_type"></param>
        /// <returns></returns>
        public List<FDataSet> getDataSetsforUserL(Account p_account, int p_type)
        {
            List<FDataSet> list = new List<FDataSet>();
            string sql = "select * from dataset" +
                " where username=@userName and permission=@permission";
            SqlParameter sp1 = new SqlParameter("@userName", p_account.UserName);
            SqlParameter sp2 = new SqlParameter("@permission", p_type);

            SqlParameter[] para = new SqlParameter[] { sp1, sp2 };
            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql, para);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                FDataSet FDataSet = new FDataSet();
                FDataSet.Name = dr["dsname"].ToString();
                FDataSet.Path = dr["path"].ToString();
                list.Add(FDataSet);
            }
            return list;
        }
        #endregion

        /// <summary>
        /// 为系统添加数据集
        /// </summary>
        /// <param name="p_dataSet"></param>
        /// <returns></returns>
        public int addDataSetsforSystem(FDataSet p_dataSet)
        {
            string sql = "insert into dataset values(@dsname,@path,@source,@date,@permission,@username,@typeID,@cp)";

            SqlParameter sp1 = new SqlParameter("@dsname", p_dataSet.Name);
            SqlParameter sp2 = new SqlParameter("@path", p_dataSet.Path);
            SqlParameter sp3 = new SqlParameter("@source", p_dataSet.Source);
            SqlParameter sp4 = new SqlParameter("@date", p_dataSet.PostDate);
            SqlParameter sp5 = new SqlParameter("@permission", Convert.ToInt32(0));//0
            SqlParameter sp6 = new SqlParameter("@username", (object)DBNull.Value);//null
            SqlParameter sp7 = new SqlParameter("@typeID", p_dataSet.Type.TypeID);
            SqlParameter sp8 = new SqlParameter("@cp", p_dataSet.Cp);

            SqlParameter[] para = new SqlParameter[] { sp1, sp2, sp3, sp4, sp5, sp6, sp7,sp8 };

            return SqlHelper.ExecuteNonQuery(sql, para);
        }

        /// <summary>
        /// 按用户类型添加数据集
        /// </summary>
        /// <param name="p_dataSet"></param>
        /// <param name="p_userType"></param>
        /// <returns></returns>
        public int addDataSetsforUser(FDataSet p_dataSet,Account p_account,int p_userType)
        {
            string sql = "insert into dataset values(@dsname,@path,@source,@date,@permission,@username,@typeID,@cp)";

            SqlParameter sp1 = new SqlParameter("@dsname",p_dataSet.Name );
            SqlParameter sp2 = new SqlParameter("@path", p_dataSet.Path);
            SqlParameter sp3 = new SqlParameter("@source",p_dataSet.Source );
            SqlParameter sp4 = new SqlParameter("@date", p_dataSet.PostDate);
            SqlParameter sp5 = new SqlParameter("@permission", p_userType);
            SqlParameter sp6 = new SqlParameter("@username", p_account.UserName);
            SqlParameter sp7 = new SqlParameter("@typeID", p_dataSet.Type.TypeID);
            SqlParameter sp8 = new SqlParameter("@cp", p_dataSet.Type.TypeID);

            SqlParameter[] para = new SqlParameter[] { sp1, sp2, sp3, sp4, sp5, sp6, sp7,sp8 };

            return SqlHelper.ExecuteNonQuery(sql, para);
        }

        #region 删除系统失效数据集
        /// <summary>
        /// 删除失效数据集
        /// </summary>
        /// <param name="p_dataSet"></param>
        /// <returns></returns>
        public int deleteDataSetsforSystem(FDataSet p_dataSet)
        {
            deleteValue0forDataSet(p_dataSet);
            string sqlFDS = "delete from dataset where dsname=@dsname and username is null and permission=@permission";
            SqlParameter spFDS1 = new SqlParameter("@dsname", p_dataSet.Name);
            //SqlParameter spFDS2 = new SqlParameter("@username", (object)DBNull.Value);
            SqlParameter spFDS3 = new SqlParameter("@permission", Convert.ToInt32(0));

            SqlParameter[] para = new SqlParameter[] { spFDS1, spFDS3 };

            return SqlHelper.ExecuteNonQuery(sqlFDS, para);
        }
        #endregion

        #region 删除用户失效数据集
        /// <summary>
        /// 删除用户失效数据集
        /// </summary>
        /// <param name="p_dataSet"></param>
        /// <param name="p_account"></param>
        /// <param name="p_userType"></param>
        /// <returns></returns>
        public int deleteDataSetsforUser(FDataSet p_dataSet, Account p_account, int p_userType)
        {
            deleteValue0forDataSet(p_dataSet);
            string sqlFDS = "delete from dataset where dsname=@dsname and username=@username and permission=@permission";
            SqlParameter spFDS1 = new SqlParameter("@dsname", p_dataSet.Name);
            SqlParameter spFDS2 = new SqlParameter("@username", p_account.UserName);
            SqlParameter spFDS3 = new SqlParameter("@permission", p_userType);

            SqlParameter[] para = new SqlParameter[] { spFDS1, spFDS2, spFDS3 };

            return SqlHelper.ExecuteNonQuery(sqlFDS, para);
        }
        #endregion

        public int deleteValue0forDataSet(FDataSet p_dataSet)
        {
            string sql = "delete from value0 where dsname = @dsname";

            SqlParameter sp1 = new SqlParameter("@dsname", p_dataSet.Name);

            SqlParameter[] para = new SqlParameter[] { sp1 };
            return SqlHelper.ExecuteNonQuery(sql, para);
        }

    }
}
