using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB4
{
    class Program
    {
        static void Main(string[] args)
        {

        //Setup for prosumers 
        void SetupProsumers()
        {
            Random rnd = new Random();
            for (int i = 0; i <33; i++)
            {
                Private.Id = "private" + i;
                Private.ProducedkW = rand.Next(0, 100);
                Private.ConsumedkW = rand.Next(0, 100);
            }

            for (int j = 0; j<12; j++)
            {
                Business.Id = "business" + j;
                Business.ProducedkW = rand.Next(0, 100);
                Business.ConsumedkW = rand.Next(0, 100);
            }                   

            //NSG doesn't consumed anything, produces 100.000 kW pr. day?
            NationalSmartGrid.Id = "NSG";
            NationalSmartGrid.ProducedkW = 100000;
            NationalSmartGrid.ConsumedkW = 0;

            //Add to DB
        }        
        }
    }
}
