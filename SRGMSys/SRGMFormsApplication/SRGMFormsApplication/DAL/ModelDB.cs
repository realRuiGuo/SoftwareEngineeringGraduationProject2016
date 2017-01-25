﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace SRGMFormsApplication.DAL
{
    public class ModelDB
    {
        #region 得到系统自带Model信息，返回DataSet
        /// <summary>
        /// 得到系统自带Model信息
        /// </summary>
        /// <returns></returns>
        public DataSet getModelsforSystem()
        {
            string sql = "select m.modelname as 名称,mt.name as 类型 from model m,modeltype mt" +
               " where m.permission=@permission and m.typeID=mt.typeID";

            SqlParameter sp = new SqlParameter("@permission", 0);

            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql, sp);
            return ds;
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
            string sql = "select m.modelname as 名称,mt.name as 类型 from model m,modeltype mt" +
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
            string sql = "insert into model values(@modelname,@path,@permission,@username,@shape,@typeID)";

            SqlParameter sp1 = new SqlParameter("@modelname", p_model.Name);
            SqlParameter sp2 = new SqlParameter("@path", p_model.Path);
            SqlParameter sp3 = new SqlParameter("@permission", 0);
            SqlParameter sp4 = new SqlParameter("@username", null);
            SqlParameter sp5 = new SqlParameter("@shape",p_model.Shape);
            SqlParameter sp6 = new SqlParameter("@typeID", p_model.Type);

            SqlParameter[] para = new SqlParameter[] { sp1, sp2, sp3, sp4, sp5, sp6 };

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
            string sql = "insert into model values(@modelname,@path,@permission,@username,@shape,@typeID)";

            SqlParameter sp1 = new SqlParameter("@modelname", p_model.Name);
            SqlParameter sp2 = new SqlParameter("@path", p_model.Path);
            SqlParameter sp3 = new SqlParameter("@permission", p_userType);
            SqlParameter sp4 = new SqlParameter("@username", p_account.UserName);
            SqlParameter sp5 = new SqlParameter("@shape", p_model.Shape);
            SqlParameter sp6 = new SqlParameter("@typeID", p_model.Type);

            SqlParameter[] para = new SqlParameter[] { sp1, sp2, sp3, sp4, sp5, sp6 };

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
            string sql = "delete from model where modelname=@modelname and username=@username and permission=@permission";
            SqlParameter sp1 = new SqlParameter("@modelname", p_model.Name);
            SqlParameter sp2 = new SqlParameter("@username", null);
            SqlParameter sp3 = new SqlParameter("@permission",0);

            SqlParameter[] para = new SqlParameter[] { sp1, sp2, sp3 };

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
            string sql = "delete from model where modelname=@modelname and username=@username and permission=@permission";
            SqlParameter sp1 = new SqlParameter("@modelname", p_model.Name);
            SqlParameter sp2 = new SqlParameter("@username", p_account.UserName);
            SqlParameter sp3 = new SqlParameter("@permission", p_userType);

            SqlParameter[] para = new SqlParameter[] { sp1, sp2, sp3 };

            return SqlHelper.ExecuteNonQuery(sql, para);
        }
        #endregion
    }
}
