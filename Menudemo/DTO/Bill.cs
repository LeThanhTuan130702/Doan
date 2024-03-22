using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menudemo.DTO
{
    public class Bill
    {
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int id;
        private int status;
        private int disscout;

        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Id { get => id; set => id = value; }
        public int Status { get => status; set => status = value; }
        public int Disscout { get => disscout; set => disscout = value; }

        public Bill(int id,DateTime? dateCheckIn, DateTime? dateCheckOut,  int status,int disscount)
        {
            this.DateCheckIn = dateCheckIn;
           this.DateCheckOut = dateCheckOut;
            this.Id = id;
            this.Status = status;
            this.Disscout = disscount;
        }
        public Bill(DataRow row) 
        {
            this.Id = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["DateCheckin"];
            var DateCheckOutTemp = row["DateCheckOut"];
            if(DateCheckOutTemp.ToString()!= "") {
            this.DateCheckOut = (DateTime?)DateCheckOutTemp;
            }
            this.Status = (int)row["status"];
            this.Disscout = (int)row["discount"];
        
        }
       
    }
}
