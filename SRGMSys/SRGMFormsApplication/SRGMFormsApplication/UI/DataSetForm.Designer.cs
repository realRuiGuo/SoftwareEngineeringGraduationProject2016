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
            this.typeDataGridView = new System.Windows.Forms.DataGridView();
            this.typeLabel = new System.Windows.Forms.Label();
            this.value0dataGridView = new System.Windows.Forms.DataGridView();
            this.OKButton = new System.Windows.Forms.Button();
            this.value0TextBox = new System.Windows.Forms.TextBox();
            this.value0Label = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelcomboBox = new System.Windows.Forms.ComboBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.delValue0Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value0dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetdataGridView
            // 
            this.dataSetdataGridView.AllowUserToOrderColumns = true;
            this.dataSetdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSetdataGridView.Location = new System.Drawing.Point(13, 26);
            this.dataSetdataGridView.Name = "dataSetdataGridView";
            this.dataSetdataGridView.RowTemplate.Height = 23;
            this.dataSetdataGridView.Size = new System.Drawing.Size(447, 249);
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
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
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
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // typeDataGridView
            // 
            this.typeDataGridView.AllowUserToAddRows = false;
            this.typeDataGridView.AllowUserToDeleteRows = false;
            this.typeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeDataGridView.Location = new System.Drawing.Point(472, 26);
            this.typeDataGridView.Name = "typeDataGridView";
            this.typeDataGridView.ReadOnly = true;
            this.typeDataGridView.RowTemplate.Height = 23;
            this.typeDataGridView.Size = new System.Drawing.Size(341, 249);
            this.typeDataGridView.TabIndex = 14;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(470, 11);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(77, 12);
            this.typeLabel.TabIndex = 15;
            this.typeLabel.Text = "数据集类型：";
            // 
            // value0dataGridView
            // 
            this.value0dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.value0dataGridView.Location = new System.Drawing.Point(108, 382);
            this.value0dataGridView.Name = "value0dataGridView";
            this.value0dataGridView.RowTemplate.Height = 23;
            this.value0dataGridView.Size = new System.Drawing.Size(388, 161);
            this.value0dataGridView.TabIndex = 32;
            // 
            // OKButton
            // 
            this.OKButton.BackgroundImage = global::SRGMFormsApplication.Properties.Resources.menu_bt;
            this.OKButton.Location = new System.Drawing.Point(504, 347);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(79, 29);
            this.OKButton.TabIndex = 31;
            this.OKButton.Text = "确定";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // value0TextBox
            // 
            this.value0TextBox.Location = new System.Drawing.Point(220, 352);
            this.value0TextBox.Name = "value0TextBox";
            this.value0TextBox.Size = new System.Drawing.Size(240, 21);
            this.value0TextBox.TabIndex = 30;
            // 
            // value0Label
            // 
            this.value0Label.AutoSize = true;
            this.value0Label.Location = new System.Drawing.Point(218, 328);
            this.value0Label.Name = "value0Label";
            this.value0Label.Size = new System.Drawing.Size(377, 12);
            this.value0Label.TabIndex = 29;
            this.value0Label.Text = "参数初值（同一函数的空格隔开;不同函数的；隔开。顺序：wt;mt）：";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(106, 328);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(35, 12);
            this.modelLabel.TabIndex = 28;
            this.modelLabel.Text = "模型:";
            // 
            // modelcomboBox
            // 
            this.modelcomboBox.FormattingEnabled = true;
            this.modelcomboBox.Location = new System.Drawing.Point(108, 353);
            this.modelcomboBox.Name = "modelcomboBox";
            this.modelcomboBox.Size = new System.Drawing.Size(90, 20);
            this.modelcomboBox.TabIndex = 27;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(13, 356);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(89, 12);
            this.valueLabel.TabIndex = 26;
            this.valueLabel.Text = "参数初值设置：";
            // 
            // delValue0Button
            // 
            this.delValue0Button.Image = global::SRGMFormsApplication.Properties.Resources.删除;
            this.delValue0Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delValue0Button.Location = new System.Drawing.Point(514, 514);
            this.delValue0Button.Name = "delValue0Button";
            this.delValue0Button.Size = new System.Drawing.Size(54, 29);
            this.delValue0Button.TabIndex = 33;
            this.delValue0Button.Text = "删除";
            this.delValue0Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delValue0Button.UseVisualStyleBackColor = true;
            this.delValue0Button.Click += new System.EventHandler(this.delValue0Button_Click);
            // 
            // DataSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(822, 553);
            this.Controls.Add(this.delValue0Button);
            this.Controls.Add(this.value0dataGridView);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.value0TextBox);
            this.Controls.Add(this.value0Label);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.modelcomboBox);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeDataGridView);
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
           //this.Resize += new System.EventHandler(this.DataSetForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value0dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSetdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.DataGridView typeDataGridView;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.DataGridView value0dataGridView;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox value0TextBox;
        private System.Windows.Forms.Label value0Label;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.ComboBox modelcomboBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Button delValue0Button;

    }
}