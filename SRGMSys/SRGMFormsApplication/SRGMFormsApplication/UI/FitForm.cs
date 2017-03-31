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

namespace SRGMFormsApplication.UI
{
    public partial class FitForm : Form
    {
        private static FitForm instance = null;
        List<Model> modelList = new List<Model>();
        List<FDataSet> dataSetList = new List<FDataSet>();
        private string m_filePath;//文本路径

        public string FilePath
        {
            get { return m_filePath; }
            set { m_filePath = value; }
        }
        private string m_imagePath;//单文件模型图像路径

        public string ImagePath
        {
            get { return m_imagePath; }
            set { m_imagePath = value; }
        }
        private string m_imagePath_mt;//mt图像路径

        public string ImagePath_mt
        {
            get { return m_imagePath_mt; }
            set { m_imagePath_mt = value; }
        }
        private string m_imagePath_wt;//wt图像路径

        public string ImagePath_wt
        {
            get { return m_imagePath_wt; }
            set { m_imagePath_wt = value; }
        }

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
            if (this.modelcomboBox.SelectedItem != null)
            {
                string modelName = this.modelcomboBox.SelectedItem.ToString();
                if (this.dataSetcomboBox.SelectedItem != null)
                {
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
                            string imagePath_mt = System.Environment.CurrentDirectory + "\\Picture\\" + dataSetName + "_" + mt + "_Mt.png";
                            this.m_imagePath_mt = imagePath_mt;
                            if (FileHelper.IsExistFile(imagePath_mt))
                            {
                                this.fitPictureBox.Image = Image.FromFile(imagePath_mt, false);
                            }

                            string imagePath_wt = System.Environment.CurrentDirectory + "\\Picture\\" + dataSetName + "_" + wt + "_Wt.png";
                            this.m_imagePath_wt = imagePath_wt;
                            this.pictureBox1.Visible = true;
                            if (FileHelper.IsExistFile(imagePath_wt))
                            {
                                this.pictureBox1.Image = Image.FromFile(imagePath_wt, false);
                            }

                            //显示文本
                            string filePath = System.Environment.CurrentDirectory +
                                "\\Result\\" + dataSetName + "_" + mt + "_FitRes.txt";
                            this.m_filePath = filePath;
                            if (FileHelper.IsExistFile(filePath))
                            {
                                this.richTextBox1.Text = FileHelper.FileToString(filePath);
                            }
                        }
                        else
                        {
                            //显示图片
                            string imagePath = System.Environment.CurrentDirectory + "\\Picture\\" + dataSetName + "_" + modelName + "_Mt.png";
                            this.m_imagePath = imagePath;
                            if (FileHelper.IsExistFile(imagePath))
                            {
                                this.fitPictureBox.Image = Image.FromFile(imagePath, false);
                            }

                            //显示文本
                            string filePath = System.Environment.CurrentDirectory +
                                "\\Result\\" + dataSetName + "_" + modelName + "_FitRes.txt";
                            this.m_filePath = filePath;
                            if (FileHelper.IsExistFile(filePath))
                            {
                                this.richTextBox1.Text = FileHelper.FileToString(filePath);
                            }
                        }
                    }
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            instance = null;
            this.Close();
        }

        private void picturePrintButton_Click(object sender, EventArgs e)
        {
            if (this.fitPictureBox.Image != null)
            {
                if (this.pictureBox1.Image == null)
                {
                    Print picture = new Print(this.m_imagePath, "image");
                }
                else
                {
                    Print picture_mt = new Print(this.m_imagePath_mt, "image");
                    Print picture_wt = new Print(this.m_imagePath_wt, "image");
                }
            }
            //Print picture = new Print("D:\\JR\\Desktop\\hs\\Hearthstone Screenshot 03-30-17 21.21.39.png", "image");
        }

        private void txtPrintButton_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text != string.Empty)
            {
                Print txt = new Print(this.m_filePath, "txt");
            }
        }

    }

}
