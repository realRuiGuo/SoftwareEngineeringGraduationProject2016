using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SRGMFormsApplication.Entity
{
    public class Parameter
    {

        private String m_name;
        private float m_value;     //拟合值
        private InitialValue m_initialValue;    //参数初值
        //private String m_meaning ;

        /// <summary>
        /// 参数名（字母）
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
        /// <summary>
        /// 参数拟合值
        /// </summary>
        public float Value
        {
            get
            {
                return m_value;
            }
            set
            {
                m_value = value;
            }
        }
        /// <summary>
        /// 参数初始值
        /// </summary>
        public InitialValue InitialValue
        {
            get
            {
                return m_initialValue;
            }
            set
            {
                m_initialValue = value;
            }
        }

    }

}
