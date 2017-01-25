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
    /// 类型编号
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
   /// 时间类型
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
 ///有无wt
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
/// 有无ct
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
