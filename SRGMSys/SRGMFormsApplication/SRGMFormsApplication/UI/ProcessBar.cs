using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SRGMFormsApplication.UI
{
    public partial class ProcessBar : Form
    {
        public ProcessBar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 进度条方法
        /// </summary>
        /// <param name="nValue">进度条递增的值</param>
        /// <returns></returns>
        public bool Increase(int nValue)
        {
            if (nValue > 0)
            {
                if (this.progressBar1.Value + nValue < progressBar1.Maximum)
                {
                    progressBar1.Value += nValue;
                    return true;
                }
                else
                {
                    progressBar1.Value = progressBar1.Maximum;//默认值为100
                    this.Close();
                    return false;
                }
            }
            return false;
        }
    }
}
