using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRGMFormsApplication.BLL;
using SRGMFormsApplication.Entity;

namespace SRGMFormsApplication.UI
{
    public partial class ModelForm : Form
    {
        private static ModelForm instance = null;
        static ModelController mc = new ModelController();
        Account account;
        int userType;
        private float X;
        private float Y;

        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    setTag(con);
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytag[0]) * newx;
                con.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * newy;
                con.Height = (int)(a);
                a = Convert.ToSingle(mytag[2]) * newx;
                con.Left = (int)(a);
                a = Convert.ToSingle(mytag[3]) * newy;
                con.Top = (int)(a);
                Single currentSize = Convert.ToSingle(mytag[4]) * Math.Min(newx, newy);
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    setControls(newx, newy, con);
                }
            }
        }
        public Account Account
        {
            get { return account; }
            set { account = value; }
        }
        public int UserType
        {
            get { return userType; }
            set { userType = value; }
        }
        public static ModelForm Instance//单例
        {
            set { }
            get
            {
                if (instance == null)
                {
                    new ModelForm();
                }
                return instance;
            }
        }
        private void ModelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
        public ModelForm()
        {
            InitializeComponent();
            instance = this;
            X = this.Width;
            Y = this.Height;
        }
        private void ModelForm_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(ModelForm_Resize);
            setTag(this);
            if (0 == this.UserType)
            {
                this.label1.Text = "系统模型";
            }
            else
            {
                this.label1.Text = "用户模型";
            }
            updateGridView();
        }
        public void updateGridView()
        {
            modelTypedataGridView.DataSource = mc.getModelType().Tables[0];
            if ("系统模型" == this.label1.Text)
            {
                modeldataGridView.DataSource = mc.getModelsforSystem().Tables[0];
            }
            else if ("用户模型" == this.label1.Text)
            {
                modeldataGridView.DataSource = mc.getModelsforUser(this.Account, this.UserType).Tables[0];
            }
        }
        private void addbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "(*.m)|*.m";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;
                string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(filePath);// 没有扩展名的文件名
                MessageBox.Show("已选择文件:" + filePath, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Model model = new Model();
                model.Name = fileNameWithoutExtension;
                if (null != modeldataGridView.CurrentRow)
                {
                    int row = modeldataGridView.CurrentRow.Index;               
                    model.Type = new ModelType();
                    model.Type.TypeID = int.Parse(modeldataGridView.Rows[row].Cells[1].Value.ToString());
                    if (0 == this.UserType)
                    {
                        mc.addModelstoSystem(model, filePath);
                    }
                    else
                    {
                        mc.addModelsforUser(model, this.Account, this.UserType, filePath);
                    }
                    updateGridView();
                }
            }
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            if (null != modeldataGridView.CurrentRow)
            {
                int row = modeldataGridView.CurrentRow.Index;
                model = mc.getModelByid(modeldataGridView.Rows[row].Cells[0].Value.ToString().Trim());
                if (0 == this.UserType)
                {
                    mc.deleteModelsfromSystem(model);
                }
                else
                {
                    mc.deleteModelsforUser(model, this.Account, this.UserType);
                }
                updateGridView();
            }
        }

        private void ModelForm_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X;
            float newy = this.Height / Y;
            setControls(newx, newy, this);
        }
    }
}
