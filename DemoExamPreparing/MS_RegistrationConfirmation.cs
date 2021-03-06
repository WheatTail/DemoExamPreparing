﻿using System;
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
    public partial class MS_RegistrationConfirmation : Form
    {
        public MS_RegistrationConfirmation()
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

        private void ConfirmationBuuton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_RunnerMenu(), this);
        }
    }
}
