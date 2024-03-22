using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menudemo.DTO
{
    public class Menu1
    {
        private string foodname;
        private int count;
        private double price;
        private double totalprice;

        public Menu1(string foodname, int count, double price, double totalprice =0)
        {
            Foodname = foodname;
            Count = count;
            Price = price;
            Totalprice = totalprice;
        }
        public Menu1(DataRow row)
        {
            Foodname = row["name"].ToString();
            Count = (int)row["count"];
            Price = Convert.ToDouble(row["Price"]);
            Totalprice = Convert.ToDouble(row["TotalPrice"]);
        }

        public string Foodname { get => foodname; set => foodname = value; }
        public int Count { get => count; set => count = value; }
        public double Price { get => price; set => price = value; }
        public double Totalprice { get => totalprice; set => totalprice = value; }
    }
}
