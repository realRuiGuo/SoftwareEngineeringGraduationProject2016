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
    public partial class FitForm : Form
    {
        private static FitForm instance = null;
        List<Model> modelList;
        List<FDataSet> dataSetList;
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

        private void buttonOK_Click(object sender, EventArgs e)
        {

            //显示图片
            string imagePath = "\\Picture\\T1_DS10_fmodel0_Mt.png";
            this.fitPictureBox.Image = Image.FromFile(System.Environment.CurrentDirectory + imagePath, false);  
        }

        

    }
}
