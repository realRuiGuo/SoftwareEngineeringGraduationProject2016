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
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.msUser = new System.Windows.Forms.MenuStrip();
            this.选择模型数据集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入模型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入数据集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAdmin
            // 
            this.msAdmin.Location = new System.Drawing.Point(0, 25);
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(629, 24);
            this.msAdmin.TabIndex = 0;
            this.msAdmin.Text = "msAdmin";
            // 
            // msUser
            // 
            this.msUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择模型数据集ToolStripMenuItem,
            this.导入模型ToolStripMenuItem,
            this.导入数据集ToolStripMenuItem});
            this.msUser.Location = new System.Drawing.Point(0, 0);
            this.msUser.Name = "msUser";
            this.msUser.Size = new System.Drawing.Size(629, 25);
            this.msUser.TabIndex = 1;
            this.msUser.Text = "msUser";
            // 
            // 选择模型数据集ToolStripMenuItem
            // 
            this.选择模型数据集ToolStripMenuItem.Name = "选择模型数据集ToolStripMenuItem";
            this.选择模型数据集ToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.选择模型数据集ToolStripMenuItem.Text = "模型验证演示";
            // 
            // 导入模型ToolStripMenuItem
            // 
            this.导入模型ToolStripMenuItem.Name = "导入模型ToolStripMenuItem";
            this.导入模型ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.导入模型ToolStripMenuItem.Text = "模型管理";
            // 
            // 导入数据集ToolStripMenuItem
            // 
            this.导入数据集ToolStripMenuItem.Name = "导入数据集ToolStripMenuItem";
            this.导入数据集ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.导入数据集ToolStripMenuItem.Text = "数据集管理";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SRGMFormsApplication.Properties.Resources.bj;
            this.ClientSize = new System.Drawing.Size(629, 334);
            this.Controls.Add(this.msAdmin);
            this.Controls.Add(this.msUser);
            this.MainMenuStrip = this.msAdmin;
            this.Name = "MainForm";
            this.Text = "SRGM评测系统";
            this.msUser.ResumeLayout(false);
            this.msUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.MenuStrip msUser;
        private System.Windows.Forms.ToolStripMenuItem 选择模型数据集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入模型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入数据集ToolStripMenuItem;
    }
}