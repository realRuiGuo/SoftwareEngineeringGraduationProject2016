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
    public partial class MainForm : Form
    {
        Account account;
        int userType;
        string loginTime;

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

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //菜单栏配置
            //设置timer1的Interval属性为1000，即计时器开始计时之间的间隔为1000ms
            this.timer1.Interval = 1000;
            this.timer1.Start();//启动计时器
            if (0 == userType)
            {
                msAdmin.Visible = true;
                msUser.Visible = false;
            }
            else
            {
                msAdmin.Visible = false;
                msUser.Visible = true;
                if (1 == userType)//se
                {
                    模型管理ToolStripMenuItem.Enabled = false;
                }
                else if (3 == userType)//初学者
                {
                    模型管理ToolStripMenuItem.Enabled = false;
                    数据集管理ToolStripMenuItem.Enabled = false;
                }
            }
            //状态栏设置
            if (3 != userType)
            {
                toolStripStatusLabel2.Text = account.UserName;
            }
            switch (UserType)
            {
                case 0:
                    {
                        toolStripStatusLabel4.Text = "系统管理员"; break;
                    }
                case 1:
                    {
                        toolStripStatusLabel4.Text = "软件工程师"; break;
                    }
                case 2:
                    {
                        toolStripStatusLabel4.Text = "SRGM研究人员"; break;
                    }
                case 3:
                    {
                        toolStripStatusLabel4.Text = "初学者"; break;
                    }
            }
            toolStripStatusLabel6.Text = this.LoginTime;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;//获取系统当前时间
            /*
             * 如果直接用time的hour，minute，second属性来表示时间，就会有当hour（或minute，second）为
             * 个位数时，如2时11分6秒，就会显示2:11：6，显示出来格式有些不符常规；所以，为了让其显示02:11:06
             * 的格式，需要修改代码；
             * 如下，让hour用两个数h1h2来表示；当hour为个位数时，h2=hour，h1=0，显示正常；
             * 如果hour为两位数时，h1=hour/10,h2=hour%10,同样显示正常；
             * 同理，minute，second也同样显示
             * 代码如下：
             * */
            int hour = time.Hour;//获取当前的hour值
            int h1 = 0;
            int h2 = hour; ;
            if (hour >= 10)
            {
                h1 = hour / 10;
                h2 = hour % 10;
            }
            int minute = time.Minute;
            int m1 = 0;
            int m2 = minute;
            if (minute >= 10)
            {
                m1 = minute / 10;
                m2 = minute % 10;
            }
            int second = time.Second;
            int s1 = 0;
            int s2 = second;
            if (second >= 10)
            {
                s1 = second / 10;
                s2 = second % 10;
            }
            //控件显示时间
            toolStripMenuItem1.Text = string.Format("{0}{1}:{2}{3}:{4}{5}", h1, h2, m1, m2, s1, s2);
            toolStripMenuItem2.Text = string.Format("{0}{1}:{2}{3}:{4}{5}", h1, h2, m1, m2, s1, s2);
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出本系统吗？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void 退出系统ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出本系统吗？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void 模型评测演示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm displayForm = DisplayForm.Instance;
            displayForm.Account = this.Account;
            displayForm.UserType = this.UserType;
            displayForm.Show();
            displayForm.Activate();
        }

        private void 模型管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 数据集管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSetForm dataSetForm = DataSetForm.Instance;
            dataSetForm.Account = this.Account;
            dataSetForm.UserType = this.UserType;
            dataSetForm.Show();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm userForm = UserForm.Instance;
            userForm.Show();
        }

        private void 系统模型管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelForm modelForm = ModelForm.Instance;
            modelForm.Account = this.Account;
            modelForm.UserType = this.UserType;
            modelForm.Show();
        }

        private void 系统数据集管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSetForm dataSetForm = DataSetForm.Instance;
            dataSetForm.Account = this.Account;
            dataSetForm.UserType = this.UserType;
            dataSetForm.Show();
        }
    }
}
