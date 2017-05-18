namespace SRGMFormsApplication.UI
{
    partial class FitForm
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
            this.modelcomboBox = new CCWin.SkinControl.SkinComboBox();
            this.dataSetcomboBox = new CCWin.SkinControl.SkinComboBox();
            this.label1 = new CCWin.SkinControl.SkinLabel();
            this.label2 = new CCWin.SkinControl.SkinLabel();
            this.modelLabel = new CCWin.SkinControl.SkinLabel();
            this.dataSetLabel = new CCWin.SkinControl.SkinLabel();
            this.fitPictureBox = new CCWin.SkinControl.SkinPictureBox();
            this.OKButton = new CCWin.SkinControl.SkinButton();
            this.resetButton = new CCWin.SkinControl.SkinButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new CCWin.SkinControl.SkinLabel();
            this.pictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.picturePrintButton = new CCWin.SkinControl.SkinButton();
            this.txtPrintButton = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.fitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // modelcomboBox
            // 
            this.modelcomboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.modelcomboBox.FormattingEnabled = true;
            this.modelcomboBox.Location = new System.Drawing.Point(59, 12);
            this.modelcomboBox.Name = "modelcomboBox";
            this.modelcomboBox.Size = new System.Drawing.Size(121, 22);
            this.modelcomboBox.TabIndex = 13;
            this.modelcomboBox.WaterText = "";
            // 
            // dataSetcomboBox
            // 
            this.dataSetcomboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dataSetcomboBox.FormattingEnabled = true;
            this.dataSetcomboBox.Location = new System.Drawing.Point(245, 12);
            this.dataSetcomboBox.Name = "dataSetcomboBox";
            this.dataSetcomboBox.Size = new System.Drawing.Size(121, 22);
            this.dataSetcomboBox.TabIndex = 14;
            this.dataSetcomboBox.WaterText = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "拟合参数值、标准值：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "拟合图：";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.BackColor = System.Drawing.Color.Transparent;
            this.modelLabel.BorderColor = System.Drawing.Color.White;
            this.modelLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modelLabel.Location = new System.Drawing.Point(12, 15);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(44, 17);
            this.modelLabel.TabIndex = 19;
            this.modelLabel.Text = "模型：";
            // 
            // dataSetLabel
            // 
            this.dataSetLabel.AutoSize = true;
            this.dataSetLabel.BackColor = System.Drawing.Color.Transparent;
            this.dataSetLabel.BorderColor = System.Drawing.Color.White;
            this.dataSetLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataSetLabel.Location = new System.Drawing.Point(186, 15);
            this.dataSetLabel.Name = "dataSetLabel";
            this.dataSetLabel.Size = new System.Drawing.Size(56, 17);
            this.dataSetLabel.TabIndex = 20;
            this.dataSetLabel.Text = "数据集：";
            // 
            // fitPictureBox
            // 
            this.fitPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.fitPictureBox.Location = new System.Drawing.Point(59, 52);
            this.fitPictureBox.Name = "fitPictureBox";
            this.fitPictureBox.Size = new System.Drawing.Size(480, 375);
            this.fitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fitPictureBox.TabIndex = 18;
            this.fitPictureBox.TabStop = false;
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.Transparent;
            this.OKButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.OKButton.DownBack = null;
            this.OKButton.Location = new System.Drawing.Point(455, 10);
            this.OKButton.MouseBack = null;
            this.OKButton.Name = "OKButton";
            this.OKButton.NormlBack = null;
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 21;
            this.OKButton.Text = "确定";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.resetButton.DownBack = null;
            this.resetButton.Location = new System.Drawing.Point(597, 10);
            this.resetButton.MouseBack = null;
            this.resetButton.Name = "resetButton";
            this.resetButton.NormlBack = null;
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "重置";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(143, 443);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(512, 162);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 623);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "注：点击重置后，再点击左侧功能按钮，可进行（显示）新的验证。";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(557, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // picturePrintButton
            // 
            this.picturePrintButton.BackColor = System.Drawing.Color.Transparent;
            this.picturePrintButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.picturePrintButton.DownBack = null;
            this.picturePrintButton.Location = new System.Drawing.Point(723, 443);
            this.picturePrintButton.MouseBack = null;
            this.picturePrintButton.Name = "picturePrintButton";
            this.picturePrintButton.NormlBack = null;
            this.picturePrintButton.Size = new System.Drawing.Size(75, 33);
            this.picturePrintButton.TabIndex = 33;
            this.picturePrintButton.Text = "打印图片";
            this.picturePrintButton.UseVisualStyleBackColor = true;
            this.picturePrintButton.Click += new System.EventHandler(this.picturePrintButton_Click);
            // 
            // txtPrintButton
            // 
            this.txtPrintButton.BackColor = System.Drawing.Color.Transparent;
            this.txtPrintButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.txtPrintButton.DownBack = null;
            this.txtPrintButton.Location = new System.Drawing.Point(867, 443);
            this.txtPrintButton.MouseBack = null;
            this.txtPrintButton.Name = "txtPrintButton";
            this.txtPrintButton.NormlBack = null;
            this.txtPrintButton.Size = new System.Drawing.Size(75, 33);
            this.txtPrintButton.TabIndex = 34;
            this.txtPrintButton.Text = "打印文本";
            this.txtPrintButton.UseVisualStyleBackColor = true;
            this.txtPrintButton.Click += new System.EventHandler(this.txtPrintButton_Click);
            // 
            // FitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1047, 644);
            this.Controls.Add(this.txtPrintButton);
            this.Controls.Add(this.picturePrintButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.dataSetLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.fitPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataSetcomboBox);
            this.Controls.Add(this.modelcomboBox);
            this.Name = "FitForm";
            this.Text = "FitForm";
            this.Load += new System.EventHandler(this.FitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinComboBox modelcomboBox;
        private CCWin.SkinControl.SkinComboBox dataSetcomboBox;
        private CCWin.SkinControl.SkinLabel label1;
        private CCWin.SkinControl.SkinLabel label2;
        private CCWin.SkinControl.SkinPictureBox fitPictureBox;
        private CCWin.SkinControl.SkinLabel modelLabel;
        private CCWin.SkinControl.SkinLabel dataSetLabel;
        private CCWin.SkinControl.SkinButton OKButton;
        private CCWin.SkinControl.SkinButton resetButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private CCWin.SkinControl.SkinLabel label3;
        private CCWin.SkinControl.SkinPictureBox pictureBox1;
        private CCWin.SkinControl.SkinButton picturePrintButton;
        private CCWin.SkinControl.SkinButton txtPrintButton;
    }
}