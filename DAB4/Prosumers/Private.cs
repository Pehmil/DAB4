using DAB4.Interfaces;

namespace DAB4.Prosumers
{
    class Private : IProsumer
    {
        public string Id { get; set; }
        public int ProducedkW { get; set; }
        public int ConsumedkW { get; set; }

        public void CalcPower()
        {

        }

        
    }
}
