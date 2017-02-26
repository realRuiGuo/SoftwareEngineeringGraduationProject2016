using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// ʧЧ���ݼ�ʵ����
/// </summary>

namespace SRGMFormsApplication.Entity
{
    public class FDataSet
    {
        private string m_name;
        private string m_sourse;
        private string m_postDate;
        private string m_path;
        private int m_owner;
        private FDataSetType m_type;
        private int m_cp;

        /// <summary>
        /// ���ݼ���
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
        /// ��Դ
        /// </summary>
        public String Source
        {
            get
            {
                return this.m_sourse;
            }
            set
            {
                this.m_sourse = value;
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public String PostDate
        {
            get
            {
                return m_postDate;
            }
            set
            {
                m_postDate = value;
            }
        }
        /// <summary>
        /// �洢·��
        /// </summary>
        public String Path
        {
            get
            {
                return m_path;
            }
            set
            {
                m_path = value;
            }
        }
        /// <summary>
        /// ӵ���ߡ�����Ȩ��permission
        /// </summary>
        public int Owner
        {
            get
            {
                return m_owner;
            }
            set
            {
                m_owner = value;
            }
        }
        /// <summary>
        /// ���ݼ�����
        /// </summary>
        public FDataSetType Type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
            }
        }

        public int Cp
        {
            get { return m_cp; }
            set { m_cp = value; }
        }
    }

}
