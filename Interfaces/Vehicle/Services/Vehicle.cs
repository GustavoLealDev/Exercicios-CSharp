using Course.Services;

namespace Course.Entities
{
    abstract class Vehicle : IVehicle
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Fip { get; set; }
        public Vehicle(string mark, string model, int year, double fip)
        {
            Mark = mark;
            Model = model;
            Year = year;
            Fip = fip;
        }

        public abstract void Details();
    }
}
