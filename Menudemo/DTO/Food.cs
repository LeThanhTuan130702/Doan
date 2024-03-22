using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menudemo.DTO
{
    public class Food
    {
        private int id;
        private string name;
        private int idCate;
        private float price;
      

        public Food(int id, string name, int idCate, string price)
        {
            Id = id;
            Name = name;
            IdCate = idCate;
            this.Price = Price;
           
        }
        public Food(DataRow row)
        {
            Id = (int)row["id"];
            Name = row["name"].ToString();
            IdCate = (int)row["idCate"];
            this.Price = (float)Convert.ToDouble(row["Price"]);
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int IdCate { get => idCate; set => idCate = value; }
        public float Price { get => price; set => price = value; }
       
    }
}
