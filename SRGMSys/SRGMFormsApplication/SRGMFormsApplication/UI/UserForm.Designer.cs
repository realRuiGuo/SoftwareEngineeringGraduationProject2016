namespace SRGMFormsApplication.UI
{
    partial class UserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seDataGridView = new System.Windows.Forms.DataGridView();
            this.srDataGridView = new System.Windows.Forms.DataGridView();
            this.seDelButton = new System.Windows.Forms.Button();
            this.srDelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.seDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "软件工程师：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "SRGM研究人员：";
            // 
            // seDataGridView
            // 
            this.seDataGridView.AllowUserToAddRows = false;
            this.seDataGridView.AllowUserToDeleteRows = false;
            this.seDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seDataGridView.Location = new System.Drawing.Point(12, 24);
            this.seDataGridView.Name = "seDataGridView";
            this.seDataGridView.ReadOnly = true;
            this.seDataGridView.RowTemplate.Height = 23;
            this.seDataGridView.Size = new System.Drawing.Size(240, 150);
            this.seDataGridView.TabIndex = 2;
            // 
            // srDataGridView
            // 
            this.srDataGridView.AllowUserToAddRows = false;
            this.srDataGridView.AllowUserToDeleteRows = false;
            this.srDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.srDataGridView.Location = new System.Drawing.Point(12, 197);
            this.srDataGridView.Name = "srDataGridView";
            this.srDataGridView.ReadOnly = true;
            this.srDataGridView.RowTemplate.Height = 23;
            this.srDataGridView.Size = new System.Drawing.Size(240, 150);
            this.srDataGridView.TabIndex = 3;
            // 
            // seDelButton
            // 
            this.seDelButton.Location = new System.Drawing.Point(276, 143);
            this.seDelButton.Name = "seDelButton";
            this.seDelButton.Size = new System.Drawing.Size(57, 31);
            this.seDelButton.TabIndex = 4;
            this.seDelButton.Text = "删除";
            this.seDelButton.UseVisualStyleBackColor = true;
            this.seDelButton.Click += new System.EventHandler(this.seDelButton_Click);
            // 
            // srDelButton
            // 
            this.srDelButton.Location = new System.Drawing.Point(276, 316);
            this.srDelButton.Name = "srDelButton";
            this.srDelButton.Size = new System.Drawing.Size(57, 31);
            this.srDelButton.TabIndex = 5;
            this.srDelButton.Text = "删除";
            this.srDelButton.UseVisualStyleBackColor = true;
            this.srDelButton.Click += new System.EventHandler(this.srDelButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 353);
            this.Controls.Add(this.srDelButton);
            this.Controls.Add(this.seDelButton);
            this.Controls.Add(this.srDataGridView);
            this.Controls.Add(this.seDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView seDataGridView;
        private System.Windows.Forms.DataGridView srDataGridView;
        private System.Windows.Forms.Button seDelButton;
        private System.Windows.Forms.Button srDelButton;
    }
}