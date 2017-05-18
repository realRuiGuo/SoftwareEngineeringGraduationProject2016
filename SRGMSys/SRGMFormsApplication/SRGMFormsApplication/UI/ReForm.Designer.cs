namespace SRGMFormsApplication.UI
{
    partial class ReForm
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
            this.dataSetLabel = new CCWin.SkinControl.SkinLabel();
            this.modelLabel = new CCWin.SkinControl.SkinLabel();
            this.dataSetcomboBox = new CCWin.SkinControl.SkinComboBox();
            this.modelcomboBox = new CCWin.SkinControl.SkinComboBox();
            this.label1 = new CCWin.SkinControl.SkinLabel();
            this.OKButton = new CCWin.SkinControl.SkinButton();
            this.resetButton = new CCWin.SkinControl.SkinButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new CCWin.SkinControl.SkinLabel();
            this.rePictureBox = new CCWin.SkinControl.SkinPictureBox();
            this.picturePrintButton = new CCWin.SkinControl.SkinButton();
            this.txtPrintButton = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.rePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetLabel
            // 
            this.dataSetLabel.AutoSize = true;
            this.dataSetLabel.Location = new System.Drawing.Point(186, 9);
            this.dataSetLabel.Name = "dataSetLabel";
            this.dataSetLabel.Size = new System.Drawing.Size(53, 12);
            this.dataSetLabel.TabIndex = 24;
            this.dataSetLabel.Text = "数据集：";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(12, 9);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(41, 12);
            this.modelLabel.TabIndex = 23;
            this.modelLabel.Text = "模型：";
            // 
            // dataSetcomboBox
            // 
            this.dataSetcomboBox.FormattingEnabled = true;
            this.dataSetcomboBox.Location = new System.Drawing.Point(245, 6);
            this.dataSetcomboBox.Name = "dataSetcomboBox";
            this.dataSetcomboBox.Size = new System.Drawing.Size(121, 20);
            this.dataSetcomboBox.TabIndex = 22;
            // 
            // modelcomboBox
            // 
            this.modelcomboBox.FormattingEnabled = true;
            this.modelcomboBox.Location = new System.Drawing.Point(59, 6);
            this.modelcomboBox.Name = "modelcomboBox";
            this.modelcomboBox.Size = new System.Drawing.Size(121, 20);
            this.modelcomboBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "RE曲线：";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(408, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 27;
            this.OKButton.Text = "确定";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(523, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 28;
            this.resetButton.Text = "重置";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(59, 426);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(527, 162);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 591);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "注：点击重置后，再点击左侧功能按钮，可进行（显示）新的验证。";
            // 
            // rePictureBox
            // 
            this.rePictureBox.Location = new System.Drawing.Point(59, 45);
            this.rePictureBox.Name = "rePictureBox";
            this.rePictureBox.Size = new System.Drawing.Size(480, 375);
            this.rePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rePictureBox.TabIndex = 31;
            this.rePictureBox.TabStop = false;
            // 
            // picturePrintButton
            // 
            this.picturePrintButton.Location = new System.Drawing.Point(620, 293);
            this.picturePrintButton.Name = "picturePrintButton";
            this.picturePrintButton.Size = new System.Drawing.Size(75, 33);
            this.picturePrintButton.TabIndex = 34;
            this.picturePrintButton.Text = "打印图片";
            this.picturePrintButton.UseVisualStyleBackColor = true;
            this.picturePrintButton.Click += new System.EventHandler(this.picturePrintButton_Click);
            // 
            // txtPrintButton
            // 
            this.txtPrintButton.Location = new System.Drawing.Point(620, 486);
            this.txtPrintButton.Name = "txtPrintButton";
            this.txtPrintButton.Size = new System.Drawing.Size(75, 33);
            this.txtPrintButton.TabIndex = 35;
            this.txtPrintButton.Text = "打印文本";
            this.txtPrintButton.UseVisualStyleBackColor = true;
            this.txtPrintButton.Click += new System.EventHandler(this.txtPrintButton_Click);
            // 
            // ReForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(755, 614);
            this.Controls.Add(this.txtPrintButton);
            this.Controls.Add(this.picturePrintButton);
            this.Controls.Add(this.rePictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataSetLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.dataSetcomboBox);
            this.Controls.Add(this.modelcomboBox);
            this.Name = "ReForm";
            this.Text = "ReForm";
            this.Load += new System.EventHandler(this.ReForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel dataSetLabel;
        private CCWin.SkinControl.SkinLabel modelLabel;
        private CCWin.SkinControl.SkinComboBox dataSetcomboBox;
        private CCWin.SkinControl.SkinComboBox modelcomboBox;
        private CCWin.SkinControl.SkinLabel label1;
        private CCWin.SkinControl.SkinButton OKButton;
        private CCWin.SkinControl.SkinButton resetButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private CCWin.SkinControl.SkinLabel label2;
        private CCWin.SkinControl.SkinPictureBox rePictureBox;
        private CCWin.SkinControl.SkinButton picturePrintButton;
        private CCWin.SkinControl.SkinButton txtPrintButton;
    }
}