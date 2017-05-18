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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayForm));
            this.panel1 = new CCWin.SkinControl.SkinPanel();
            this.selectLabel = new System.Windows.Forms.ToolStripLabel();
            this.fitLabel = new System.Windows.Forms.ToolStripLabel();
            this.reLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new CCWin.SkinControl.SkinToolStrip();
            this.compareLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.DownBack = null;
            this.panel1.Location = new System.Drawing.Point(55, 28);
            this.panel1.MouseBack = null;
            this.panel1.Name = "panel1";
            this.panel1.NormlBack = null;
            this.panel1.Size = new System.Drawing.Size(519, 310);
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
            this.toolStrip1.Arrow = System.Drawing.Color.Black;
            this.toolStrip1.Back = System.Drawing.Color.White;
            this.toolStrip1.BackRadius = 4;
            this.toolStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.toolStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.toolStrip1.BaseFore = System.Drawing.Color.Black;
            this.toolStrip1.BaseForeAnamorphosis = false;
            this.toolStrip1.BaseForeAnamorphosisBorder = 4;
            this.toolStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.toolStrip1.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.toolStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.toolStrip1.BaseItemAnamorphosis = true;
            this.toolStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.toolStrip1.BaseItemBorderShow = true;
            this.toolStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BaseItemDown")));
            this.toolStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.toolStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BaseItemMouse")));
            this.toolStrip1.BaseItemNorml = null;
            this.toolStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.toolStrip1.BaseItemRadius = 4;
            this.toolStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.toolStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.toolStrip1.BindTabControl = null;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.toolStrip1.Fore = System.Drawing.Color.Black;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.HoverFore = System.Drawing.Color.White;
            this.toolStrip1.ItemAnamorphosis = true;
            this.toolStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.toolStrip1.ItemBorderShow = true;
            this.toolStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.toolStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.toolStrip1.ItemRadius = 4;
            this.toolStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectLabel,
            this.fitLabel,
            this.reLabel,
            this.compareLabel});
            this.toolStrip1.Location = new System.Drawing.Point(4, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.toolStrip1.Size = new System.Drawing.Size(51, 310);
            this.toolStrip1.SkinAllColor = true;
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.TitleAnamorphosis = true;
            this.toolStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.toolStrip1.TitleRadius = 4;
            this.toolStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayForm_FormClosed);
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPanel panel1;
        private System.Windows.Forms.ToolStripLabel selectLabel;
        private System.Windows.Forms.ToolStripLabel fitLabel;
        private System.Windows.Forms.ToolStripLabel reLabel;
        private CCWin.SkinControl.SkinToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel compareLabel;
    }
}