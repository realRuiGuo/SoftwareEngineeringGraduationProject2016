using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// SRGM研究人员实体类
/// </summary>
public class SRGMResearch : Account{
	private List<Model> m_models ;
	private List<FDataSet> m_dataSets ;

    /// <summary>
    /// 拥有的模型列表
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
