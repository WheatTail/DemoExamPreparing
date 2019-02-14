﻿using System;
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
    public partial class LoginForm : Form
    {
        SettingsMangaer settings = new SettingsMangaer();
        
        public string Server;
        public string Databse;
        public string UID;
        public string Password;      

        private MySqlConnection Con(string Server, string Database, string UID, string Password)
        {
            MySqlConnection Con = new MySqlConnection("SERVER=" + Server + "; port=3306; Database=" + Database + "; UID=" + UID + "; PASSWORD=" + Password + "; Persist Security Info=True;");
            return Con;
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            settings.ReadSettingsFromXML();
            this.ServerSettingTextbox.Text = settings.Fields.Server;
            this.DatabaseSettingsTextbox.Text = settings.Fields.Database;
            this.UIDSettingsTextbox.Text = settings.Fields.UID;
            this.PasswordSettingsTextbox.Text = settings.Fields.Password;
            GlobalThingsClass.Server = settings.Fields.Server;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!SettingsCheckBox.Checked)
            {
                Server = settings.Fields.Server;
                Databse = settings.Fields.Database;
                UID = settings.Fields.UID;
                Password = settings.Fields.Password;

                try
                {
                    MySqlConnection connection = new MySqlConnection();
                    connection = Con(Server, Databse, UID, Password);
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM USERS WHERE Login='" + this.LoginTextbox.Text + "' AND Password='" + this.PasswordTextbox.Text + "'";
                    int rows = int.Parse(command.ExecuteScalar().ToString());
                    if (rows > 0){
                        MessageBox.Show("Вы зашли как " + this.LoginTextbox.Text + " на сервер " + Server, "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        this.Owner.Enabled = true;
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден или пароль неверен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        connection.Close();
                    }
                    //MessageBox.Show("Connected to " + Server + " successfully");
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show(exception.StackTrace);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }


            }
            else
            {
                Server = this.ServerSettingTextbox.Text;
                Databse = this.DatabaseSettingsTextbox.Text;
                UID = this.UIDSettingsTextbox.Text;
                Password = this.PasswordSettingsTextbox.Text;

                try
                {
                    MySqlConnection connection = new MySqlConnection();
                    connection = Con(Server, Databse, UID, Password);
                    connection.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM USERS WHERE Login='" + this.LoginTextbox.Text + "' AND Password='" + this.PasswordTextbox.Text + "'";
                    int rows = int.Parse(command.ExecuteScalar().ToString());
                    if (rows > 0)
                    {
                        MessageBox.Show("Вы зашли как " + this.LoginTextbox.Text + " на сервер " + Server, "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        this.Owner.Enabled = true;
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден или пароль неверен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        connection.Close();
                    }
                    //MessageBox.Show("Connected to " + Server + " successfully");
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show(exception.StackTrace);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }

            if (SaveSettingsCheckBox.Checked)
            {
                settings.Fields.Server = this.ServerSettingTextbox.Text;
                settings.Fields.Database = this.DatabaseSettingsTextbox.Text;
                settings.Fields.UID = this.UIDSettingsTextbox.Text;
                settings.Fields.Password = this.PasswordSettingsTextbox.Text;
                settings.WriteSettingsToXML();
            }
        }

        private void SettingsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SettingsCheckBox.Checked)
            {
                this.Height = 375;
                this.ServerSettingsLabel.Visible = true;
                this.ServerSettingTextbox.Visible = true;
                this.DatabaseSettingsLabel.Visible = true;
                this.DatabaseSettingsTextbox.Visible = true;
                this.UIDSettingsLabel.Visible = true;
                this.UIDSettingsTextbox.Visible = true;
                this.PasswordSettingsLabel.Visible = true;
                this.PasswordSettingsTextbox.Visible = true;
                this.SaveSettingsCheckBox.Visible = true;
            }
            else
            {
                this.Height = 250;
                this.ServerSettingsLabel.Visible = false;
                this.ServerSettingTextbox.Visible = false;
                this.DatabaseSettingsLabel.Visible = false;
                this.DatabaseSettingsTextbox.Visible = false;
                this.UIDSettingsLabel.Visible = false;
                this.UIDSettingsTextbox.IsAccessible = false;
                this.PasswordSettingsLabel.Visible = false;
                this.PasswordSettingsTextbox.Visible = false;
                this.SaveSettingsCheckBox.Visible = false;
                this.SaveSettingsCheckBox.Checked = false;
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Owner = this;
            registrationForm.Show();
            this.Hide();            
        }
    }
}