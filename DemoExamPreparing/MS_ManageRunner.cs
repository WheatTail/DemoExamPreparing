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
    public partial class MS_ManageRunner : Form
    {
        public MS_ManageRunner()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoBack(this);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.LogOut(this);
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_RunnerEdit(), this);
        }

        private void CertificateButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_Certificate(), this);
        }

        private void PrintBadgeButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_Certificate(), this);//??
        }
    }
}
