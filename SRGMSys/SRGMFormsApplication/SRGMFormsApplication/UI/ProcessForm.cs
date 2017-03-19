﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SRGMFormsApplication.UI
{
    public partial class ProcessForm : Form
    {
        public ProcessForm()
        {
            InitializeComponent();
        }

        public string MessageInfo
        {
            set { this.label1.Text = value; }
        }

        /// <summary>
        /// 设置进度条显示值
        /// </summary>
        public int ProcessValue
        {
            set { this.progressBar1.Value = value; }
        }

        /// <summary>
        /// 设置进度条样式
        /// </summary>
        public ProgressBarStyle ProcessStyle
        {
            set { this.progressBar1.Style = value; }
        }
    }
}
