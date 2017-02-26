namespace SRGMFormsApplication.UI
{
    partial class ModelForm
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
            this.modeldataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.delbutton = new System.Windows.Forms.Button();
            this.modelTypedataGridView = new System.Windows.Forms.DataGridView();
            this.valueLabel = new System.Windows.Forms.Label();
            this.dataSetcomboBox = new System.Windows.Forms.ComboBox();
            this.dataSetLabel = new System.Windows.Forms.Label();
            this.value0Label = new System.Windows.Forms.Label();
            this.value0TextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.value0dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.delValue0Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modeldataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTypedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value0dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modeldataGridView
            // 
            this.modeldataGridView.AllowUserToOrderColumns = true;
            this.modeldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modeldataGridView.Location = new System.Drawing.Point(14, 24);
            this.modeldataGridView.Name = "modeldataGridView";
            this.modeldataGridView.RowTemplate.Height = 23;
            this.modeldataGridView.Size = new System.Drawing.Size(327, 249);
            this.modeldataGridView.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "55555";
            // 
            // addbutton
            // 
            this.addbutton.Image = global::SRGMFormsApplication.Properties.Resources.添加;
            this.addbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addbutton.Location = new System.Drawing.Point(14, 279);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(53, 29);
            this.addbutton.TabIndex = 16;
            this.addbutton.Text = "添加";
            this.addbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // delbutton
            // 
            this.delbutton.Image = global::SRGMFormsApplication.Properties.Resources.删除;
            this.delbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delbutton.Location = new System.Drawing.Point(239, 279);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(53, 29);
            this.delbutton.TabIndex = 17;
            this.delbutton.Text = "删除";
            this.delbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delbutton.UseVisualStyleBackColor = true;
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // modelTypedataGridView
            // 
            this.modelTypedataGridView.AllowUserToAddRows = false;
            this.modelTypedataGridView.AllowUserToDeleteRows = false;
            this.modelTypedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelTypedataGridView.Location = new System.Drawing.Point(347, 24);
            this.modelTypedataGridView.Name = "modelTypedataGridView";
            this.modelTypedataGridView.ReadOnly = true;
            this.modelTypedataGridView.RowTemplate.Height = 23;
            this.modelTypedataGridView.Size = new System.Drawing.Size(247, 249);
            this.modelTypedataGridView.TabIndex = 18;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(12, 356);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(89, 12);
            this.valueLabel.TabIndex = 19;
            this.valueLabel.Text = "参数初值设置：";
            // 
            // dataSetcomboBox
            // 
            this.dataSetcomboBox.FormattingEnabled = true;
            this.dataSetcomboBox.Location = new System.Drawing.Point(107, 353);
            this.dataSetcomboBox.Name = "dataSetcomboBox";
            this.dataSetcomboBox.Size = new System.Drawing.Size(90, 20);
            this.dataSetcomboBox.TabIndex = 20;
            // 
            // dataSetLabel
            // 
            this.dataSetLabel.AutoSize = true;
            this.dataSetLabel.Location = new System.Drawing.Point(105, 328);
            this.dataSetLabel.Name = "dataSetLabel";
            this.dataSetLabel.Size = new System.Drawing.Size(71, 12);
            this.dataSetLabel.TabIndex = 21;
            this.dataSetLabel.Text = "失效数据集:";
            // 
            // value0Label
            // 
            this.value0Label.AutoSize = true;
            this.value0Label.Location = new System.Drawing.Point(217, 328);
            this.value0Label.Name = "value0Label";
            this.value0Label.Size = new System.Drawing.Size(377, 12);
            this.value0Label.TabIndex = 22;
            this.value0Label.Text = "参数初值（同一函数的空格隔开;不同函数的；隔开。顺序：wt;mt）：";
            // 
            // value0TextBox
            // 
            this.value0TextBox.Location = new System.Drawing.Point(219, 352);
            this.value0TextBox.Name = "value0TextBox";
            this.value0TextBox.Size = new System.Drawing.Size(240, 21);
            this.value0TextBox.TabIndex = 23;
            // 
            // OKButton
            // 
            this.OKButton.BackgroundImage = global::SRGMFormsApplication.Properties.Resources.menu_bt;
            this.OKButton.Location = new System.Drawing.Point(503, 347);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(79, 29);
            this.OKButton.TabIndex = 24;
            this.OKButton.Text = "确定";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // value0dataGridView
            // 
            this.value0dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.value0dataGridView.Location = new System.Drawing.Point(107, 382);
            this.value0dataGridView.Name = "value0dataGridView";
            this.value0dataGridView.RowTemplate.Height = 23;
            this.value0dataGridView.Size = new System.Drawing.Size(388, 161);
            this.value0dataGridView.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "请输入类型编号：";
            // 
            // delValue0Button
            // 
            this.delValue0Button.Image = global::SRGMFormsApplication.Properties.Resources.删除;
            this.delValue0Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delValue0Button.Location = new System.Drawing.Point(503, 514);
            this.delValue0Button.Name = "delValue0Button";
            this.delValue0Button.Size = new System.Drawing.Size(54, 29);
            this.delValue0Button.TabIndex = 34;
            this.delValue0Button.Text = "删除";
            this.delValue0Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delValue0Button.UseVisualStyleBackColor = true;
            this.delValue0Button.Click += new System.EventHandler(this.delValue0Button_Click);
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 571);
            this.Controls.Add(this.delValue0Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.value0dataGridView);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.value0TextBox);
            this.Controls.Add(this.value0Label);
            this.Controls.Add(this.dataSetLabel);
            this.Controls.Add(this.dataSetcomboBox);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.modelTypedataGridView);
            this.Controls.Add(this.modeldataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.delbutton);
            this.Name = "ModelForm";
            this.Text = "ModelForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModelForm_FormClosed);
            this.Load += new System.EventHandler(this.ModelForm_Load);
            this.Resize += new System.EventHandler(this.ModelForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.modeldataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTypedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value0dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView modeldataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.DataGridView modelTypedataGridView;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.ComboBox dataSetcomboBox;
        private System.Windows.Forms.Label dataSetLabel;
        private System.Windows.Forms.Label value0Label;
        private System.Windows.Forms.TextBox value0TextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.DataGridView value0dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delValue0Button;
    }
}