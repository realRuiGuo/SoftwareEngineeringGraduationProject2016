using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// �û�����Account
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
        /// �û���get/set
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
        /// ����get/set
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
