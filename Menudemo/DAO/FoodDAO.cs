using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Menudemo.CONNECT;
using Menudemo.DTO;
using Microsoft.Isam.Esent.Interop.Vista;

namespace Menudemo.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return instance; }
            private set { instance = value; }
        }
        public static int TableWidth = 100;
        public static int TableHeight = 100;

        FoodDAO() { }
        public List<Food> GetFoodByCategory(int id) {
            List<Food> list = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from food where idCate=" + id + " and active =1");
            foreach (DataRow row in data.Rows)
            {
                Food food = new Food(row);
                list.Add(food);
            }
            return list;
        }
        public int Insert_Food(string MaHang, string TenHang, int quantity, float GiaBan, float GiaNhap, string anh, string note, string MaNCC, string NguonGoc)
        {
            string sql = "insert into HangHoa values(N'" + MaHang + "',N'" + TenHang + "'," + quantity + ","+GiaBan+","+GiaNhap+",N'"+anh+"',N'"+note+"',N'"+MaNCC+"',N'"+NguonGoc+"',1)";

            return DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public int Update_Food(string MaHang, string TenHang, int quantity, float GiaBan, float GiaNhap, string anh, string note, string MaNCC, string NguonGoc)
        {
            string sql = "update HangHoa set MaHang= N'" + MaHang + "',TenHang=N'" + TenHang + "',SoLuong=" + quantity + ",GiaBan=" + GiaBan + ",GiaNhap=" + GiaNhap + ",Anh=N'" + anh + "',GhiChu=N'" + note + "',MaNCC=N'" + MaNCC + "',NguonGoc=N'" + NguonGoc + "')";
            


            return DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public int Delete_Food(string MaHang)
        {
            string sql = "Update HangHoa set active = 0 where MaHang=N'" + MaHang + "'";
            return DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public DataTable GetFoodList(string textchange)
        {
            return DataProvider.Instance.ExecuteQuery("select * from HangHoa where MaHang like N'%" + textchange + "%'and  active =1 ");
        }


    }
}
