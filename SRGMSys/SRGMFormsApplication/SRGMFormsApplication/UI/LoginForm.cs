using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using SRGMFormsApplication.BLL;
using SRGMFormsApplication.Entity;
using CCWin;

namespace SRGMFormsApplication.UI
{
    public partial class LoginForm : CCSkinMain
    {
        Account account;
        int userType = 3;//初学者
        string loginTime;
        static AccountController ac = new AccountController();

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
        public string LoginTime
        {
            get { return loginTime; }
            set { loginTime = value; }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 初学者
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                userType = 3;
            }
        }
        /// <summary>
        /// 软件工程师
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                userType = 1;
            }
        }
        /// <summary>
        /// SRGM研究人员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                userType = 2;
            }
        }
        /// <summary>
        /// 系统管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton0_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                userType = 0;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.nameTextBox.Text = "";
            this.passwordTextBox.Text = "";
            ClearCntrValue(this.usergroupBox);
        }

        /// <summary>
        ///  清除groupBox里面某些控件的值 
        /// </summary>
        /// <param name="p_groupBox"></param>
        public void ClearCntrValue(CCWin.SkinControl.SkinGroupBox p_groupBox)
        {
            for (int index = 0; index < p_groupBox.Controls.Count; index++)
            {
                switch (p_groupBox.Controls[index].GetType().Name)
                    {
                        //case "TextBox": p_groupBox.Controls[index].Text = ""; break;
                        case "SkinRadioButton": ((CCWin.SkinControl.SkinRadioButton)(p_groupBox.Controls[index])).Checked = false; break;
                        //case "CheckBox": ((CheckBox)(p_groupBox.Controls[index])).Checked = false; break;
                        //case "ComboBox": ((ComboBox)(p_groupBox.Controls[index])).Text = ""; break;
                    }
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginTime = DateTime.Now.ToString();
            if (3 == userType)//初学者无需用户名、密码
            {
                MainForm main = new MainForm();
                main.LoginTime = this.LoginTime;
                main.Account = null;
                main.UserType = this.UserType;
                main.Show();
                this.Visible = false;
            }
            else
            {
                account = new Account();
                account.UserName = nameTextBox.Text.Trim();
                account.Password = passwordTextBox.Text.Trim();
                Account user = ac.login(account, userType);
                if (user == null)
                {
                    MessageBox.Show("用户名不存在！！", "提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //cancelButton_Click(sender,e);
                }
                else
                {
                    if (null == user.Password)
                    {
                        MessageBox.Show("密码错误！！", "提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //cancelButton_Click(sender, e);
                    }
                    else
                    {
                        MainForm main = new MainForm();
                        main.LoginTime = this.LoginTime;
                        main.Account = this.Account;
                        main.UserType = this.UserType;
                        main.Show();
                        this.Visible = false;
                    }
                }
            }
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            if (3 == userType)//初学者无需注册
            {
            }
            else
            {
                account = new Account();
                account.UserName = nameTextBox.Text.Trim();
                account.Password = passwordTextBox.Text.Trim();
                string result = ac.signin(account, userType);
                MessageBox.Show(result, "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
