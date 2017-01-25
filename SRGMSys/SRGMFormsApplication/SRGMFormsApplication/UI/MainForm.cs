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
    public partial class MainForm : Form
    {
        Account account;
        int userType;
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

        public MainForm()
        {
            InitializeComponent();
        }

    }
}
