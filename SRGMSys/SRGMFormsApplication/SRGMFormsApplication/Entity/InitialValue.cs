using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class InitialValue {
    private float m_value0;  //参数初值
    private FDataSet m_dataSet;

   /// <summary>
   /// 初始值
   /// </summary>
    public float Value0
    {
        get
        { 
            return m_value0; 
        }
        set
        {
            m_value0 = value;
        }
    }

    /// <summary>
    /// 初值对应的失效数据集
    /// </summary>
    public FDataSet DataSet
    {
        get
        { 
            return m_dataSet;
        }
        set 
        {
            m_dataSet = value; 
        }
    }
}
