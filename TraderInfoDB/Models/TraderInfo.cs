using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TraderInfoDB.Models
{
    public class TraderInfo
    {
        public string Id { get; set; }
        public int Token { get; set; }
        public int BitCoin { get; set; }
        //public double Token1 { get; set; }
        //public double BitCoin { get; set; }

        //Foreign key to other databases(tabels)?? 
    }
}