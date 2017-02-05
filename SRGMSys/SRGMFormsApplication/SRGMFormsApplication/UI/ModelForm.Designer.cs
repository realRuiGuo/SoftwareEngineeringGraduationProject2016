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
            ((System.ComponentModel.ISupportInitialize)(this.modeldataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTypedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modeldataGridView
            // 
            this.modeldataGridView.AllowUserToOrderColumns = true;
            this.modeldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modeldataGridView.Location = new System.Drawing.Point(14, 24);
            this.modeldataGridView.Name = "modeldataGridView";
            this.modeldataGridView.RowTemplate.Height = 23;
            this.modeldataGridView.Size = new System.Drawing.Size(410, 249);
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
            this.delbutton.Location = new System.Drawing.Point(90, 279);
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
            this.modelTypedataGridView.Location = new System.Drawing.Point(453, 24);
            this.modelTypedataGridView.Name = "modelTypedataGridView";
            this.modelTypedataGridView.ReadOnly = true;
            this.modelTypedataGridView.RowTemplate.Height = 23;
            this.modelTypedataGridView.Size = new System.Drawing.Size(267, 249);
            this.modelTypedataGridView.TabIndex = 18;
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 321);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView modeldataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.DataGridView modelTypedataGridView;
    }
}