using System;
using System.Collections;
using System.Linq;
using System.Data;
using SRGMFormsApplication.DAL;
using SRGMFormsApplication.Entity;

/// <summary>
/// 账户控制类
/// </summary>
namespace SRGMFormsApplication.BLL
{
    public class AccountController
    {

        static AccountDB aDB = new AccountDB();
        /// <summary>
        /// 根据用户类型 注册用户
        /// </summary>
        /// <param name="p_account"></param>
        /// <param name="p_type"></param>
        /// <returns></returns>
        public String signin(Account p_account, int p_type)
        {
            if (null != p_account.UserName && "" != p_account.UserName)//判断用户名不为空
            {
                Boolean had = false;
                if (1 == p_type)
                {
                    had = aDB.findSEbyUserName(p_account.UserName);
                }
                else if (2 == p_type)
                {
                    had = aDB.findSRbyUserName(p_account.UserName);
                }
                else if (0 == p_type)
                {
                    return "不允许注册管理员";
                }
                if (true != had)//用户名可用
                {
                    if (null != p_account.Password && "" != p_account.Password)//判断密码不为空
                    {
                        //将该用户插入到数据库
                        if (1 == p_type)//注册软件工程师
                        {
                            aDB.addSE(p_account);
                        }
                        else if (2 == p_type)//注册SRGM研究人员
                        {
                            aDB.addSR(p_account);
                        }
                        return "注册成功！";
                    }
                    else
                    {
                        return "请输入密码！";
                    }
                }
                else
                {
                    return "用户名已存在！";
                }
            }
            else
            {
                return "请输入用户名！";
            }
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="p_account"></param>
        public Account login(Account p_account, int p_type)
        {
            return aDB.Login(p_account, p_type);
        }
        /// <summary>
        /// 系统管理员查看软件工程师个人信息
        /// </summary>
        public DataSet getSoftwareEngineer()
        {
            return aDB.GetAllSEDataSet();
        }
        /// <summary>
        /// 系统管理员查看SRGM研究人员个人信息
        /// </summary>
        public DataSet getSRGMResearcher()
        {
            return aDB.GetAllSRDataSet();
        }
        /// <summary>
        /// 删除软件工程师
        /// </summary>
        /// <param name="p_SE"></param>
        /// <returns></returns>
        public int deleteSE(SoftwareEngineer p_SE)
        {
            return aDB.DeleteSE(p_SE);
        }
        /// <summary>
        /// 删除SRGM研究人员
        /// </summary>
        /// <param name="p_SR"></param>
        /// <returns></returns>
        public int deleteSR(SRGMResearch p_SR)
        {
            return aDB.DeleteSR(p_SR);
        }
    }
}
