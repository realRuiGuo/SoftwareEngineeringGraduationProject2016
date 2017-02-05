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
            this.dataSetLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.dataSetcomboBox = new System.Windows.Forms.ComboBox();
            this.modelcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rePictureBox = new System.Windows.Forms.PictureBox();
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
            // rePictureBox
            // 
            this.rePictureBox.Location = new System.Drawing.Point(71, 45);
            this.rePictureBox.Name = "rePictureBox";
            this.rePictureBox.Size = new System.Drawing.Size(475, 283);
            this.rePictureBox.TabIndex = 26;
            this.rePictureBox.TabStop = false;
            // 
            // ReForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 327);
            this.Controls.Add(this.rePictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataSetLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.dataSetcomboBox);
            this.Controls.Add(this.modelcomboBox);
            this.Name = "ReForm";
            this.Text = "ReForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.rePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dataSetLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.ComboBox dataSetcomboBox;
        private System.Windows.Forms.ComboBox modelcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox rePictureBox;
    }
}