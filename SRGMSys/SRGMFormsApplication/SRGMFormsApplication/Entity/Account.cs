using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// 用户基类Account
/// </summary>

namespace SRGMFormsApplication.Entity
{
    public class Account
    {
        private String m_userName;
        private String m_password;

        public Account()
        {

        }

        public Account(string p_userName, string p_password)
        {
            this.UserName = p_userName;
            this.Password = p_password;
        }
        /// <summary>
        /// 用户名get/set
        /// </summary>
        public String UserName
        {
            get
            {
                return this.m_userName;
            }
            set
            {
                this.m_userName = value;
            }
        }
        /// <summary>
        /// 密码get/set
        /// </summary>
        public String Password
        {
            get
            {
                return this.m_password;
            }
            set
            {
                this.m_password = value;
            }
        }
    }

}
