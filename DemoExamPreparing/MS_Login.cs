using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExamPreparing
{
    public partial class MS_Login : Form
    {
        public MS_Login()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoBack(this);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoBack(this);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (GlobalThingsClass.TestApplication)
            {
                MS_LoginRole _LoginRole = new MS_LoginRole();
                _LoginRole.Owner = this;
                _LoginRole.Show();
            }

        }
    }
}
