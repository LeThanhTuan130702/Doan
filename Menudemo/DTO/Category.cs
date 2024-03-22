using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menudemo.DTO
{
    public class Category
    {
        private string name;
        private int id;

        public Category(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public Category(DataRow row)
        {
            Name = row["name"].ToString();
            Id = (int)row["id"];
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
    }
}
