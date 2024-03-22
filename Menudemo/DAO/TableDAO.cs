using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Menudemo.CONNECT;
using Menudemo.DTO;

namespace Menudemo.DAO
{
   
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set { instance = value; }
        }
        public static int TableWidth = 100;
        public static int TableHeight = 100;

        TableDAO() { }
        public List<DTO.Table> LoadTableList()
        {
            List<DTO.Table> table_list = new List<DTO.Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("  Select * From Table_Food  where active=1 Order By id");
            foreach (DataRow row in data.Rows)
            {
                
                int id = (int)(row["id"]);
                string status = row["status"].ToString();
                string name = row["name"].ToString();
                DTO.Table table = new DTO.Table(id,name,status);
                table_list.Add(table);
            }
            return table_list;
        }
        public void checkin(int idtable,int idBill)
        {
            int rs= BillInfoDAO.Instance.checkBillInfo(idBill);
            if(rs==1)
            {
                string query = " update Table_Food set status =N'Có người' where id= " + idtable;
                DataProvider.Instance.ExecuteQuery(query);
            }
            else
            {
                string query = " update Table_Food set status =N'Trống' where id= " + idtable;
                DataProvider.Instance.ExecuteQuery(query);
            }    
           
        }
        public void checkout(int idtable)
        {
            string query = " update Table_Food set status =N'Trống' where id= " + idtable;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public int Insert_Table(string table_name)
        {
            string sql = "Insert into Table_Food (name ,active) values (N'" + table_name + "',1)";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public int Update_Table(string table_name,int Tableid)
        {
            string sql = "update Table_Food set name= N'" + table_name + "' where id=" + Tableid + "";

            return DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public int Delete_Table(int idtable)
        {
            string sql = "update Table_Food set active=0 where id=" + idtable + "";

            return DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public DataTable GetTableList(string text)
        {
            
            string sql = "select id,name  from Table_Food where name like N'%" + text + "%' and active =1 ";
            return DataProvider.Instance.ExecuteQuery(sql);


        }
        public DataTable checkavai(string tablename)
        {
            string query = "select * from Table_Food where name =N'" + tablename + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public int ReUpTable(string tablename)
        {
            string query= "update Table_Food set active= 1 where  name=N'" + tablename + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
