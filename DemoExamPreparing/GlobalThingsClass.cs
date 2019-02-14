using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
    }
}
