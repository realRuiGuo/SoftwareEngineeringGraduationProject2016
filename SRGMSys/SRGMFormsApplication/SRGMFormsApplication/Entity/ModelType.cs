using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SRGMFormsApplication.Entity
{
    public class ModelType
    {
        private int m_typeID;
        private String m_name;

        /// <summary>
        /// ģ�����ͱ��
        /// </summary>
        public int TypeID
        {
            get
            {
                return m_typeID;
            }
            set
            {
                m_typeID = value;
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public String Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }
    }

}
