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
    public partial class FitForm : Form
    {
        private static FitForm instance = null;
        List<Model> modelList = new List<Model>();
        List<FDataSet> dataSetList = new List<FDataSet>();
        public static FitForm Instance//单例
        {
            set { }
            get
            {
                if (instance == null)
                {
                    new FitForm();
                }
                return instance;
            }
        }
        private void FitForm_FormClosed(object sender, FormClosedEventArgs e)
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
        public FitForm()
        {
            InitializeComponent();
            instance = this;
        }
        private void FitForm_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = false;
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

        /// <summary>
        /// 根据所选模型、数据集的组合，显示相应的结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            string modelName = this.modelcomboBox.SelectedItem.ToString();
            string dataSetName = this.dataSetcomboBox.SelectedItem.ToString();
            if ("" != modelName && "" != dataSetName && null != modelName && null != dataSetName)
            {
                if(modelName.IndexOf(";") > -1)
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
                    string imagePath_mt = "\\Picture\\" + dataSetName + "_" + mt + "_Mt.png";
                    this.fitPictureBox.Image = Image.FromFile(System.Environment.CurrentDirectory + imagePath_mt, false);

                    string imagePath_wt = "\\Picture\\" + dataSetName + "_" + wt + "_Wt.png";
                    this.pictureBox1.Visible = true;
                    this.pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + imagePath_wt, false);
                    //显示文本
                    string filePath = System.Environment.CurrentDirectory +
                        "\\Result\\" + dataSetName + "_" + mt + "_FitRes.txt";
                    if (FileHelper.IsExistFile(filePath))
                    {
                        this.richTextBox1.Text = FileHelper.FileToString(filePath);
                    }  
                }
                else
                {
                    //显示图片
                    string imagePath = "\\Picture\\" + dataSetName + "_" + modelName + "_Mt.png";
                    this.fitPictureBox.Image = Image.FromFile(System.Environment.CurrentDirectory + imagePath, false);
                    //显示文本
                    string filePath = System.Environment.CurrentDirectory +
                        "\\Result\\" + dataSetName + "_" + modelName + "_FitRes.txt";
                    if (FileHelper.IsExistFile(filePath))
                    {
                        this.richTextBox1.Text = FileHelper.FileToString(filePath);
                    }  
                }          
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            instance = null;
        }





    }
}
