using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menudemo.DTO
{
    public class BillInfo
    {

        private int id;
        private int billid;
        private int foodid;
        private int count;

        public BillInfo(int id, int billid, int foodid, int count)
        {
            this.Id = id;
            this.Billid = billid;
            this.Foodid = foodid;
            this.Count = count;
        }
        public BillInfo(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Billid = (int)row["idBill"];
            this.Foodid = (int)row["idFood"];
            this.Count = (int)row["count"];
        }

        public int Id { get => id; set => id = value; }
        public int Billid { get => billid; set => billid = value; }
        public int Foodid { get => foodid; set => foodid = value; }
        public int Count { get => count; set => count = value; }
    }
}
