using Course.Services;

namespace Course.Entities
{
    abstract class Vehicle : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Fip { get; set; }
        public Vehicle(string brand, string model, int year, double fip)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Fip = fip;
        }

        public abstract void Details();
    }
}
