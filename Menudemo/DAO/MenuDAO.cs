using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using Menudemo.CONNECT;
using Menudemo.DTO;

namespace Menudemo.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance 
        {
            get { if (instance == null) instance=new MenuDAO(); return MenuDAO.instance; }
            private set { instance = value; }


        }
        private MenuDAO() { }
        public List<Menu1> GetMenubyTable(int id) 
        {
            List<Menu1> list = new List<Menu1>();
            String query = "select F.name,bi.count,F.Price,F.Price*bi.count as TotalPrice from Bill as b,BillInfo as Bi,Food as F where b.id=Bi.idBill and Bi.idFood=F.id and b.idTable_Food="+id+ "and  b.status=0 and F.active=1";
            DataTable data=DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                Menu1 menu = new Menu1(dr);
                list.Add(menu);
            }
            return list;
        } 
        public bool IsEmpty(int id)
        {
            string query = "select *from Table_Food as t,Bill as b,BillInfo as bf,Food as f where b.idTable_Food=t.id and bf.idBill=b.id and t.id=" + id + " and f.id=bf.idFood and f.active=1";
            DataTable date=new DataTable();
            date=DataProvider.Instance.ExecuteQuery(query);
            
            if(date.Rows.Count<=0)
            {
                return true;
            }
            return false;
        }
    }
}
