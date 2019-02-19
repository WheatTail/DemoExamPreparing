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
    public partial class MS_LoginRole : Form
    {
        public MS_LoginRole()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void RunnerLoginButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_RunnerMenu(), this.Owner);
            this.Close();
            this.Dispose();
        }

        private void ManagerLoginButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_CoordinatorMenu(), this.Owner);
            this.Close();
            this.Dispose();
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_AdminMenu(), this.Owner);
            this.Close();
            this.Dispose();
        }
    }
}
