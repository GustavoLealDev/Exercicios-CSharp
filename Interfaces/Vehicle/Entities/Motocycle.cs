using System.Globalization;

namespace Course.Entities
{
    class Motocycle : Vehicle
    {
        public Motocycle(string brand, string model, int year, double fip) : base(brand, model, year, fip) { }
        public override void Details()
        {
            Console.WriteLine($"Motocycle: {Brand} | Model: {Model} | Year: {Year} | Value: {Fip.ToString("F3")}");
        }
    }
}