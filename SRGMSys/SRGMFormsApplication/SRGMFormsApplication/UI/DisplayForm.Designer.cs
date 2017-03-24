namespace SRGMFormsApplication.UI
{
    partial class DisplayForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectLabel = new System.Windows.Forms.ToolStripLabel();
            this.fitLabel = new System.Windows.Forms.ToolStripLabel();
            this.reLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.compareLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(51, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 342);
            this.panel1.TabIndex = 6;
            // 
            // selectLabel
            // 
            this.selectLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectLabel.IsLink = true;
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(48, 25);
            this.selectLabel.Text = "选择";
            this.selectLabel.Click += new System.EventHandler(this.selectLabel_Click);
            // 
            // fitLabel
            // 
            this.fitLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fitLabel.IsLink = true;
            this.fitLabel.Name = "fitLabel";
            this.fitLabel.Size = new System.Drawing.Size(48, 25);
            this.fitLabel.Text = "拟合";
            this.fitLabel.Click += new System.EventHandler(this.fitLabel_Click);
            // 
            // reLabel
            // 
            this.reLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reLabel.IsLink = true;
            this.reLabel.Name = "reLabel";
            this.reLabel.Size = new System.Drawing.Size(48, 25);
            this.reLabel.Text = "预测";
            this.reLabel.Click += new System.EventHandler(this.reLabel_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectLabel,
            this.fitLabel,
            this.reLabel,
            this.compareLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(51, 342);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // compareLabel
            // 
            this.compareLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.compareLabel.IsLink = true;
            this.compareLabel.Name = "compareLabel";
            this.compareLabel.Size = new System.Drawing.Size(48, 25);
            this.compareLabel.Text = "比较";
            this.compareLabel.Click += new System.EventHandler(this.compareLabel_Click);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayForm_FormClosed);
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel selectLabel;
        private System.Windows.Forms.ToolStripLabel fitLabel;
        private System.Windows.Forms.ToolStripLabel reLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel compareLabel;
    }
}