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
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using SRGM;

namespace SRGMFormsApplication.UI
{
    public partial class SelectForm : Form
    {
        private static SelectForm instance = null;
        Account account;
        int userType;
        
        public static SelectForm Instance//单例
        {
            set { }
            get
            {
                if (instance == null)
                {
                    new SelectForm();
                }
                return instance;
            }
        }
        private void SelectForm_FormClosed(object sender, FormClosedEventArgs e)
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
        public SelectForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            //根据用户配置comboBox
            modelcomboBox.Items.Add("系统模型");
            dataSetcomboBox.Items.Add("系统数据集");
            if (3 != this.UserType)
            {
                dataSetcomboBox.Items.Add("用户数据集");
                if (2 == this.UserType)
                {
                    modelcomboBox.Items.Add("用户模型");
                }
            }
        }

        private void modelcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelController mc = new ModelController();
            if ("系统模型" == modelcomboBox.SelectedItem.ToString())
            {
                modeldataGridView.DataSource = mc.getModelsforSystem().Tables[0];
            }
            else if ("用户模型" == modelcomboBox.SelectedItem.ToString())
            {
                modeldataGridView.DataSource = mc.getModelsforUser(this.Account, this.UserType).Tables[0];
            }
        }

        private void dataSetcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSetController dc = new DataSetController();
            if ("系统数据集" == this.dataSetcomboBox.SelectedItem.ToString())
            {
                dataSetdataGridView.DataSource = dc.getDataSetsforSystem().Tables[0];
            }
            else if ("用户数据集" == dataSetcomboBox.SelectedItem.ToString())
            {
                dataSetdataGridView.DataSource = dc.getDataSetsforUser(this.Account, this.UserType).Tables[0];
            }
        }

        private void addModelbutton_Click(object sender, EventArgs e)
        {
            if (null != modeldataGridView.CurrentRow)
            {
                int row = modeldataGridView.CurrentRow.Index;
                string modelName = modeldataGridView.Rows[row].Cells[0].Value.ToString();
                if (!modellistBox.Items.Contains(modelName))//不重复插入
                {
                    modellistBox.Items.Add(modelName);
                }
            }
        }

        private void addDataSetbutton_Click(object sender, EventArgs e)
        {
            if (null != dataSetdataGridView.CurrentRow)
            {
                int row = dataSetdataGridView.CurrentRow.Index;
                string dataSetName = dataSetdataGridView.Rows[row].Cells[0].Value.ToString();
                if (!datasetlistBox.Items.Contains(dataSetName))//不重复插入
                {
                    datasetlistBox.Items.Add(dataSetName);
                }
            }
        }

        private void delModelbutton_Click(object sender, EventArgs e)
        {
            int row = modellistBox.SelectedIndex;
            if (row >= 0)
            {
                modellistBox.Items.RemoveAt(row);
            }
        }

        private void delDataSetbutton_Click(object sender, EventArgs e)
        {
            int row = datasetlistBox.SelectedIndex;
            if (row >= 0)
            {
                datasetlistBox.Items.RemoveAt(row);
            }
        }

        private void modelbutton_Click(object sender, EventArgs e)
        {

            //
            DisplayMDI frmDisplay = (DisplayMDI)this.Owner;

        }

        private void dataSetbutton_Click(object sender, EventArgs e)
        {

            DisplayMDI frmDisplay = (DisplayMDI)this.Owner;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            MnDSn t1 = new MnDSn();
            MWCharArray modelName = "fmodel0".Trim();
            MWCharArray dataSetName = "DS10".Trim();
            MWNumericArray xmd0 = new double[] { 22.878, 0.00397 };
            t1.T1MnDSn(modelName,dataSetName, xmd0);
        }
    }
}
