﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menudemo.DTO
{
   public  class Table
    {
        private int id;
        private string name;
        private string status;
        private int active;
        public Table(int id, string name, string status)
        {
            this.id = id;   
            this.name = name;
            this.status = status;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public int Active { get => active; set => active = value; }
    }
}
