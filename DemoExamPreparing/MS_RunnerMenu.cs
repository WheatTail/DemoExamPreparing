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
    public partial class MS_RunnerMenu : Form
    {
        public MS_RunnerMenu()
        {
            InitializeComponent();
        }

        private void EditInfoButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_EditProfile(), this);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoBack(this);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.LogOut(this);
        }

        private void ContactsButton_Click(object sender, EventArgs e)
        {
            MS_Contacts _Contacts = new MS_Contacts();
            _Contacts.Owner = this;
            _Contacts.Show();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_RegisterForAnEvent(), this);
        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_MyResults(), this);
        }

        private void SponsorButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_MySponsors(), this);
        }
    }
}
