using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class InitialValue {
    private float m_value0;  //������ֵ
    private FDataSet m_dataSet;

   /// <summary>
   /// ��ʼֵ
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
    /// ��ֵ��Ӧ��ʧЧ���ݼ�
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
