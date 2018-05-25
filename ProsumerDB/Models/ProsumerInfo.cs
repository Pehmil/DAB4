using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProsumerDB.Models
{
    public class ProsumerInfo
    {
        public int Id { get; set; }

        public int ProducedkW { get; set; }
        public int ConsumedkW { get; set; }

        [Required]
        public string Type { get; set; }
    }
}