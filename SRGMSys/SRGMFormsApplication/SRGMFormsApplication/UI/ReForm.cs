using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRGMFormsApplication.Entity;
using SRGMFormsApplication.BLL;

namespace SRGMFormsApplication.UI
{
    public partial class ReForm : Form
    {
        private static ReForm instance = null;
        List<Model> modelList = new List<Model>();
        List<FDataSet> dataSetList = new List<FDataSet>();
        public static ReForm Instance//单例
        {
            set { }
            get
            {
                if (instance == null)
                {
                    new ReForm();
                }
                return instance;
            }
        }
        private void ReForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
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
        public ReForm()
        {
            InitializeComponent();
            instance = this;
        }
        private void ReForm_Load(object sender, EventArgs e)
        {
            //初始化comboBox
            foreach (Model model in this.ModelList)
            {
                this.modelcomboBox.Items.Add(model.Name);
            }
            foreach (FDataSet dataSet in this.DataSetList)
            {
                this.dataSetcomboBox.Items.Add(dataSet.Name);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string modelName = this.modelcomboBox.SelectedItem.ToString();
            string dataSetName = this.dataSetcomboBox.SelectedItem.ToString();
            if ("" != modelName && "" != dataSetName && null != modelName && null != dataSetName)
            {
                if (modelName.IndexOf(";") > -1)
                {
                    string[] name = modelName.Split(';');
                    string wt = null;
                    string mt = null;
                    foreach (string item in name)
                    {
                        if (item.IndexOf("wt") > -1)
                        {
                            wt = item;
                        }
                        if (item.IndexOf("mt") > -1)
                        {
                            mt = item;
                        }
                    }
                    //显示图片
                    string imagePath_mt = "\\Picture\\" + dataSetName + "_" + mt + "_RE.png";
                    if (FileHelper.IsExistFile(imagePath_mt))
                    {
                        this.rePictureBox.Image = Image.FromFile(System.Environment.CurrentDirectory + imagePath_mt, false);
                    }
                
                    //显示文本
                    string filePath = System.Environment.CurrentDirectory +
                        "\\Result\\" + dataSetName + "_" + mt + "_RERes.txt";
                    if (FileHelper.IsExistFile(filePath))
                    {
                        this.richTextBox1.Text = FileHelper.FileToString(filePath);
                    }
                }
                else
                {
                    //显示图片
                    string imagePath = "\\Picture\\" + dataSetName + "_" + modelName + "_RE.png";
                    this.rePictureBox.Image = Image.FromFile(System.Environment.CurrentDirectory + imagePath, false);
                    //显示文本
                    string filePath = System.Environment.CurrentDirectory +
                        "\\Result\\" + dataSetName + "_" + modelName + "_RERes.txt";
                    if (FileHelper.IsExistFile(filePath))
                    {
                        this.richTextBox1.Text = FileHelper.FileToString(filePath);
                    }            
                }             
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            instance = null;
        }


    }
}
