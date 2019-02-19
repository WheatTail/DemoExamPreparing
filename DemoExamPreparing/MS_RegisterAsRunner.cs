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
    public partial class MS_RegisterAsRunner : Form
    {
        public MS_RegisterAsRunner()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoBack(this);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_Login(), this);
        }

        private void IveAlreadyWasHereButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_Login(), this);
        }

        private void IamNewRunnerButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_RegisterAsRunnerData(), this);
        }
    }
}
