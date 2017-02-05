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
    public partial class DataSetForm : Form
    {
        private static DataSetForm instance = null;
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
        public static DataSetForm Instance//单例
        {
            set { }
            get
            {
                if (instance == null)
                {
                    new DataSetForm();
                }
                return instance;
            }
        }
        private void DataSetForm_FormClosed(object sender, FormClosedEventArgs e)
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

        public DataSetForm()
        {
            InitializeComponent();
            instance = this;
            X = this.Width;
            Y = this.Height;
        }

        private void DataSetForm_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(DataSetForm_Resize);
            setTag(this);
            //DataSetForm_Resize(new object(), new EventArgs());//x,y可在实例化时赋值,最后这句是新加的，在MDI时有用
            if(0 == this.UserType)
            {
                this.label1.Text = "系统数据集";
            }
            else
            {
                this.label1.Text = "用户数据集";
            }
            updateGridView();
        }
        public void updateGridView()
        {
            if ("系统数据集" == this.label1.Text)
            {
                dataSetdataGridView.DataSource = dc.getDataSetsforSystem().Tables[0];
            }
            else if ("用户数据集" == this.label1.Text)
            {
                dataSetdataGridView.DataSource = dc.getDataSetsforUser(this.Account, this.UserType).Tables[0];
            }
        }
        private void addbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "(*.txt)|*.txt"; 
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath  = fileDialog.FileName;
                string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(filePath);// 没有扩展名的文件名
                MessageBox.Show("已选择文件:" + filePath, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FDataSet dataset = new FDataSet();
                dataset.Name = fileNameWithoutExtension;
                if (null != dataSetdataGridView.CurrentRow)
                {
                    int row = dataSetdataGridView.CurrentRow.Index;
                    dataset.Source = dataSetdataGridView.Rows[row].Cells[1].Value.ToString();
                    dataset.PostDate = dataSetdataGridView.Rows[row].Cells[2].Value.ToString();
                    dataset.Type = new FDataSetType();
                    dataset.Type.TypeID = int.Parse(dataSetdataGridView.Rows[row].Cells[3].Value.ToString());
                    if(0 == this.UserType)
                    {
                        dc.addDataSetstoSystem(dataset,filePath);
                    }
                    else
                    {
                        dc.addDataSetsforUser(dataset, this.Account, this.UserType, filePath);
                    }
                    updateGridView();
                }
            }
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            FDataSet dataset = new FDataSet();        
            if (null != dataSetdataGridView.CurrentRow)
            {
                int row = dataSetdataGridView.CurrentRow.Index;
                dataset = dc.getDataSetByid(dataSetdataGridView.Rows[row].Cells[0].Value.ToString().Trim());
                if (0 == this.UserType)
                {
                    dc.deleteDataSetsfromSystem(dataset);
                }
                else
                {
                    dc.deleteDataSetsforUser(dataset, this.Account, this.UserType);
                }
                updateGridView();
            }
        }

        private void DataSetForm_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X;
            float newy = this.Height / Y;
            setControls(newx, newy, this);
            //this.Text = this.Width.ToString() + " " + this.Height.ToString();
        }
    }
}
