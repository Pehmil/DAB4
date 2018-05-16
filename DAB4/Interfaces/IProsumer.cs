namespace DAB4.Interfaces
{
    public interface IProsumer
    {
        string Id { get; set; }
        int ProducedkW { get; set; }
        int ConsumedkW { get; set; }

        void CalcPower();
    }
}