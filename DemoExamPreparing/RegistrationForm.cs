using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DemoExamPreparing
{
    public partial class RegistrationForm : Form
    {

        private MySqlConnection Con(string Server, string Database, string UID, string Password)
        {
            MySqlConnection Con = new MySqlConnection("SERVER=" + Server + "; port=3306; Database=" + Database + "; UID=" + UID + "; PASSWORD=" + Password + "; Persist Security Info=True;");
            return Con;
        }

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            this.SexSelectComboBox.SelectedItem = "M";
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            int fake;
            Int32.TryParse(this.AgeTextbox.Text, out fake);
            if (this.LoginTextobx.Text!="" && this.PasswordTextbox.Text!="" && (this.PasswordTextbox.Text==this.PasswordRepeatTextbox.Text) && fake > 0)
            {
                MessageBox.Show("Что-то");
                MySqlConnection connection = new MySqlConnection();
                connection = this.Con(this.Owner
            }
            else
            {
                MessageBox.Show("Проверьте введённые данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
    }
}
