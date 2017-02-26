using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRGMFormsApplication.BLL;
using SRGMFormsApplication.Entity;

namespace SRGMFormsApplication.UI
{
    public partial class ModelForm : Form
    {
        private static ModelForm instance = null;
        static ModelController mc = new ModelController();
        static DataSetController dc = new DataSetController();
        Account account;
        int userType;
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
        public static ModelForm Instance//单例
        {
            set { }
            get
            {
                if (instance == null)
                {
                    new ModelForm();
                }
                return instance;
            }
        }
        private void ModelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
        public ModelForm()
        {
            InitializeComponent();
            instance = this;
            X = this.Width;
            Y = this.Height;
        }
        private void ModelForm_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(ModelForm_Resize);
            setTag(this);
            if (0 == this.UserType)
            {
                this.label1.Text = "系统模型";
            }
            else
            {
                this.label1.Text = "用户模型";
            }
            this.modelTypedataGridView.DataSource = mc.getModelType().Tables[0];
            this.value0dataGridView.DataSource = mc.getAllValue0().Tables[0];
            updateGridView();

            //初始化dataSetcomboBox
            List<FDataSet> DataSet = new List<FDataSet>();
            DataSet = dc.getDataSetsforSystemL();
            this.dataSetcomboBox.Items.Add("请选择");
            foreach (FDataSet ds in DataSet)
            {
                this.dataSetcomboBox.Items.Add(ds.Name);
            }
            this.dataSetcomboBox.SelectedIndex = 0;
        }
        public void updateGridView()
        {
            if ("系统模型" == this.label1.Text)
            {
                modeldataGridView.DataSource = mc.getModelsforSystem().Tables[0];

            }
            else if ("用户模型" == this.label1.Text)
            {
                modeldataGridView.DataSource = mc.getModelsforUser(this.Account, this.UserType).Tables[0];
            }
            //modeldataGridView.Rows[modeldataGridView.Rows.Count - 1].Selected = true;//光标锁定最后一行
            modeldataGridView.Rows[modeldataGridView.Rows.Count - 1].Cells[0].Value = "请输入";
        }
        private void addbutton_Click(object sender, EventArgs e)
        {
            if (null != modeldataGridView.CurrentRow)//所选行不为空
            {
                int row = modeldataGridView.CurrentRow.Index;
                //确保已输入?
                if (row == this.modeldataGridView.Rows.Count - 2)//所选行 为新输入行
                {
                    Model model = new Model();
                    model.Type = new ModelType();
                    if ("" != modeldataGridView.Rows[row].Cells[1].Value.ToString())
                    {
                        model.Type.TypeID = int.Parse(modeldataGridView.Rows[row].Cells[1].Value.ToString());
                        if ("" != modeldataGridView.Rows[row].Cells[0].Value.ToString())
                        {
                            model.Name = modeldataGridView.Rows[row].Cells[0].Value.ToString();
                            if ("" != modeldataGridView.Rows[row].Cells[2].Value.ToString())
                            {
                                model.ParaNum = int.Parse(modeldataGridView.Rows[row].Cells[2].Value.ToString());
                            }
                            OpenFileDialog fileDialog = new OpenFileDialog();
                            fileDialog.Multiselect = true;
                            fileDialog.Title = "请选择文件";
                            fileDialog.Filter = "(*.m)|*.m";
                            if (fileDialog.ShowDialog() == DialogResult.OK)
                            {
                                List<string> fullPath = new List<string>();
                                foreach (string filePath in fileDialog.FileNames)
                                {
                                    fullPath.Add(filePath);
                                    //string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(filePath);// 没有扩展名的文件名
                                    MessageBox.Show("已选择文件:" + filePath, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                if (0 == this.UserType)
                                {
                                    mc.addModelstoSystem(model, fullPath);
                                }
                                else
                                {
                                    //mc.addModelsforUser(model, this.Account, this.UserType, fullPath);
                                }
                                updateGridView();
                            }
                        }
                        else
                        {
                            MessageBox.Show("请填入与文件名相符的模型名！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("类型为必填项，请填入！", "提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择有数据的行！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            if (null != modeldataGridView.CurrentRow)
            {
                int row = modeldataGridView.CurrentRow.Index;
                model = mc.getModelByid(modeldataGridView.Rows[row].Cells[0].Value.ToString().Trim());
                if (0 == this.UserType)
                {
                    mc.deleteModelsfromSystem(model);
                }
                else
                {
                    mc.deleteModelsforUser(model, this.Account, this.UserType);
                }
                updateGridView();
            }
        }

        private void ModelForm_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X;
            float newy = this.Height / Y;
            setControls(newx, newy, this);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            FDataSet dataSet = new FDataSet();
            if (null != this.modeldataGridView.CurrentRow)
            {
                int row = this.modeldataGridView.CurrentRow.Index;
                if (row >= 0)
                {
                    string modelName = this.modeldataGridView.Rows[row].Cells[0].Value.ToString();
                    model.Name = modelName;
                    if (dataSetcomboBox.SelectedIndex != 0)
                    {
                        dataSet.Name = this.dataSetcomboBox.SelectedItem.ToString();
                    }
                    if (this.value0TextBox.Text.ToString() != "")
                    {
                        string value0 = this.value0TextBox.Text.ToString().Trim();
                        mc.addValue0(model, dataSet, value0);
                    }
                }
            }
            this.value0dataGridView.DataSource = mc.getAllValue0().Tables[0];
        }

        private void delValue0Button_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            FDataSet dataSet = new FDataSet();

            int row = this.value0dataGridView.CurrentRow.Index;
            if (row >= 0)
            {
                model.Name = this.value0dataGridView.Rows[row].Cells[0].Value.ToString();
                dataSet.Name = this.value0dataGridView.Rows[row].Cells[1].Value.ToString();
                string value0 = this.value0dataGridView.Rows[row].Cells[2].Value.ToString();
                mc.deleteValue0Item(model, dataSet, value0);
                this.value0dataGridView.DataSource = mc.getAllValue0().Tables[0];
            }
        }
    }
}
