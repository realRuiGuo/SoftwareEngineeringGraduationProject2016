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
using SRGMFormsApplication.BLL;

namespace SRGMFormsApplication.UI
{
    public partial class CompareForm : Form
    {
        private static CompareForm instance = null;
        List<Model> modelList = new List<Model>();
        List<FDataSet> dataSetList = new List<FDataSet>();
        static DataSetController dc = new DataSetController();
        static DisplayController disc = new DisplayController();
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
        public static CompareForm Instance//单例
        {
            set { }
            get
            {
                if (instance == null)
                {
                    new CompareForm();
                }
                return instance;
            }
        }

        public CompareForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void CompareForm_Load(object sender, EventArgs e)
        {
            //初始化comboBox
            foreach (FDataSet dataSet in this.DataSetList)
            {
                this.dataSetcomboBox.Items.Add(dataSet.Name);
            }
        }
        //混合绘图并显示图片
        private void OKButton_Click(object sender, EventArgs e)
        {
            string dataSetName = this.dataSetcomboBox.SelectedItem.ToString();
            FDataSet selectedDataSet = dc.getDataSetByid(dataSetName);
            //混合绘图（调用Matlab）
            List<string> fullmodelName = disc.mixDraw(this.ModelList,selectedDataSet);
            //显示混合拟合图           
            if ( "" != dataSetName && null != dataSetName)
            {
                if(selectedDataSet.Type.TypeID == 1)
                {
                    string picturePath = System.Environment.CurrentDirectory +
                        "\\Picture\\T1" + fullmodelName[0] + dataSetName + "_Mt.png";
                    if(FileHelper.IsExistFile(picturePath))
                    {
                        this.comPictureBox.Image = Image.FromFile(picturePath, false);
                    }
                }
                if (selectedDataSet.Type.TypeID == 2 || selectedDataSet.Type.TypeID == 3)
                {
                    string picturewtPath = System.Environment.CurrentDirectory +
                        "\\Picture\\T2" + fullmodelName[0] + dataSetName + "_Wt.png";
                    if (FileHelper.IsExistFile(picturewtPath))
                    {
                        this.comPictureBox.Image = Image.FromFile(picturewtPath, false);
                    }

                    string picturemtPath = System.Environment.CurrentDirectory +
                        "\\Picture\\T2" + fullmodelName[1] + dataSetName + "_Mt.png";
                    if (FileHelper.IsExistFile(picturemtPath))
                    {
                        this.pictureBox1.Image = Image.FromFile(picturemtPath, false);
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
