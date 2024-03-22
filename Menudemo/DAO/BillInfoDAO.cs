using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menudemo.CONNECT;
using Menudemo.DTO;

namespace Menudemo.DAO
{
    public class BillInfoDAO
    {
       
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {

            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO() { }
        public List<BillInfo> GetListBillInfo(int Billid)
        {
            List<BillInfo> listBillinfos = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from BillInfo where idBill=" + Billid + "");
            foreach (DataRow row in data.Rows)
            {
                BillInfo billInfo = new BillInfo(row);
                listBillinfos.Add(billInfo);
            }
            return listBillinfos;

        }
       
        public void Insert_UpdateBillinfo(int idBill, int idFood, int count)
    
        {
            
            int Check=   (int)DataProvider.Instance.ExecuteScalar("select count(*)from BillInfo where idFood="+idFood+"and idBill="+idBill+"");
               
            if (Check>0)
            {
                DataTable data = DataProvider.Instance.ExecuteQuery("select * from BillInfo where idFood="+idFood+" and idBill="+idBill+"");
                foreach(DataRow row in data.Rows)
                {
                    int Count = (int)row["count"];
                    int pluscount = count + Count;
                    int id = (int)row["id"];
                    if (pluscount<=0)
                    {
                          DataProvider.Instance.ExecuteNonQuery("delete from Billinfo  where id="+id+"");

                    }
                    
                    DataProvider.Instance.ExecuteNonQuery("Update Billinfo set count =" + pluscount +"where id="+id+"");
                }    
            }
            else
            {
                if(count<=0)
                {
                    return;
                }    
                 DataProvider.Instance.ExecuteNonQuery("insert into BillInfo values("+idBill+","+idFood+","+count+")");

            }



        }
        public int checkBillInfo(int idBill)
        {
            String query = "select * from BillInfo where idBill=" + idBill;
          DataTable data=  DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {


                
                return 1;// có thức ăn trong bill



            }
            return 0;// billinfo rỗng
        }
        public void SwitchBillInfo(int idbillold,int idbillnew)
        {
            string query = "select * from BillInfo where idBill="+idbillold;
            DataTable data= DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                int id = (int)row["id"];
                string query1 = "update BillInfo set idBill="+idbillnew+"where id="+id;
                DataProvider.Instance.ExecuteNonQuery(query1);
            }    
            
        }
        public void Checkavailable(int idbill)
        {
            
            string query = "select * from BillInfo where idBill=" + idbill;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);


            for (int i = 0; i <= data.Rows.Count -2; i++)
            {
                DataRow rowi = data.Rows[i];
                int idFood = (int)rowi["idFood"];
                int count = (int)rowi["count"];
                int idBill = (int)rowi["id"];
                int totalcount = 0;

                for (int j = i+1; j <= data.Rows.Count -1; j++)
                {
                   
                    DataRow rowj = data.Rows[j];
                    int id = (int)rowj["id"];
                    if (idFood == (int)rowj["idFood"])
                    {
                        totalcount = count + (int)rowj["count"];
                        DataProvider.Instance.ExecuteNonQuery("delete from Billinfo where id =" + id);

                    }
                   
                }
                if (totalcount != 0)
                {
                    DataProvider.Instance.ExecuteNonQuery("update BillInfo set count ="+totalcount+" where id ="+ idBill);
                }  
                 

            }
                   
            }
        public DataTable loadBillInfoByIDBill(int idbill)
        {
            string query = " select f.name as N'Tên món',bf.count as N'Số lượng',f.Price as N'Đơn giá' from  Bill as b,BillInfo bf,Food as f where bf.idBill ="+idbill+" and f.id=bf.idFood and b.id=bf.idBill and b.status=1";
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
   
        

   
    }

