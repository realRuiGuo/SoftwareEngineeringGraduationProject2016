namespace SRGMFormsApplication.UI
{
    partial class SelectForm
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
            this.dataSetdataGridView = new System.Windows.Forms.DataGridView();
            this.modellistBox = new System.Windows.Forms.ListBox();
            this.datasetlistBox = new System.Windows.Forms.ListBox();
            this.dataSetbutton = new System.Windows.Forms.Button();
            this.modelbutton = new System.Windows.Forms.Button();
            this.delDataSetbutton = new System.Windows.Forms.Button();
            this.delModelbutton = new System.Windows.Forms.Button();
            this.addDataSetbutton = new System.Windows.Forms.Button();
            this.addModelbutton = new System.Windows.Forms.Button();
            this.modelcomboBox = new System.Windows.Forms.ComboBox();
            this.dataSetcomboBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DStitlelabel = new System.Windows.Forms.Label();
            this.waringLabel = new System.Windows.Forms.Label();
            this.value0Label = new System.Windows.Forms.Label();
            this.value0dataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSetrichTextBox = new System.Windows.Forms.RichTextBox();
            this.modelrichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modeldataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value0dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modeldataGridView
            // 
            this.modeldataGridView.AllowUserToAddRows = false;
            this.modeldataGridView.AllowUserToDeleteRows = false;
            this.modeldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modeldataGridView.Location = new System.Drawing.Point(12, 38);
            this.modeldataGridView.Name = "modeldataGridView";
            this.modeldataGridView.ReadOnly = true;
            this.modeldataGridView.RowTemplate.Height = 23;
            this.modeldataGridView.Size = new System.Drawing.Size(339, 170);
            this.modeldataGridView.TabIndex = 2;
            // 
            // dataSetdataGridView
            // 
            this.dataSetdataGridView.AllowUserToAddRows = false;
            this.dataSetdataGridView.AllowUserToDeleteRows = false;
            this.dataSetdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSetdataGridView.Location = new System.Drawing.Point(364, 38);
            this.dataSetdataGridView.Name = "dataSetdataGridView";
            this.dataSetdataGridView.ReadOnly = true;
            this.dataSetdataGridView.RowTemplate.Height = 23;
            this.dataSetdataGridView.Size = new System.Drawing.Size(330, 170);
            this.dataSetdataGridView.TabIndex = 3;
            // 
            // modellistBox
            // 
            this.modellistBox.FormattingEnabled = true;
            this.modellistBox.ItemHeight = 12;
            this.modellistBox.Location = new System.Drawing.Point(12, 466);
            this.modellistBox.Name = "modellistBox";
            this.modellistBox.Size = new System.Drawing.Size(330, 124);
            this.modellistBox.TabIndex = 4;
            // 
            // datasetlistBox
            // 
            this.datasetlistBox.FormattingEnabled = true;
            this.datasetlistBox.ItemHeight = 12;
            this.datasetlistBox.Location = new System.Drawing.Point(359, 466);
            this.datasetlistBox.Name = "datasetlistBox";
            this.datasetlistBox.Size = new System.Drawing.Size(330, 124);
            this.datasetlistBox.TabIndex = 5;
            // 
            // dataSetbutton
            // 
            this.dataSetbutton.BackgroundImage = global::SRGMFormsApplication.Properties.Resources.menu_bt;
            this.dataSetbutton.Location = new System.Drawing.Point(588, 596);
            this.dataSetbutton.Name = "dataSetbutton";
            this.dataSetbutton.Size = new System.Drawing.Size(101, 29);
            this.dataSetbutton.TabIndex = 11;
            this.dataSetbutton.Text = "确定所选数据集";
            this.dataSetbutton.UseVisualStyleBackColor = true;
            this.dataSetbutton.Click += new System.EventHandler(this.dataSetbutton_Click);
            // 
            // modelbutton
            // 
            this.modelbutton.BackgroundImage = global::SRGMFormsApplication.Properties.Resources.menu_bt;
            this.modelbutton.Location = new System.Drawing.Point(241, 596);
            this.modelbutton.Name = "modelbutton";
            this.modelbutton.Size = new System.Drawing.Size(101, 29);
            this.modelbutton.TabIndex = 10;
            this.modelbutton.Text = "确定所选模型";
            this.modelbutton.UseVisualStyleBackColor = true;
            this.modelbutton.Click += new System.EventHandler(this.modelbutton_Click);
            // 
            // delDataSetbutton
            // 
            this.delDataSetbutton.Image = global::SRGMFormsApplication.Properties.Resources.删除;
            this.delDataSetbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delDataSetbutton.Location = new System.Drawing.Point(359, 596);
            this.delDataSetbutton.Name = "delDataSetbutton";
            this.delDataSetbutton.Size = new System.Drawing.Size(53, 29);
            this.delDataSetbutton.TabIndex = 9;
            this.delDataSetbutton.Text = "删除";
            this.delDataSetbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delDataSetbutton.UseVisualStyleBackColor = true;
            this.delDataSetbutton.Click += new System.EventHandler(this.delDataSetbutton_Click);
            // 
            // delModelbutton
            // 
            this.delModelbutton.Image = global::SRGMFormsApplication.Properties.Resources.删除;
            this.delModelbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delModelbutton.Location = new System.Drawing.Point(12, 596);
            this.delModelbutton.Name = "delModelbutton";
            this.delModelbutton.Size = new System.Drawing.Size(53, 29);
            this.delModelbutton.TabIndex = 8;
            this.delModelbutton.Text = "删除";
            this.delModelbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delModelbutton.UseVisualStyleBackColor = true;
            this.delModelbutton.Click += new System.EventHandler(this.delModelbutton_Click);
            // 
            // addDataSetbutton
            // 
            this.addDataSetbutton.Image = global::SRGMFormsApplication.Properties.Resources.添加;
            this.addDataSetbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addDataSetbutton.Location = new System.Drawing.Point(359, 431);
            this.addDataSetbutton.Name = "addDataSetbutton";
            this.addDataSetbutton.Size = new System.Drawing.Size(53, 29);
            this.addDataSetbutton.TabIndex = 7;
            this.addDataSetbutton.Text = "添加";
            this.addDataSetbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDataSetbutton.UseVisualStyleBackColor = true;
            this.addDataSetbutton.Click += new System.EventHandler(this.addDataSetbutton_Click);
            // 
            // addModelbutton
            // 
            this.addModelbutton.Image = global::SRGMFormsApplication.Properties.Resources.添加;
            this.addModelbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addModelbutton.Location = new System.Drawing.Point(12, 431);
            this.addModelbutton.Name = "addModelbutton";
            this.addModelbutton.Size = new System.Drawing.Size(53, 29);
            this.addModelbutton.TabIndex = 6;
            this.addModelbutton.Text = "添加";
            this.addModelbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addModelbutton.UseVisualStyleBackColor = true;
            this.addModelbutton.Click += new System.EventHandler(this.addModelbutton_Click);
            // 
            // modelcomboBox
            // 
            this.modelcomboBox.FormattingEnabled = true;
            this.modelcomboBox.Location = new System.Drawing.Point(12, 12);
            this.modelcomboBox.Name = "modelcomboBox";
            this.modelcomboBox.Size = new System.Drawing.Size(121, 20);
            this.modelcomboBox.TabIndex = 12;
            this.modelcomboBox.SelectedIndexChanged += new System.EventHandler(this.modelcomboBox_SelectedIndexChanged);
            // 
            // dataSetcomboBox
            // 
            this.dataSetcomboBox.FormattingEnabled = true;
            this.dataSetcomboBox.Location = new System.Drawing.Point(364, 12);
            this.dataSetcomboBox.Name = "dataSetcomboBox";
            this.dataSetcomboBox.Size = new System.Drawing.Size(121, 20);
            this.dataSetcomboBox.TabIndex = 13;
            this.dataSetcomboBox.SelectedIndexChanged += new System.EventHandler(this.dataSetcomboBox_SelectedIndexChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(303, 631);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(96, 28);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "开始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DStitlelabel);
            this.panel1.Controls.Add(this.waringLabel);
            this.panel1.Controls.Add(this.value0Label);
            this.panel1.Controls.Add(this.value0dataGridView);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataSetrichTextBox);
            this.panel1.Controls.Add(this.modelrichTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.modelcomboBox);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.dataSetdataGridView);
            this.panel1.Controls.Add(this.dataSetbutton);
            this.panel1.Controls.Add(this.dataSetcomboBox);
            this.panel1.Controls.Add(this.delDataSetbutton);
            this.panel1.Controls.Add(this.modelbutton);
            this.panel1.Controls.Add(this.modeldataGridView);
            this.panel1.Controls.Add(this.addModelbutton);
            this.panel1.Controls.Add(this.delModelbutton);
            this.panel1.Controls.Add(this.addDataSetbutton);
            this.panel1.Controls.Add(this.datasetlistBox);
            this.panel1.Controls.Add(this.modellistBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 677);
            this.panel1.TabIndex = 15;
            // 
            // DStitlelabel
            // 
            this.DStitlelabel.AutoSize = true;
            this.DStitlelabel.Location = new System.Drawing.Point(362, 240);
            this.DStitlelabel.Name = "DStitlelabel";
            this.DStitlelabel.Size = new System.Drawing.Size(77, 12);
            this.DStitlelabel.TabIndex = 39;
            this.DStitlelabel.Text = "DStitlelabel";
            // 
            // waringLabel
            // 
            this.waringLabel.AutoSize = true;
            this.waringLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.waringLabel.Location = new System.Drawing.Point(720, 11);
            this.waringLabel.Name = "waringLabel";
            this.waringLabel.Size = new System.Drawing.Size(296, 16);
            this.waringLabel.TabIndex = 38;
            this.waringLabel.Text = "请参照初值表来选择模型和失效数据集！";
            // 
            // value0Label
            // 
            this.value0Label.AutoSize = true;
            this.value0Label.Location = new System.Drawing.Point(721, 32);
            this.value0Label.Name = "value0Label";
            this.value0Label.Size = new System.Drawing.Size(53, 12);
            this.value0Label.TabIndex = 37;
            this.value0Label.Text = "初值表：";
            // 
            // value0dataGridView
            // 
            this.value0dataGridView.AllowUserToAddRows = false;
            this.value0dataGridView.AllowUserToDeleteRows = false;
            this.value0dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.value0dataGridView.Location = new System.Drawing.Point(723, 47);
            this.value0dataGridView.Name = "value0dataGridView";
            this.value0dataGridView.ReadOnly = true;
            this.value0dataGridView.RowTemplate.Height = 23;
            this.value0dataGridView.Size = new System.Drawing.Size(388, 581);
            this.value0dataGridView.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "显示数据集信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "显示模型信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSetrichTextBox
            // 
            this.dataSetrichTextBox.Location = new System.Drawing.Point(359, 255);
            this.dataSetrichTextBox.Name = "dataSetrichTextBox";
            this.dataSetrichTextBox.ReadOnly = true;
            this.dataSetrichTextBox.Size = new System.Drawing.Size(330, 170);
            this.dataSetrichTextBox.TabIndex = 33;
            this.dataSetrichTextBox.Text = "";
            // 
            // modelrichTextBox
            // 
            this.modelrichTextBox.Location = new System.Drawing.Point(12, 255);
            this.modelrichTextBox.Name = "modelrichTextBox";
            this.modelrichTextBox.ReadOnly = true;
            this.modelrichTextBox.Size = new System.Drawing.Size(339, 170);
            this.modelrichTextBox.TabIndex = 32;
            this.modelrichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 662);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "注：点击重置后，再点击左侧功能按钮，可进行（显示）新的验证。";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(614, 634);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "重置";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 677);
            this.Controls.Add(this.panel1);
            this.Name = "SelectForm";
            this.Text = "SelectForm";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modeldataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value0dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox modelcomboBox;
        private System.Windows.Forms.ComboBox dataSetcomboBox;
        private System.Windows.Forms.DataGridView modeldataGridView;
        private System.Windows.Forms.DataGridView dataSetdataGridView;
        private System.Windows.Forms.ListBox modellistBox;
        private System.Windows.Forms.ListBox datasetlistBox;
        private System.Windows.Forms.Button addModelbutton;
        private System.Windows.Forms.Button addDataSetbutton;
        private System.Windows.Forms.Button delModelbutton;
        private System.Windows.Forms.Button delDataSetbutton;
        private System.Windows.Forms.Button modelbutton;
        private System.Windows.Forms.Button dataSetbutton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox dataSetrichTextBox;
        private System.Windows.Forms.RichTextBox modelrichTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView value0dataGridView;
        private System.Windows.Forms.Label value0Label;
        private System.Windows.Forms.Label waringLabel;
        private System.Windows.Forms.Label DStitlelabel;
    }
}