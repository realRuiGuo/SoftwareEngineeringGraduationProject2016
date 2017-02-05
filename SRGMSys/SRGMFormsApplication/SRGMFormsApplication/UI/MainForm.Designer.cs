namespace SRGMFormsApplication.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msUser = new System.Windows.Forms.MenuStrip();
            this.模型评测演示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模型管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据集管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统模型管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统数据集管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msUser.SuspendLayout();
            this.msAdmin.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msUser
            // 
            this.msUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.模型评测演示ToolStripMenuItem,
            this.模型管理ToolStripMenuItem,
            this.数据集管理ToolStripMenuItem,
            this.退出系统ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.msUser.Location = new System.Drawing.Point(0, 0);
            this.msUser.Name = "msUser";
            this.msUser.Size = new System.Drawing.Size(584, 25);
            this.msUser.TabIndex = 1;
            this.msUser.Text = "msUser";
            // 
            // 模型评测演示ToolStripMenuItem
            // 
            this.模型评测演示ToolStripMenuItem.Name = "模型评测演示ToolStripMenuItem";
            this.模型评测演示ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.模型评测演示ToolStripMenuItem.Text = "模型评测演示";
            this.模型评测演示ToolStripMenuItem.Click += new System.EventHandler(this.模型评测演示ToolStripMenuItem_Click);
            // 
            // 模型管理ToolStripMenuItem
            // 
            this.模型管理ToolStripMenuItem.Name = "模型管理ToolStripMenuItem";
            this.模型管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.模型管理ToolStripMenuItem.Text = "模型管理";
            this.模型管理ToolStripMenuItem.Click += new System.EventHandler(this.模型管理ToolStripMenuItem_Click);
            // 
            // 数据集管理ToolStripMenuItem
            // 
            this.数据集管理ToolStripMenuItem.Name = "数据集管理ToolStripMenuItem";
            this.数据集管理ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.数据集管理ToolStripMenuItem.Text = "数据集管理";
            this.数据集管理ToolStripMenuItem.Click += new System.EventHandler(this.数据集管理ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 21);
            // 
            // msAdmin
            // 
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.系统模型管理ToolStripMenuItem,
            this.系统数据集管理ToolStripMenuItem,
            this.退出系统ToolStripMenuItem1,
            this.toolStripMenuItem2});
            this.msAdmin.Location = new System.Drawing.Point(0, 25);
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(584, 25);
            this.msAdmin.TabIndex = 0;
            this.msAdmin.Text = "msAdmin";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 系统模型管理ToolStripMenuItem
            // 
            this.系统模型管理ToolStripMenuItem.Name = "系统模型管理ToolStripMenuItem";
            this.系统模型管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.系统模型管理ToolStripMenuItem.Text = "系统模型管理";
            this.系统模型管理ToolStripMenuItem.Click += new System.EventHandler(this.系统模型管理ToolStripMenuItem_Click);
            // 
            // 系统数据集管理ToolStripMenuItem
            // 
            this.系统数据集管理ToolStripMenuItem.Name = "系统数据集管理ToolStripMenuItem";
            this.系统数据集管理ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.系统数据集管理ToolStripMenuItem.Text = "系统数据集管理";
            this.系统数据集管理ToolStripMenuItem.Click += new System.EventHandler(this.系统数据集管理ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem1
            // 
            this.退出系统ToolStripMenuItem1.Name = "退出系统ToolStripMenuItem1";
            this.退出系统ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.退出系统ToolStripMenuItem1.Text = "退出系统";
            this.退出系统ToolStripMenuItem1.Click += new System.EventHandler(this.退出系统ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 21);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "当前用户：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel3.Text = "类型：";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel5.Text = "登录时间：";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SRGMFormsApplication.Properties.Resources.bj;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msAdmin);
            this.Controls.Add(this.msUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msAdmin;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRGM评测系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msUser.ResumeLayout(false);
            this.msUser.PerformLayout();
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msUser;
        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem 模型评测演示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模型管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据集管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统模型管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统数据集管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Timer timer1;
    }
}