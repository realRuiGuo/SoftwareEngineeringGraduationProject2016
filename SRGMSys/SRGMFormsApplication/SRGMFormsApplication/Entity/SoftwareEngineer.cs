using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// �������ʦʵ����
/// </summary>
public class SoftwareEngineer : Account{
	private List<FDataSet> m_dataSets;

    /// <summary>
    /// ����ʱ�����ݿ⣬����m_dataSets����
    /// </summary>
    public SoftwareEngineer()
    {

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
