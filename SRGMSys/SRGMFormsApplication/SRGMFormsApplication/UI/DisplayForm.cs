using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRGMFormsApplication.Entity;
using CCWin;

namespace SRGMFormsApplication.UI
{

    public partial class DisplayForm : CCSkinMain
    {
        private static DisplayForm instance = null;
        Account account;
        int userType;
        List<Model> modelList = new List<Model>();
        List<FDataSet> dataSetList = new List<FDataSet>();

        SelectForm frmSelect;
        FitForm frmFit;
        ReForm frmRe;
        CompareForm frmCom;

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
        }
        private void DisplayForm_Load(object sender, System.EventArgs e)
        {
            this.selectLabel_Click(sender,e);
        }

        public void selectLabel_Click(object sender, EventArgs e)
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

        public void fitLabel_Click(object sender, EventArgs e)
        {
            frmFit = FitForm.Instance;
            //frmFit.MdiParent = this;
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

        private void compareLabel_Click(object sender, EventArgs e)
        {
            frmCom = CompareForm.Instance;
            if (frmCom != null)
            {
                frmCom.TopLevel = false;
                frmCom.FormBorderStyle = FormBorderStyle.None;
                frmCom.Dock = DockStyle.Fill;
                this.panel1.Controls.Clear();
                this.panel1.Controls.Add(frmCom);
                frmCom.ModelList = this.ModelList;
                frmCom.DataSetList = this.DataSetList;
                frmCom.Show();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
