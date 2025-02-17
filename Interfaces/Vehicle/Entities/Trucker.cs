using System.Globalization;

namespace Course.Entities
{
    class Trucker : Vehicle
    {
        public Trucker(string mark, string model, int year, double fip) : base(mark, model, year, fip) { }
        public override void Details()
        {
            Console.WriteLine($"Car: {Mark} | Model: {Model} | Year: {Year} | Value: {Fip.ToString("F3")}");
        }
    }
}