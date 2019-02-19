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
    public partial class MS_RegisterAsRunnerData : Form
    {
        public MS_RegisterAsRunnerData()
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
    }
}
