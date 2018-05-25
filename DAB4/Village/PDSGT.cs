using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB4.Village
{
    class PDSGT
    {
        public int CalcToken()
        {
            return 10;
        }

        public int CalcBTC()
        {
            return 20;
        }

        public void Print(string info)
        {
            Console.WriteLine(info);
        }

        public void CalcTrades()
        {
            //Figure out who sells to who, and who buys from who in the DB
        }
    }
}
