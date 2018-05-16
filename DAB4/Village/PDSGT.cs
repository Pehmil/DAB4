using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB4.Village
{
    class PDSGT
    {
        /// <summary>
        /// Prosumer DB, implemented as lists before the DB is connected
        /// Most likeledy implemented as SQL DB later
        /// Is supposed to mimick one row in the DB
        /// </summary>
        private List<int> consumed = new List<int>();
        private List<int> produced = new List<int>();
        private List<int> id = new List<int>();

        /// <summary>
        /// Trader DB Info, implemented as lists before the DB is connected
        /// Most likely implemented as SQL DB later
        /// Is supposed to mimick one row in the DB
        /// </summary>
        private List<int> prosumerID = new List<int>();
        private List<int> consumedAmount = new List<int>();
        private List<int> producedAmount = new List<int>();
        private List<int> difference = new List<int>();
        private List<int> tradedWith = new List<int>();
        private List<int> tradedAmount = new List<int>();

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
