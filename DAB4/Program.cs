using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAB4.Prosumers;

namespace DAB4
{
    class Program
    {
        static void Main(string[] args)
        {

        // set up prosumers
        void SetupProsumers()
        {
            Random rnd = new Random();
            for (int i = 0; i <33; i++)
            {
                Prosumer privateProsumer = new Prosumer(i, "Private");
                privateProsumer.ConsumedkW = rnd.Next(0, 100);
                privateProsumer.ProducedkW = rnd.Next(0, 100);
            }

            for (int j = 33; j<45; j++)
            {
                Prosumer businessProsumer = new Prosumer(j, "Business");
                businessProsumer.ConsumedkW = rnd.Next(0, 500);
                businessProsumer.ProducedkW = rnd.Next(0, 500);

            }

            Prosumer nationalProsumer = new Prosumer(45, "National power grid");
            //should be whatever is leftover from the prosumers
            nationalProsumer.ConsumedkW = 0;

            //should be whatever the prosumers need
            nationalProsumer.ProducedkW = 0;
        }        

        }
    }
}
