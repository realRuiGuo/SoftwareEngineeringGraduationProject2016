namespace SRGMFormsApplication.UI
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.signinButton = new CCWin.SkinControl.SkinButton();
            this.usergroupBox = new CCWin.SkinControl.SkinGroupBox();
            this.radioButton = new CCWin.SkinControl.SkinRadioButton();
            this.radioButton1 = new CCWin.SkinControl.SkinRadioButton();
            this.radioButton2 = new CCWin.SkinControl.SkinRadioButton();
            this.radioButton0 = new CCWin.SkinControl.SkinRadioButton();
            this.nameLabel = new CCWin.SkinControl.SkinLabel();
            this.passworkLabel = new CCWin.SkinControl.SkinLabel();
            this.nameTextBox = new CCWin.SkinControl.SkinTextBox();
            this.passwordTextBox = new CCWin.SkinControl.SkinTextBox();
            this.loginButton = new CCWin.SkinControl.SkinButton();
            this.cancelButton = new CCWin.SkinControl.SkinButton();
            this.usergroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // signinButton
            // 
            this.signinButton.BackColor = System.Drawing.Color.Transparent;
            this.signinButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.signinButton.DownBack = null;
            this.signinButton.Location = new System.Drawing.Point(42, 182);
            this.signinButton.MouseBack = null;
            this.signinButton.Name = "signinButton";
            this.signinButton.NormlBack = null;
            this.signinButton.Size = new System.Drawing.Size(71, 30);
            this.signinButton.TabIndex = 13;
            this.signinButton.Text = "注册";
            this.signinButton.UseVisualStyleBackColor = false;
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // usergroupBox
            // 
            this.usergroupBox.BackColor = System.Drawing.Color.Transparent;
            this.usergroupBox.BorderColor = System.Drawing.Color.Transparent;
            this.usergroupBox.Controls.Add(this.radioButton0);
            this.usergroupBox.Controls.Add(this.radioButton2);
            this.usergroupBox.Controls.Add(this.radioButton1);
            this.usergroupBox.Controls.Add(this.radioButton);
            this.usergroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.usergroupBox.Location = new System.Drawing.Point(269, 31);
            this.usergroupBox.Name = "usergroupBox";
            this.usergroupBox.RectBackColor = System.Drawing.Color.Transparent;
            this.usergroupBox.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.usergroupBox.Size = new System.Drawing.Size(138, 102);
            this.usergroupBox.TabIndex = 14;
            this.usergroupBox.TabStop = false;
            this.usergroupBox.Text = "用户类别：";
            this.usergroupBox.TitleBorderColor = System.Drawing.Color.Transparent;
            this.usergroupBox.TitleRectBackColor = System.Drawing.Color.Transparent;
            this.usergroupBox.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.BackColor = System.Drawing.Color.Transparent;
            this.radioButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.radioButton.DownBack = null;
            this.radioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton.Location = new System.Drawing.Point(6, 20);
            this.radioButton.MouseBack = null;
            this.radioButton.Name = "radioButton";
            this.radioButton.NormlBack = null;
            this.radioButton.SelectedDownBack = null;
            this.radioButton.SelectedMouseBack = null;
            this.radioButton.SelectedNormlBack = null;
            this.radioButton.Size = new System.Drawing.Size(62, 21);
            this.radioButton.TabIndex = 0;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "初学者";
            this.radioButton.UseVisualStyleBackColor = false;
            this.radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.radioButton1.DownBack = null;
            this.radioButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.Location = new System.Drawing.Point(6, 40);
            this.radioButton1.MouseBack = null;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.NormlBack = null;
            this.radioButton1.SelectedDownBack = null;
            this.radioButton1.SelectedMouseBack = null;
            this.radioButton1.SelectedNormlBack = null;
            this.radioButton1.Size = new System.Drawing.Size(86, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "软件工程师";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.radioButton2.DownBack = null;
            this.radioButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton2.Location = new System.Drawing.Point(6, 61);
            this.radioButton2.MouseBack = null;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.NormlBack = null;
            this.radioButton2.SelectedDownBack = null;
            this.radioButton2.SelectedMouseBack = null;
            this.radioButton2.SelectedNormlBack = null;
            this.radioButton2.Size = new System.Drawing.Size(110, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SRGM研究人员";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.BackColor = System.Drawing.Color.Transparent;
            this.radioButton0.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.radioButton0.DownBack = null;
            this.radioButton0.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton0.Location = new System.Drawing.Point(6, 81);
            this.radioButton0.MouseBack = null;
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.NormlBack = null;
            this.radioButton0.SelectedDownBack = null;
            this.radioButton0.SelectedMouseBack = null;
            this.radioButton0.SelectedNormlBack = null;
            this.radioButton0.Size = new System.Drawing.Size(86, 21);
            this.radioButton0.TabIndex = 3;
            this.radioButton0.TabStop = true;
            this.radioButton0.Text = "系统管理员";
            this.radioButton0.UseVisualStyleBackColor = false;
            this.radioButton0.CheckedChanged += new System.EventHandler(this.radioButton0_CheckedChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.BorderColor = System.Drawing.Color.White;
            this.nameLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.Location = new System.Drawing.Point(39, 53);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 17);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "用户名：";
            // 
            // passworkLabel
            // 
            this.passworkLabel.AutoSize = true;
            this.passworkLabel.BackColor = System.Drawing.Color.Transparent;
            this.passworkLabel.BorderColor = System.Drawing.Color.White;
            this.passworkLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passworkLabel.Location = new System.Drawing.Point(39, 114);
            this.passworkLabel.Name = "passworkLabel";
            this.passworkLabel.Size = new System.Drawing.Size(44, 17);
            this.passworkLabel.TabIndex = 16;
            this.passworkLabel.Text = "密码：";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.nameTextBox.DownBack = null;
            this.nameTextBox.Icon = null;
            this.nameTextBox.IconIsButton = false;
            this.nameTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.nameTextBox.IsPasswordChat = '\0';
            this.nameTextBox.IsSystemPasswordChar = false;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(98, 44);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.nameTextBox.MouseBack = null;
            this.nameTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.NormlBack = null;
            this.nameTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.nameTextBox.ReadOnly = false;
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.Size = new System.Drawing.Size(116, 28);
            // 
            // 
            // 
            this.nameTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.nameTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.nameTextBox.SkinTxt.Name = "BaseText";
            this.nameTextBox.SkinTxt.Size = new System.Drawing.Size(106, 18);
            this.nameTextBox.SkinTxt.TabIndex = 0;
            this.nameTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.nameTextBox.SkinTxt.WaterText = "";
            this.nameTextBox.TabIndex = 17;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.nameTextBox.WaterText = "";
            this.nameTextBox.WordWrap = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.DownBack = null;
            this.passwordTextBox.Icon = null;
            this.passwordTextBox.IconIsButton = false;
            this.passwordTextBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.passwordTextBox.IsPasswordChat = '\0';
            this.passwordTextBox.IsSystemPasswordChar = false;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(98, 105);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.passwordTextBox.MouseBack = null;
            this.passwordTextBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.NormlBack = null;
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.Size = new System.Drawing.Size(116, 28);
            // 
            // 
            // 
            this.passwordTextBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTextBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.passwordTextBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.passwordTextBox.SkinTxt.Name = "BaseText";
            this.passwordTextBox.SkinTxt.Size = new System.Drawing.Size(106, 18);
            this.passwordTextBox.SkinTxt.TabIndex = 0;
            this.passwordTextBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwordTextBox.SkinTxt.WaterText = "";
            this.passwordTextBox.TabIndex = 18;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.passwordTextBox.WaterText = "";
            this.passwordTextBox.WordWrap = true;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.loginButton.DownBack = null;
            this.loginButton.Location = new System.Drawing.Point(183, 182);
            this.loginButton.MouseBack = null;
            this.loginButton.Name = "loginButton";
            this.loginButton.NormlBack = null;
            this.loginButton.Size = new System.Drawing.Size(71, 30);
            this.loginButton.TabIndex = 19;
            this.loginButton.Text = "登录";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cancelButton.DownBack = null;
            this.cancelButton.Location = new System.Drawing.Point(320, 182);
            this.cancelButton.MouseBack = null;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.NormlBack = null;
            this.cancelButton.Size = new System.Drawing.Size(71, 30);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "清空";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SRGMFormsApplication.Properties.Resources.bj;
            this.ClientSize = new System.Drawing.Size(461, 248);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.passworkLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.usergroupBox);
            this.Controls.Add(this.signinButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRGM评测系统登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.usergroupBox.ResumeLayout(false);
            this.usergroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton signinButton;
        private CCWin.SkinControl.SkinGroupBox usergroupBox;
        private CCWin.SkinControl.SkinRadioButton radioButton0;
        private CCWin.SkinControl.SkinRadioButton radioButton2;
        private CCWin.SkinControl.SkinRadioButton radioButton1;
        private CCWin.SkinControl.SkinRadioButton radioButton;
        private CCWin.SkinControl.SkinLabel nameLabel;
        private CCWin.SkinControl.SkinLabel passworkLabel;
        private CCWin.SkinControl.SkinTextBox nameTextBox;
        private CCWin.SkinControl.SkinTextBox passwordTextBox;
        private CCWin.SkinControl.SkinButton loginButton;
        private CCWin.SkinControl.SkinButton cancelButton;


    }
}

