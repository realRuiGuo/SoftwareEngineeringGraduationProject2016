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
    public partial class UserForm : Form
    {
        private static UserForm instance = null;
        public AccountController ac = new AccountController();
        public static UserForm Instance//单例
        {
            set { }
            get
            {
                if (instance == null)
                {
                    new UserForm();
                }
                return instance;
            }
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        public UserForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.seDataGridView.DataSource = ac.getSoftwareEngineer().Tables[0];
            this.srDataGridView.DataSource = ac.getSRGMResearcher().Tables[0];
        }

        private void seDelButton_Click(object sender, EventArgs e)
        {
            SoftwareEngineer se = new SoftwareEngineer();
            if (null != seDataGridView.CurrentRow)
            {
                int row = seDataGridView.CurrentRow.Index;
                se.UserName = seDataGridView.Rows[row].Cells[0].Value.ToString();
                ac.deleteSE(se);
                this.seDataGridView.DataSource = ac.getSoftwareEngineer().Tables[0];
            }
        }

        private void srDelButton_Click(object sender, EventArgs e)
        {
            SRGMResearch sr = new SRGMResearch();
            if (null != srDataGridView.CurrentRow)
            {
                int row = srDataGridView.CurrentRow.Index;
                sr.UserName = srDataGridView.Rows[row].Cells[0].Value.ToString();
                ac.deleteSR(sr);
                this.srDataGridView.DataSource = ac.getSRGMResearcher().Tables[0];
            }
        }
    }
}
