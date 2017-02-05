using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRGMFormsApplication.Entity;

namespace SRGMFormsApplication.UI
{

    public partial class DisplayForm : Form
    {
        private static DisplayForm instance = null;
        Account account;
        int userType;
        List<Model> modelList;
        List<FDataSet> dataSetList;

        SelectForm frmSelect;
        FitForm frmFit;
        ReForm frmRe;
        private float X;
        private float Y;

        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    setTag(con);
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytag[0]) * newx;
                con.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * newy;
                con.Height = (int)(a);
                a = Convert.ToSingle(mytag[2]) * newx;
                con.Left = (int)(a);
                a = Convert.ToSingle(mytag[3]) * newy;
                con.Top = (int)(a);
                Single currentSize = Convert.ToSingle(mytag[4]) * Math.Min(newx, newy);
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    setControls(newx, newy, con);
                }
            }
        }
        public static DisplayForm Instance//单例
        {
            set { }
            get
            {
                if (instance == null)
                {
                    new DisplayForm();
                }
                return instance;
            }
        }

        private void DisplayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
        public Account Account
        {
            get { return account; }
            set { account = value; }
        }
        public int UserType
        {
            get { return userType; }
            set { userType = value; }
        }
        public List<Model> ModelList
        {
            get { return modelList; }
            set { modelList = value; }
        }
        public List<FDataSet> DataSetList
        {
            get { return dataSetList; }
            set { dataSetList = value; }
        }
        public DisplayForm()
        {
            InitializeComponent();
            instance = this;
            X = this.Width;
            Y = this.Height;  
        }

        private void selectLabel_Click(object sender, EventArgs e)
        {
            frmSelect = SelectForm.Instance;
            frmSelect.Owner = this;
            //设置子窗口不显示为顶级窗口
            frmSelect.TopLevel = false;
            //设置子窗口的样式，没有上面的标题栏
            frmSelect.FormBorderStyle = FormBorderStyle.None;
            //填充
            frmSelect.Dock = DockStyle.Fill;
            //清空Panel里面的控件
            this.panel1.Controls.Clear();
            //加入控件
            this.panel1.Controls.Add(frmSelect);
            //设置演示窗口参数
            frmSelect.Account = this.Account;
            frmSelect.UserType = this.UserType;
            //让窗体显示
            frmSelect.Show();
        }

        private void fitLabel_Click(object sender, EventArgs e)
        {
            frmFit = FitForm.Instance;
            frmFit.MdiParent = this;
            frmFit.TopLevel = false;
            frmFit.FormBorderStyle = FormBorderStyle.None;
            frmFit.Dock = DockStyle.Fill;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(frmFit);
            frmFit.ModelList = this.ModelList;
            frmFit.DataSetList = this.DataSetList;
            frmFit.Show();
        }

        private void reLabel_Click(object sender, EventArgs e)
        {
            frmRe = ReForm.Instance;
            frmRe.TopLevel = false;
            frmRe.FormBorderStyle = FormBorderStyle.None;
            frmRe.Dock = DockStyle.Fill;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(frmRe);
            frmRe.ModelList = this.ModelList;
            frmRe.DataSetList = this.DataSetList;
            frmRe.Show();
        }

        private void DisplayForm_Load(object sender, System.EventArgs e)
        {
            this.Resize += new EventHandler(DisplayForm_Resize);
            setTag(this);
            //SelectForm_Resize(new object(), new EventArgs());//x,y可在实例化时赋值,最后这句是新加的，在MDI时有用
        }

        private void DisplayForm_Resize(object sender, System.EventArgs e)
        {
            float newx = (this.Width) / X;
            float newy = this.Height / Y;
            setControls(newx, newy, this);
        }
    }
}
