using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRGMFormsApplication.Entity;
using SRGMFormsApplication.DAL;
using CCWin;

namespace SRGMFormsApplication.UI
{
    public partial class ReForm : Form
    {
        private static ReForm instance = null;
        List<Model> modelList = new List<Model>();
        List<FDataSet> dataSetList = new List<FDataSet>();
        private string m_filePath;

        public string FilePath
        {
            get { return m_filePath; }
            set { m_filePath = value; }
        }
        private string m_imagePath;

        public string ImagePath
        {
            get { return m_imagePath; }
            set { m_imagePath = value; }
        }
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
                    string imagePath_mt = System.Environment.CurrentDirectory + "\\Picture\\" + dataSetName + "_" + mt + "_RE.png";
                    this.m_imagePath = imagePath_mt;
                    if (FileHelper.IsExistFile(imagePath_mt))
                    {
                        this.rePictureBox.Image = Image.FromFile(imagePath_mt, false);
                    }
                
                    //显示文本
                    string filePath = System.Environment.CurrentDirectory +
                        "\\Result\\" + dataSetName + "_" + mt + "_RERes.txt";
                    this.m_filePath = filePath;
                    if (FileHelper.IsExistFile(filePath))
                    {
                        this.richTextBox1.Text = FileHelper.FileToString(filePath);
                    }
                }
                else
                {
                    //显示图片
                    string imagePath = System.Environment.CurrentDirectory + "\\Picture\\" + dataSetName + "_" + modelName + "_RE.png";
                    this.m_imagePath = imagePath;
                    if (FileHelper.IsExistFile(imagePath))
                    {
                        this.rePictureBox.Image = Image.FromFile(imagePath, false);
                    }
                    
                    //显示文本
                    string filePath = System.Environment.CurrentDirectory +
                        "\\Result\\" + dataSetName + "_" + modelName + "_RERes.txt";
                    this.m_filePath = filePath;
                    if (FileHelper.IsExistFile(filePath))
                    {
                        this.richTextBox1.Text = FileHelper.FileToString(filePath);
                    }            
                }             
            }
        }

        /// <summary>
        /// 删除当前实例
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            instance = null;
            this.Close();
        }

        private void picturePrintButton_Click(object sender, EventArgs e)
        {
            if(this.rePictureBox != null)
            {
                Print picture = new Print(this.m_imagePath,"image");
            }
        }

        private void txtPrintButton_Click(object sender, EventArgs e)
        {
            if(this.richTextBox1.Text != string.Empty)
            {
                Print txt = new Print(this.m_filePath,"txt");
            }
        }


    }
}
