using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Admin.Directory.directory_v1.Data;
using Menudemo.CONNECT;
using Menudemo.DTO;

namespace Menudemo.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        { get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        AccountDAO() { }
        
        
        
        public bool login(string username, string password)
        {
            string query = "Select * from dbo.Accountname where username=N'" + username + "'";
            byte[] temp=ASCIIEncoding.ASCII.GetBytes(password);
            byte[] Hasdata=new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach(byte item in Hasdata)
            {
                hasPass += item;
            }    

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            if(data!=null)
            {
                
                foreach (DataRow row in data.Rows)
                {
                    if (username == (string) row["username"] && hasPass.Equals((string)row["password"]))
                    {
                        return true;
                    }
                }



            }
            return false;

        }
        
            
        
        public Account GetAccountbyUsername(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from accountname where username =N'"+username+"'");
            foreach(DataRow row in data.Rows)
            {
                return new Account(row);
            }
            return null;
        }
        public int ChangePassword(string oldpass,string newpass,string username)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(oldpass);
            byte[] Hasdata = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in Hasdata)
            {
                hasPass += item;
            }
            byte[] tempnew = ASCIIEncoding.ASCII.GetBytes(newpass);
            byte[] Hasdatanew = new MD5CryptoServiceProvider().ComputeHash(tempnew);
            string hasPassnew = "";
            foreach (byte item1 in Hasdatanew)
            {
                hasPassnew += item1;
            }
            string query = "update dbo.accountname set password =N'" + hasPassnew + "'where username =N'" + username + "' and password=N'" + hasPass + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int Insert_Staff(string username,string displayname,string password,int Type,int phone,string role)
        {
            string sql = "Insert into accountname  values (N'" + username + "',N'" + displayname + "',N'" + password + "'," + Type + "," + phone + ",N'" + role + "',1)";


            return DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public int Update_Staff(string username, string displayname, string password, int Type, int phone, string role,string usernameold)
        {
            string sql = "update accountname set username= N'" + username + "',Displayname= N'" + displayname + "', password= N'" + password + "',type=" + Type + ",Phone=" + phone + ",Role=N'" + role + "' where username=N'" + usernameold + "'";



            return DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public int Delete_Staff(string username)
        {
            string query="Update accountname set active =0 where username=N'"+username+"'";
            return DataProvider.Instance.ExecuteNonQuery(query);
            
        }
        public DataTable GetStaffList(string text)
        {
            
            string sql = "select [username]\r\n      ,[Displayname]\r\n      ,[password]\r\n      ,[Type]\r\n      ,[Phone]\r\n      ,[Role]\r\n       from accountname where displayname like N'%" + text + "%' and active =1";

            return DataProvider.Instance.ExecuteQuery(sql);
        }




    }
}
