using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SRGMFormsApplication.Entity
{
    public class Parameter
    {

        private String m_name;
        private float m_value;     //���ֵ
        private InitialValue m_initialValue;    //������ֵ
        //private String m_meaning ;

        /// <summary>
        /// ����������ĸ��
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
        /// �������ֵ
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
        /// ������ʼֵ
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
