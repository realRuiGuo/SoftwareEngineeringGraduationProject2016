using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SRGMFormsApplication.DAL
{
    public class AccountDB
    {
        /// <summary>
        /// 根据用户名查找用户
        /// </summary>
        /// <param name="p_userName"></param>
        /// <returns></returns>
       public bool findSEbyUserName(string p_userName)
        {
            bool result = true;
            int userCount = 0;
           //从表se中查
            string sqlse = "select count(*) from se where username=@userName";
            SqlParameter[] paramse ={
                                       new SqlParameter("@userName",SqlDbType.Char)
                                   };
            paramse[0].Value = p_userName;
            userCount = ((int)(SqlHelper.ExecuteScalar(sqlse, paramse)));
           if(0 == userCount)
           {
               result = false;
           }
            return result;
        }


        public bool findSRbyUserName(string p_userName)
        {
            bool result = true;
            int userCount = 0;
            //从表sr中查
            string sqlsr = "select count(*) from sr where username=@userName";
            SqlParameter[] paramsr ={
                                       new SqlParameter("@userName",SqlDbType.Char)
                                   };
            paramsr[0].Value = p_userName;
            userCount = ((int)(SqlHelper.ExecuteScalar(sqlsr, paramsr)));
           if(0 == userCount)
           {
               result = false;
           }
            return result;
        }
 
        /// <summary>
        /// 插入用户
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
       public int addSE(Account account)
       {
           string sql = "insert into se values(@username,@password)";

           SqlParameter sp1 = new SqlParameter("@username", account.UserName);
           SqlParameter sp2 = new SqlParameter("@password", account.Password);

           SqlParameter[] para = new SqlParameter[] { sp1, sp2};

           return SqlHelper.ExecuteNonQuery(sql, para);
       }
       public int addSR(Account account)
       {
           string sql = "insert into sr values(@username,@password)";

           SqlParameter sp1 = new SqlParameter("@username", account.UserName);
           SqlParameter sp2 = new SqlParameter("@password", account.Password);

           SqlParameter[] para = new SqlParameter[] { sp1, sp2};

           return SqlHelper.ExecuteNonQuery(sql, para);
       }

       #region 登陆方法
       /// <summary>
       /// 登陆方法，通过用户名和密码登陆，Account状态为空时表示没有这个用户，如果password=null,表示密码错误，登陆成功返回完整的Account信息
       /// </summary>
       /// <param name="username"></param>
       /// <param name="pwd"></param>
       /// <returns>UserInfo</returns>
       public Account Login(Account p_account, int p_type)
       {
           string sql = null;
           if(0 == p_type)
           {
                sql = "select username,password from admin where username=@Username";
           }
           else if(1 == p_type)
           {
                sql = "select username,password from se where username=@Username";
           }
           else if(2 == p_type)
           {
                sql = "select username,password from sr where username=@Username";
           }
           SqlParameter para = new SqlParameter("@Username", p_account.UserName);
           DataSet ds = SqlHelper.ExecuteReaderDataSet(sql, para);
           Account account = new Account();
           foreach (DataRow dr in ds.Tables[0].Rows)
           {
               if (p_account.Password == dr["password"].ToString())
               {
                   account.UserName = dr["username"].ToString();
                   account.Password = dr["password"].ToString();
                   return account;
               }
               else
               {
                   account.Password = null;
                   return account;
               }
           }
           return null;
       }
       #endregion

       #region 得到所有se信息，返回DataSet
       /// <summary>
       /// 得到所有se信息
       /// </summary>
       /// <returns></returns>
       public DataSet GetAllSEDataSet()
       {
           string sql = "select * from se";
           DataSet ds = SqlHelper.ExecuteReaderDataSet(sql);
           return ds;
       }
       #endregion

       #region 得到所有sr信息，返回DataSet
       /// <summary>
       /// 得到所有se信息
       /// </summary>
       /// <returns></returns>
       public DataSet GetAllSRDataSet()
       {
           string sql = "select * from sr";
           DataSet ds = SqlHelper.ExecuteReaderDataSet(sql);
           return ds;
       }
       #endregion

       #region 删除SE的方法
       /// <summary>
       /// 删除SE方法
       /// </summary>
       /// <param name="m_SE"></param>
       /// <returns></returns>
       public int DeleteSE(SoftwareEngineer m_SE)
       {
           //step1 删除SE拥有的FDataSets
           string sqlFDS = "delete from dataset where username=@username and permission=@permission";
           SqlParameter spFDS1 = new SqlParameter("@username", m_SE.UserName);
           SqlParameter spFDS2 = new SqlParameter("@permission", 1);
           SqlParameter[] para = new SqlParameter[] { spFDS1, spFDS2 };
           SqlHelper.ExecuteNonQuery(sqlFDS, para);

           //step2 删除SE用户
           string sqlSE = "delete from se where username=@username";
           SqlParameter spSE1= new SqlParameter("@username", m_SE.UserName);

           return SqlHelper.ExecuteNonQuery(sqlSE, spSE1);
       }
       #endregion

       #region 删除SR的方法
       /// <summary>
       /// 删除SR方法
       /// </summary>
       /// <param name="m_SR"></param>
       /// <returns></returns>
       public int DeleteSR(SRGMResearch m_SR)
       {
           //step1 删除SR拥有的FDataSets
           string sqlFDS = "delete from dataset where username=@username and permission=@permission";
           SqlParameter spFDS1 = new SqlParameter("@username", m_SR.UserName);
           SqlParameter spFDS2 = new SqlParameter("@permission", 2);
           SqlParameter[] paraFDS = new SqlParameter[] { spFDS1, spFDS2 };
           SqlHelper.ExecuteNonQuery(sqlFDS, paraFDS);

           //step2 删除SR拥有的Models
           string sqlModel = "delete from model where username=@username and permission=@permission";
           SqlParameter spModel1 = new SqlParameter("@username", m_SR.UserName);
           SqlParameter spModel2 = new SqlParameter("@permission", 2);
           SqlParameter[] paraModel = new SqlParameter[] { spModel1, spModel2 };
           SqlHelper.ExecuteNonQuery(sqlModel, paraModel);

           //step3 删除SR用户
           string sqlSR = "delete from sr where username=@username";
           SqlParameter spSR = new SqlParameter("@username", m_SR.UserName);

           return SqlHelper.ExecuteNonQuery(sqlSR, spSR);
       }
       #endregion

    }
}
