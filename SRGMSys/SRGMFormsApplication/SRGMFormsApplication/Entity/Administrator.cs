using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// ϵͳ����Աʵ����
/// </summary>

namespace SRGMFormsApplication.Entity
{
    public class Administrator : Account
    {

        private String m_name;
        private String m_phoneNum;

        // List<Record> records ;

        /// <summary>
        /// ����
        /// </summary>
        public String Name
        {
            get
            {
                return this.m_name;
            }
            set
            {
                this.m_name = value;
            }
        }
        /// <summary>
        ///�绰����
        /// </summary>
        public String PhoneNum
        {
            get
            {
                return this.m_phoneNum;
            }
            set
            {
                this.m_phoneNum = value;
            }
        }
    }

}
