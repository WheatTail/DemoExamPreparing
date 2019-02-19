using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DemoExamPreparing
{
    static class GlobalThingsClass
    {
        public static string Server;
        public static string Databse;
        public static string UID;
        public static string Password;
        public static MySqlConnection Con(string Server, string Database, string UID, string Password)
        {
            MySqlConnection Con = new MySqlConnection("SERVER=" + Server + "; port=3306; Database=" + Database + "; UID=" + UID + "; PASSWORD=" + Password + "; Persist Security Info=True;");
            return Con;
        }
        public static void GoFurther(Form form, Form owner)
        {
            form.Owner = owner;
            form.Show();
            owner.Hide();
        }
        public static void GoBack(Form form)
        {
            form.Owner.Show();
            form.Close();
        }
        public static void LogOut(Form form)
        {
            if (form.Owner != null)
            {
                LogOut(form.Owner);
                form.Owner = null;
                form.Close();
                form.Dispose();                
            }
            else
            {
                form.Show();
            }
        }
    }
}