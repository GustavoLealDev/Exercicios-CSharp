using System.Globalization;

namespace Course.Entities
{
     class Cars : Vehicle
    {
        public Cars(string brand, string model, int year, double fip) : base(brand, model, year, fip) { }
        public override void Details()
        {
            Console.WriteLine($"Car: {Brand} | Model: {Model} | Year: {Year} | Value: {Fip.ToString("F3")}");
        }
    }
}
