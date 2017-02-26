using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SRGMFormsApplication.BLL;

namespace SRGMFormsApplication.Entity
{
    /// <summary>
    /// 软件工程师实体类
    /// </summary>
    public class SoftwareEngineer : Account
    {
        static DataSetController dc = new DataSetController();
        private List<FDataSet> m_dataSets;

        public SoftwareEngineer()
        {
            
        }
        /// <summary>
        /// 构造时读数据库，设置m_dataSets属性
        /// </summary>
        public SoftwareEngineer(string p_userName)
        {
            this.UserName = p_userName;
            int userType = 1;
            Account account = new Account();
            account.UserName = p_userName;
            DataSets = dc.getDataSetsfoUserL(account,userType);
        }
        /// <summary>
        /// 拥有的数据集列表
        /// </summary>
        public List<FDataSet> DataSets
        {
            get
            {
                return this.m_dataSets;
            }
            set
            {
                this.m_dataSets = value;
            }
        }
    }

}
