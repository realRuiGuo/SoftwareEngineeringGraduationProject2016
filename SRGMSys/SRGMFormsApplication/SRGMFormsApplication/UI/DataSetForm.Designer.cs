namespace SRGMFormsApplication.UI
{
    partial class DataSetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSetForm));
            this.dataSetdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.delbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetdataGridView
            // 
            this.dataSetdataGridView.AllowUserToOrderColumns = true;
            this.dataSetdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSetdataGridView.Location = new System.Drawing.Point(13, 26);
            this.dataSetdataGridView.Name = "dataSetdataGridView";
            this.dataSetdataGridView.RowTemplate.Height = 23;
            this.dataSetdataGridView.Size = new System.Drawing.Size(573, 249);
            this.dataSetdataGridView.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "55555";
            // 
            // addbutton
            // 
            this.addbutton.Image = global::SRGMFormsApplication.Properties.Resources.添加;
            this.addbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addbutton.Location = new System.Drawing.Point(13, 281);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(53, 29);
            this.addbutton.TabIndex = 12;
            this.addbutton.Text = "添加";
            this.addbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbutton.UseVisualStyleBackColor = true;
            // 
            // delbutton
            // 
            this.delbutton.Image = global::SRGMFormsApplication.Properties.Resources.删除;
            this.delbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delbutton.Location = new System.Drawing.Point(89, 281);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(53, 29);
            this.delbutton.TabIndex = 13;
            this.delbutton.Text = "删除";
            this.delbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delbutton.UseVisualStyleBackColor = true;
            // 
            // DataSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(597, 320);
            this.Controls.Add(this.dataSetdataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.delbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataSetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据集管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataSetForm_FormClosed);
            this.Load += new System.EventHandler(this.DataSetForm_Load);
            this.Resize += new System.EventHandler(this.DataSetForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSetdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button delbutton;

    }
}