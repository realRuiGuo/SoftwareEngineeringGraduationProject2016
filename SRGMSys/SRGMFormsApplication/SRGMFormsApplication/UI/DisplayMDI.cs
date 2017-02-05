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
    public partial class DisplayMDI : Form
    {
        private int childFormNumber = 0;
        private static DisplayMDI instance = null;
        Account account;
        int userType;
        List<Model> modelList;
        List<FDataSet> dataSetList;

        SelectForm frmSelect;
        FitForm frmFit;
        ReForm frmRe;

        public static DisplayMDI Instance//单例
        {
            set { }
            get
            {
                if (instance == null)
                {
                    new DisplayMDI();
                }
                return instance;
            }
        }
        private void DisplayMDI_FormClosed(object sender, FormClosedEventArgs e)
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

        public DisplayMDI()
        {
            InitializeComponent();
            instance = this;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
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
    }
}
