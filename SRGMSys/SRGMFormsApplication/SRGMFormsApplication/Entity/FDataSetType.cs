using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class FDataSetType {

    private String m_typeID;
    private String m_timeType;
    private Boolean m_wt;
    private Boolean m_ct;
    /// <summary>
    /// ���ͱ��
    /// </summary>
    public String TypeID
    {
        get 
        { 
            return m_typeID;
        }
        set 
        { 
            m_typeID = value; 
        }
    }
   /// <summary>
   /// ʱ������
   /// </summary>
    public String TimeType
    {
        get 
        { 
            return m_timeType; 
        }
        set
        { 
            m_timeType = value;
        }
    }
 /// <summary>
 ///����wt
 /// </summary>
    public Boolean Wt
    {
        get 
        {
            return m_wt;
        }
        set 
        {
            m_wt = value; 
        }
    }
/// <summary>
/// ����ct
/// </summary>
    public Boolean Ct
    {
        get
        { 
            return m_ct; 
        }
        set 
        {
            m_ct = value; 
        }
    }
}
