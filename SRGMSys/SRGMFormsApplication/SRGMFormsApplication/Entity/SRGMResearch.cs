using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// SRGM�о���Աʵ����
/// </summary>
public class SRGMResearch : Account{
	private List<Model> m_models ;
	private List<FDataSet> m_dataSets ;

    /// <summary>
    /// ӵ�е�ģ���б�
    /// </summary>
    public List<Model> Models
    {
        get
        {
            return this.m_models;
        }
        set
        {
            this.m_models = value;
        }
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
