using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;

namespace SRGMFormsApplication.UI
{
    public partial class Print : Form
    {
        private PrintPreviewDialog PrintPreview = new PrintPreviewDialog();
        private string StreamType;
        private Image image = null;
        private Stream StreamToPrint = null;
        Font mainFont = new Font("宋体", 12);//打印的字体  
        public string Filename = null;
        public static int i = 0;

        //1、实例化打印文档  
        PrintDocument pdDocument = new PrintDocument();
        private string[] lines;
        private PrintPreviewControl printPreviewControl1;

        public Print()
        {
            InitializeComponent();
        }
        private int linesPrinted;

        public Print(string filepath, string filetype)
            : this()
        {
            Filename = Path.GetFileNameWithoutExtension(filepath);

            //订阅BeginPrint事件  
            pdDocument.BeginPrint += new PrintEventHandler(pdDocument_BeginPrint);

            //订阅Print打印事件,该方法必须放在订阅打印事件的最后  
            pdDocument.PrintPage += new PrintPageEventHandler(OnPrintPage);

            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            StartPrint(fs, filetype);

            //打印结束  
            //訂閱EndPrint事件，释放资源 
            pdDocument.EndPrint += new PrintEventHandler(pdDocument_EndPrint);
        }
        //2、启动Print打印方法  
        public void StartPrint(Stream streamToPrint, string streamType)
        {
            //声明返回值的PageSettings A4/A5  
            PageSettings ps = new PageSettings();

            //显示设置打印页对话框  
            PageSetupDialog Psdl = new PageSetupDialog();

            //打印多页设置  
            PrintDialog pt = new PrintDialog();
            pt.AllowCurrentPage = true;
            pt.AllowSomePages = true;
            pt.AllowPrintToFile = true;

            printPreviewControl1.Document = pdDocument;//form中的打印预览  
            printPreviewControl1.Zoom = 1.0;
            printPreviewControl1.Dock = DockStyle.Fill;
            printPreviewControl1.UseAntiAlias = true;

            StreamToPrint = streamToPrint;//打印的字节流  
            StreamType = streamType; //打印的类型  
            pdDocument.DocumentName = Filename; //打印的文件名  

            Psdl.Document = pdDocument;
            PrintPreview.Document = pdDocument;
            PrintPreview.SetDesktopLocation(300, 800);
            Psdl.PageSettings = pdDocument.DefaultPageSettings;
            pt.Document = pdDocument;

            try
            {
                //显示对话框  

                if (Psdl.ShowDialog() == DialogResult.OK)
                {
                    ps = Psdl.PageSettings;
                    pdDocument.DefaultPageSettings = Psdl.PageSettings;
                }

                if (pt.ShowDialog() == DialogResult.OK)
                {
                    pdDocument.PrinterSettings.Copies = pt.PrinterSettings.Copies;
                }


                if (PrintPreview.ShowDialog() == DialogResult.OK)
                    //调用打印  
                    pdDocument.Print();


                // PrintDocument对象的Print()方法在PrintController类中执行PrintPage事件。  
                //  
            }
            catch (InvalidPrinterException ex)
            {
                MessageBox.Show(ex.Message, "Simple Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>  
        /// 3、得到打印內容  
        /// 每个打印任务只调用OnBeginPrint()一次。  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        void pdDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            char[] param = { '\n' };
            char[] trimParam = { '\r' };//回车  

            switch (StreamType)
            {
                case "txt":
                    StringBuilder text = new StringBuilder();
                    System.IO.StreamReader streamReader = new StreamReader(StreamToPrint, Encoding.Default);
                    while (streamReader.Peek() >= 0)
                    {
                        lines = streamReader.ReadToEnd().Split(param);
                        for (int i = 0; i < lines.Length; i++)
                        {
                            lines[i] = lines[i].TrimEnd(trimParam);
                        }
                    }
                    break;
                case "image":
                    image = System.Drawing.Image.FromStream(StreamToPrint);
                    break;
                default:
                    break;
            }
        }
        /// <summary>  
        /// 4、绘制多个打印界面  
        /// printDocument的PrintPage事件  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        private void OnPrintPage(object sender, PrintPageEventArgs e)
        {
            int leftMargin = Convert.ToInt32((e.MarginBounds.Left) * 3 / 4);　 //左边距  
            int topMargin = Convert.ToInt32(e.MarginBounds.Top * 2 / 3);　　　 //顶边距  
            switch (StreamType)
            {
                case "txt":
                    while (linesPrinted < lines.Length)
                    {
                        //向画布中填写内容  
                        e.Graphics.DrawString(lines[linesPrinted++], new Font("Arial", 10), Brushes.Black, leftMargin, topMargin, new StringFormat());

                        topMargin += 55;//行高（一行字的高度）为55，可调整  

                        //走纸换页  
                        if (topMargin >= e.PageBounds.Height - 60)//页面累加的高度大于页面高度。根据自己需要，可以适当调整  
                        {
                            //如果大于设定的高  
                            e.HasMorePages = true;
                            printPreviewControl1.Rows += 1;//窗体的打印预览窗口页面自动加1  
                            /* 
                            * PrintPageEventArgs类的HaeMorePages属性为True时，通知控件器，必须再次調用OnPrintPage()方法，打印一个页面。 
                            * PrintLoopI()有一个用於每个要打印的页面的序例。如果HasMorePages是False，PrintLoop()就会停止。 
                            */
                            return;
                        }
                    }
                    break;

                case "image"://以下涉及剪切图片,  
                    int width = image.Width;
                    int height = image.Height;
                    if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
                    {
                        width = e.MarginBounds.Width;
                        height = image.Height * e.MarginBounds.Width / image.Width;
                    }
                    else
                    {
                        height = e.MarginBounds.Height;
                        width = image.Width * e.MarginBounds.Height / image.Height;
                    }

                    System.Drawing.Rectangle destRect = new System.Drawing.Rectangle(topMargin, leftMargin, width, height);
                    //向画布写入图片  
                    for (; i < Convert.ToInt32(Math.Floor((double)image.Height / 820)) + 1; i++)
                    {
                        e.Graphics.DrawImage(image, destRect, i * 820, i * 1170, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
                        //e.Graphics.DrawImage(image, 35, 35);
                        
                        //走纸换页  
                        if (i * 1170 >= e.PageBounds.Height - 60)//页面累加的高度大于页面高度。根据自己需要，可以适当调整  
                        {
                            //如果大于设定的高  
                            e.HasMorePages = true;
                            printPreviewControl1.Rows += 1;//窗体的打印预览窗口页面自动加1  
                            /* 
                            * PrintPageEventArgs类的HaeMorePages属性为True时，通知控件器，必须再次調用OnPrintPage()方法，打印一个页面。 
                            * PrintLoopI()有一个用於每个要打印的页面的序例。如果HasMorePages是False，PrintLoop()就会停止。 
                            */
                            i += 1;
                            //System.Diagnostics.Debug.WriteLine("aaaa"+i);
                            return;
                        }
                    }
                    break;
            }
            //打印完毕后，画线条，且注明打印日期  
            e.Graphics.DrawLine(new Pen(Color.Black), leftMargin, topMargin, e.MarginBounds.Right, topMargin);

            string strdatetime = DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString();
            e.Graphics.DrawString(string.Format("打印时间：{0}", strdatetime), mainFont, Brushes.Black, e.MarginBounds.Right - 240, topMargin + 40, new StringFormat());
            linesPrinted = 0;
            //绘制完成后，关闭多页打印功能  
            e.HasMorePages = false;
        }


        /// <summary>    
        ///5、EndPrint事件,释放资源  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        void pdDocument_EndPrint(object sender, PrintEventArgs e)
        {
            //变量Lines占用和引用的字符串数组，现在释放  
            lines = null;
        }

        private void InitializeComponent()
        {
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.SuspendLayout();
            //   
            // printPreviewControl1  
            //   
            this.printPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl1.Location = new System.Drawing.Point(12, 3);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(685, 511);
            this.printPreviewControl1.TabIndex = 0;
            //   
            // Print
            //   
            this.ClientSize = new System.Drawing.Size(696, 526);
            this.Controls.Add(this.printPreviewControl1);
            this.Name = "Print";
            this.ResumeLayout(false);
        }
    }
}
