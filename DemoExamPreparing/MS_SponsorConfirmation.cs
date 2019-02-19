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
    public partial class MS_SponsorConfirmation : Form
    {
        public MS_SponsorConfirmation()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoBack(this);
        }

        private void GoBack2Button_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoBack(this);
        }
    }
}
