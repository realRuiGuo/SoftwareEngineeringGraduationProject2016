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
    public partial class ReForm : Form
    {
        private static ReForm instance = null;
        List<Model> modelList;
        List<FDataSet> dataSetList;
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
    }
}
