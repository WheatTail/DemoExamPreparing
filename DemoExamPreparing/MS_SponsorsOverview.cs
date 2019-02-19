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
    public partial class MS_SponsorsOverview : Form
    {
        public MS_SponsorsOverview()
        {
            InitializeComponent();
        }

        private void SortingButton_Click(object sender, EventArgs e)
        {
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoBack(this);
        }

        private void HeaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void GrayBackgroundLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.LogOut(this);
        }

        private void FooterLabel_Click(object sender, EventArgs e)
        {

        }

        private void GratBackgroundFooterLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
