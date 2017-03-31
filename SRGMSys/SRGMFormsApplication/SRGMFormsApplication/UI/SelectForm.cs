using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRGMFormsApplication.BLL;
using SRGMFormsApplication.DAL;
using SRGMFormsApplication.Entity;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using Matlab;
using System.Threading;

namespace SRGMFormsApplication.UI
{
    public partial class SelectForm : Form
    {
        private static SelectForm instance = null;
        static ModelController mc = new ModelController();
        static DataSetController dc = new DataSetController();
        static DisplayController disc = new DisplayController();
        Account account;
        int userType;
        List<Model> modelList = new List<Model>();
        List<FDataSet> dataSetList = new List<FDataSet>();

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

            this.modelcomboBox.Text = "系统模型";
            this.dataSetcomboBox.Text = "系统数据集";
            this.modelcomboBox_SelectedIndexChanged(sender, e);
            this.dataSetcomboBox_SelectedIndexChanged(sender, e);
        }

        private void modelcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        /// <summary>
        /// 确认所选模型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modelbutton_Click(object sender, EventArgs e)
        {
            //Button设为不可用
            //this.addModelbutton.Enabled = false;
            //this.delModelbutton.Enabled = false;
            if (MessageBox.Show("确定所选模型？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)//点击确认
            {
                //设置modelList（含属性值）
                foreach (string modelName in modellistBox.Items)
                {
                    Model modelItem = new Model();
                    modelItem = mc.getModelByid(modelName);
                    this.modelList.Add(modelItem);
                }
                //传递modelList到父窗口
                DisplayForm frmDisplay = (DisplayForm)this.Owner;
                frmDisplay.ModelList = this.ModelList;
            }
        }

        /// <summary>
        /// 确认所选数据集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataSetbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定所选数据集？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                //设置dataSetList
                foreach (string dataSetName in datasetlistBox.Items)
                {
                    FDataSet dataSetItem = new FDataSet();
                    //从数据库中取得dataSet,目的是设置type属性
                    dataSetItem = dc.getDataSetByid(dataSetName);
                    this.dataSetList.Add(dataSetItem);
                }
                //传递dataSetList到父窗口
                DisplayForm frmDisplay = (DisplayForm)this.Owner;
                frmDisplay.DataSetList = this.DataSetList;
            }
        }

        /// <summary>
        /// 调用DLL文件，执行所选模型的验证，打开拟合窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
            ProcessOperator process = new ProcessOperator();
            process.MessageInfo = "正在进行拟合，请稍等……";
            process.BackgroundWork = this.Do;
            process.BackgroundWorkerCompleted += new EventHandler<BackgroundWorkerEventArgs>(process_BackgroundWorkerCompleted);
            process.Start();

            //disc.choose(this.ModelList,this.DataSetList);

            //打开拟合窗口
            //DisplayForm frmDisplay = (DisplayForm)this.Owner;
            //frmDisplay.fitLabel_Click(sender, e);
        }

        void Do()
        {
            disc.choose(this.ModelList, this.DataSetList);
        }

        void process_BackgroundWorkerCompleted(object sender, BackgroundWorkerEventArgs e)
        {
            if (e.BackGroundException == null)
            {
                //MessageBox.Show("执行完毕");
                //打开拟合窗口
                DisplayForm frmDisplay = (DisplayForm)this.Owner;
                frmDisplay.fitLabel_Click(sender, e);
            }
            else
            {
                MessageBox.Show("异常:" + e.BackGroundException.Message);
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            instance = null;
            this.Close();
        }
        /// <summary>
        /// 显示模型文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.modelrichTextBox.Text = null;//防止无限+=赋值
            if (null != modeldataGridView.CurrentRow)
            {
                int row = modeldataGridView.CurrentRow.Index;
                string modelName = modeldataGridView.Rows[row].Cells[0].Value.ToString();
                Model model = mc.getModelByid(modelName);
                string[] FilePath = model.Path.Split(' ');
                foreach (string item in FilePath)
                {
                    string modelFilePath = System.Environment.CurrentDirectory + item;
                    if (FileHelper.IsExistFile(modelFilePath))
                    {
                        this.modelrichTextBox.Text += FileHelper.FileToString(modelFilePath) + "\n";
                    }
                }
            }
        }

        /// <summary>
        /// 显示数据集文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (null != dataSetdataGridView.CurrentRow)
            {
                int row = dataSetdataGridView.CurrentRow.Index;
                string dataSetName = dataSetdataGridView.Rows[row].Cells[0].Value.ToString();
                FDataSet dataSet = dc.getDataSetByid(dataSetName);
                String dataSetFilePath = System.Environment.CurrentDirectory + dataSet.Path;
                if (FileHelper.IsExistFile(dataSetFilePath))
                {
                    this.dataSetrichTextBox.Text = FileHelper.FileToString(dataSetFilePath);
                }
            }
        }

    }

}
