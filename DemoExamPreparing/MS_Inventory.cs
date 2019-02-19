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
    public partial class MS_Inventory : Form
    {
        public MS_Inventory()
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

        private void InventoryReportButton_Click(object sender, EventArgs e)
        {
            MS_Report _Report = new MS_Report();
            _Report.Owner = this;
            _Report.Show();
        }

        private void InventoryIncomingButton_Click(object sender, EventArgs e)
        {
            GlobalThingsClass.GoFurther(new MS_InventoryIncoming(), this);
        }
    }
}
