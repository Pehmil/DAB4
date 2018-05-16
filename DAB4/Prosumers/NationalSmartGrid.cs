using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAB4.Interfaces;

namespace DAB4.Prosumers
{
    class NationalSmartGrid : IProsumer
    {
        public string Id { get; set; }
        public int ProducedkW { get; set; }
        public int ConsumedkW { get; set; }

        public void CalcPower()
        {

        }
    }
}
