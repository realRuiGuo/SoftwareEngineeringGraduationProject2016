using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// 软件工程师实体类
/// </summary>
public class SoftwareEngineer : Account{
	private List<FDataSet> m_dataSets;

    /// <summary>
    /// 构造时读数据库，设置m_dataSets属性
    /// </summary>
    public SoftwareEngineer()
    {

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
