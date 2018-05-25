using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DAB4.Village;


namespace ProsumerDB.Models
{
    public class Prosumer
    {
        public int Id { get; set; }

        public int ProducedkW { get; set; }
        public int ConsumedkW { get; }

        [Required]
        public string Type { get; set; }
    }
}