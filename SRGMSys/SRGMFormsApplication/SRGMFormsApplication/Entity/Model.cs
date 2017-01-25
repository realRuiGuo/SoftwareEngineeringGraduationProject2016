using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Model {

    private String m_name;
    private String m_path;
    private String m_expression;
    private List<Parameter> m_parameters;
    private ModelType m_type;
    private int m_owner;
    private String m_shape;

   /// <summary>
   /// ģ������
   /// </summary>
    public String Name
    {
        get
        { 
            return m_name;
        }
        set 
        { 
            m_name = value;
        }
    }
    /// <summary>
    ///ģ�ͱ��ʽ
    /// </summary>
    public String Expression
    {
        get 
        {
            return m_expression; 
        }
        set
        { 
            m_expression = value; 
        }
    }

    /// <summary>
    /// �����б�
    /// </summary>
    public List<Parameter> Parameters
    {
        get 
        { 
            return m_parameters; 
        }
        set 
        { 
            m_parameters = value; 
        }
    }
   /// <summary>
   /// ģ������
   /// </summary>
    public ModelType Type
    {
        get 
        {
            return m_type;
        }
        set
        { 
            m_type = value; 
        }
    }
    /// <summary>
    /// permission
    /// </summary>
    public int Owner
    {
        get 
        { 
            return m_owner; 
        }
        set
        { 
            m_owner = value;
        }
    }
    public String Path
    {
        get { return m_path; }
        set { m_path = value; }
    }
    public String Shape
    {
        get { return m_shape; }
        set { m_shape = value; }
    }
}
