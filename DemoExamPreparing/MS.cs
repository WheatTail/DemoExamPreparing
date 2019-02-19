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
    public partial class MS : Form
    {
        public MS()
        {
            InitializeComponent();
        }

        private void IWannaKnowledge_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_MoreInfo(), this);
        }

        private void IWannaBeARunnerSponsor_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_SupportARuuner(), this);
        }

        private void MarathonSkills_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_Login(), this);
            //GlobalThingsClass.GoFurther(new MS_AdminMenu(), this);
        }

        private void IWannaBeARunnerButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_RegisterAsRunner(), this);
        }
    }
}
