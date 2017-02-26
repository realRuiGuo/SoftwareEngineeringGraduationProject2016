using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SRGMFormsApplication.BLL;

namespace SRGMFormsApplication.Entity
{
    /// <summary>
    /// �������ʦʵ����
    /// </summary>
    public class SoftwareEngineer : Account
    {
        static DataSetController dc = new DataSetController();
        private List<FDataSet> m_dataSets;

        public SoftwareEngineer()
        {
            
        }
        /// <summary>
        /// ����ʱ�����ݿ⣬����m_dataSets����
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
        /// ӵ�е����ݼ��б�
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
