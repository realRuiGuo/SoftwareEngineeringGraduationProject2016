namespace SRGMFormsApplication.UI
{
    partial class CompareForm
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
            this.resetButton = new CCWin.SkinControl.SkinButton();
            this.OKButton = new CCWin.SkinControl.SkinButton();
            this.dataSetLabel = new CCWin.SkinControl.SkinLabel();
            this.dataSetcomboBox = new CCWin.SkinControl.SkinComboBox();
            this.comPictureBox = new CCWin.SkinControl.SkinPictureBox();
            this.label2 = new CCWin.SkinControl.SkinLabel();
            this.pictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.picturePrintButton = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.comPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(424, 10);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 26;
            this.resetButton.Text = "重置";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(282, 10);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 25;
            this.OKButton.Text = "确定";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // dataSetLabel
            // 
            this.dataSetLabel.AutoSize = true;
            this.dataSetLabel.Location = new System.Drawing.Point(12, 15);
            this.dataSetLabel.Name = "dataSetLabel";
            this.dataSetLabel.Size = new System.Drawing.Size(53, 12);
            this.dataSetLabel.TabIndex = 24;
            this.dataSetLabel.Text = "数据集：";
            // 
            // dataSetcomboBox
            // 
            this.dataSetcomboBox.FormattingEnabled = true;
            this.dataSetcomboBox.Location = new System.Drawing.Point(72, 12);
            this.dataSetcomboBox.Name = "dataSetcomboBox";
            this.dataSetcomboBox.Size = new System.Drawing.Size(121, 20);
            this.dataSetcomboBox.TabIndex = 23;
            // 
            // comPictureBox
            // 
            this.comPictureBox.Location = new System.Drawing.Point(72, 48);
            this.comPictureBox.Name = "comPictureBox";
            this.comPictureBox.Size = new System.Drawing.Size(480, 480);
            this.comPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.comPictureBox.TabIndex = 28;
            this.comPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "拟合图：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(558, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // picturePrintButton
            // 
            this.picturePrintButton.Location = new System.Drawing.Point(734, 9);
            this.picturePrintButton.Name = "picturePrintButton";
            this.picturePrintButton.Size = new System.Drawing.Size(75, 24);
            this.picturePrintButton.TabIndex = 34;
            this.picturePrintButton.Text = "打印图片";
            this.picturePrintButton.UseVisualStyleBackColor = true;
            this.picturePrintButton.Click += new System.EventHandler(this.picturePrintButton_Click);
            // 
            // CompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1047, 555);
            this.Controls.Add(this.picturePrintButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.dataSetLabel);
            this.Controls.Add(this.dataSetcomboBox);
            this.Name = "CompareForm";
            this.Text = "CompareForm";
            this.Load += new System.EventHandler(this.CompareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton resetButton;
        private CCWin.SkinControl.SkinButton OKButton;
        private CCWin.SkinControl.SkinLabel dataSetLabel;
        private CCWin.SkinControl.SkinComboBox dataSetcomboBox;
        private CCWin.SkinControl.SkinPictureBox comPictureBox;
        private CCWin.SkinControl.SkinLabel label2;
        private CCWin.SkinControl.SkinPictureBox pictureBox1;
        private CCWin.SkinControl.SkinButton picturePrintButton;
    }
}