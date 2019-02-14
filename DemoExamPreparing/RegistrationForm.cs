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
                try
                {
                    MySqlConnection connection = new MySqlConnection();
                    connection = GlobalThingsClass.Con(GlobalThingsClass.Server, GlobalThingsClass.Databse, GlobalThingsClass.UID, GlobalThingsClass.Password);
                    MessageBox.Show(GlobalThingsClass.Server + " " + GlobalThingsClass.Databse + " " + GlobalThingsClass.UID + " " + GlobalThingsClass.Password);
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO users(login, password, sex, age) values (\"" + this.LoginTextobx.Text + "\", \"" + this.PasswordTextbox.Text + "\", \"" + this.SexSelectComboBox.Text + "\", " + fake + ")";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новый пользователь добавлен. Логин: " + this.LoginTextobx.Text + ", пол: " + this.SexSelectComboBox.Text + ", возраст: " + fake, "Успешно зарегистрирован", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show("Возможно, такой пользователь уже существует, нарушен синтаксис или сервер перестал отвечать" + Environment.NewLine + "Отладочная информация:" + Environment.NewLine + exception.StackTrace, "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("Проверьте введённые данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
