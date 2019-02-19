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
    public partial class MS_AdminMenu : Form
    {
        public MS_AdminMenu()
        {
            InitializeComponent();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_UserManagement(), this);
        }

        private void VolunteerButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_VolunteerManagement(), this);
        }

        private void CharityButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_CharitiesList(), this);
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_Inventory(), this);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoBack(this);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.LogOut(this);
        }
    }
}
