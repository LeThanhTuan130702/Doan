using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menudemo.CONNECT;
using Menudemo.DTO;

namespace Menudemo.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillDAO(); { return BillDAO.instance; }


            }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }

        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data= DataProvider.Instance.ExecuteQuery("Select * from Bill where idTable_Food ="+ id + "and status=0");
            if(data.Rows.Count > 0)
            {
                    
                   
                   Bill bill = new Bill(data.Rows[0]);
                   return bill.Id;
                
               

            }
            return -1;
        }
        public void insertBill(int id)
        {
            int rs = DataProvider.Instance.ExecuteNonQuery("insert into Bill values(GETDATE(),null,"+id+",0,0,0)");


        }
        public int GetMaxid()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select MAX(id) from Bill");
            }
            catch
            {
                return 1;
            }

        }
        public void Checkout(int id,int discount,float totalprice)
        {
            string query = "Update Bill set status =1,DateCheckOut=GETDATE(),discount=" + discount + ",totalprice="+totalprice+" where id="+id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public DataTable ListBill(DateTime CheckIn,DateTime CheckOut,TextBox text )
            
        {
            string query = "select b.id as N'Số hóa đơn',t.name as N'Tên Bàn ',b.DateCheckIN as N'Ngày vào' ,b.DateCheckOut as N'Ngày ra',b.discount as N'Giảm giá' ,b.totalprice as N'Tổng tiền' from Bill as b,Table_Food as t\r\nwhere b.status=1 and t.id=b.idTable_Food and DateCheckIN>='" + CheckIn+"' and DateCheckOut<='"+CheckOut+"'and t.name like N'%"+text.Text+"%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }


    }
}
