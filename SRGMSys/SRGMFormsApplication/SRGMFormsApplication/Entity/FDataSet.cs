using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// 失效数据集实体类
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
        /// 数据集名
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
        /// 来源
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
        /// 发布日期
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
        /// 存储路径
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
        /// 拥有者、操作权限permission
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
        /// 数据集类型
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
