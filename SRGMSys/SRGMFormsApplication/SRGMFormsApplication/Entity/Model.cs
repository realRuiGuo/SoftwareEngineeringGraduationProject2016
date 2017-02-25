using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SRGMFormsApplication.Entity
{
    public class Model
    {

        private string m_name;
        private string m_path;
        private string m_expression;
        private List<Parameter> m_parameters;
        private ModelType m_type;
        private int m_owner;
        private string m_shape;
        private int m_paraNum;

        /// <summary>
        /// 模型名称
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
        ///模型表达式
        /// </summary>
        public String Expression
        {
            get
            {
                return m_expression;
            }
            set
            {
                m_expression = value;
            }
        }

        /// <summary>
        /// 参数列表
        /// </summary>
        public List<Parameter> Parameters
        {
            get
            {
                return m_parameters;
            }
            set
            {
                m_parameters = value;
            }
        }
        /// <summary>
        /// 模型类型
        /// </summary>
        public ModelType Type
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
        /// <summary>
        /// permission
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
        public String Path
        {
            get { return m_path; }
            set { m_path = value; }
        }
        public String Shape
        {
            get { return m_shape; }
            set { m_shape = value; }
        }

        public int ParaNum
        {
            get { return m_paraNum; }
            set { m_paraNum = value; }
        }


    }
}
