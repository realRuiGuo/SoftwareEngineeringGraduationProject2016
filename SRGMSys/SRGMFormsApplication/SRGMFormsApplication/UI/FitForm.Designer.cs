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
            this.modelcomboBox = new System.Windows.Forms.ComboBox();
            this.dataSetcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.dataSetLabel = new System.Windows.Forms.Label();
            this.fitPictureBox = new System.Windows.Forms.PictureBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // modelcomboBox
            // 
            this.modelcomboBox.FormattingEnabled = true;
            this.modelcomboBox.Location = new System.Drawing.Point(59, 12);
            this.modelcomboBox.Name = "modelcomboBox";
            this.modelcomboBox.Size = new System.Drawing.Size(121, 20);
            this.modelcomboBox.TabIndex = 13;
            // 
            // dataSetcomboBox
            // 
            this.dataSetcomboBox.FormattingEnabled = true;
            this.dataSetcomboBox.Location = new System.Drawing.Point(245, 12);
            this.dataSetcomboBox.Name = "dataSetcomboBox";
            this.dataSetcomboBox.Size = new System.Drawing.Size(121, 20);
            this.dataSetcomboBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "拟合参数值、标准值：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "拟合图：";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(12, 15);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(41, 12);
            this.modelLabel.TabIndex = 19;
            this.modelLabel.Text = "模型：";
            // 
            // dataSetLabel
            // 
            this.dataSetLabel.AutoSize = true;
            this.dataSetLabel.Location = new System.Drawing.Point(186, 15);
            this.dataSetLabel.Name = "dataSetLabel";
            this.dataSetLabel.Size = new System.Drawing.Size(53, 12);
            this.dataSetLabel.TabIndex = 20;
            this.dataSetLabel.Text = "数据集：";
            // 
            // fitPictureBox
            // 
            this.fitPictureBox.Location = new System.Drawing.Point(59, 52);
            this.fitPictureBox.Name = "fitPictureBox";
            this.fitPictureBox.Size = new System.Drawing.Size(480, 375);
            this.fitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fitPictureBox.TabIndex = 18;
            this.fitPictureBox.TabStop = false;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(455, 10);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 21;
            this.OKButton.Text = "确定";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(597, 10);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "重置";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // richTextBox1
            // 
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
            this.label3.Location = new System.Drawing.Point(12, 623);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "注：点击重置后，再点击左侧功能按钮，可进行（显示）新的验证。";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(557, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // FitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 644);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FitForm_FormClosed);
            this.Load += new System.EventHandler(this.FitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox modelcomboBox;
        private System.Windows.Forms.ComboBox dataSetcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox fitPictureBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label dataSetLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}