using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menudemo.DTO
{
    public class Account
    {
        private string username;
        private string password;
        private string displayname;
        private int Type;
        private int Phone;
        private string role;

        public Account(string username, string password, string displayname, int type1)
        {
            Username = username;
            Password = password;
            Displayname = displayname;
            Type1 = type1;
        }
        public Account(DataRow row)
        {
            this.Username = (string)row["username"];
            this.Password = (string)row["password"];
            this.Displayname = (string)row["Displayname"];
            this.Type = (int)row["type"];
            this.Phone1 = (int)row["Phone"];
            this.Role = (string)row["role"];
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public int Type1 { get => Type; set => Type = value; }
        public int Phone1 { get => Phone; set => Phone = value; }
        public string Role { get => role; set => role = value; }
    }
}
