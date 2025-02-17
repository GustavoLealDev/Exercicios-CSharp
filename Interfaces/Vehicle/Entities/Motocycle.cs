using System.Globalization;

namespace Course.Entities
{
    class Motocycle : Vehicle
    {
        public Motocycle(string mark, string model, int year, double fip) : base(mark, model, year, fip) { }
        public override void Details()
        {
            Console.WriteLine($"Motocycle: {Mark} | Model: {Model} | Year: {Year} | Value: {Fip.ToString("F3")}");
        }
    }
}