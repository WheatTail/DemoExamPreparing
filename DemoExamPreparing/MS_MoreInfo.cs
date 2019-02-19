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
    public partial class MS_MoreInfo : Form
    {
        public MS_MoreInfo()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoBack(this);
        }

        private void MarathonInfoButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_MarathonInfo(), this);
        }

        private void MarathonDurationButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_HowLongIsMarathon(), this);
        }

        private void PreviousResultsButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_PreviousResult(), this);
        }

        private void CharitiesListButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_CharitiesList(), this);
        }

        private void BMICalculatorButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_BMICalculator(), this);
        }

        private void BMRCalculatorButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_BMRCalculator(), this);
        }
    }
}
