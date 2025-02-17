using Course.Services;

namespace Course.Entities
{
    class Stock
    {
        private List<IVehicle> vehicles;

        public Stock()
        {
            vehicles = new List<IVehicle>();
        }

        public void AddVehicle(IVehicle vehicle)
        {
            vehicles.Add(vehicle);
            Console.WriteLine("vehicle added successfully");
        }

        public void RemoveVehicle(string model)
        {
            IVehicle vehicle = vehicles.FirstOrDefault(x => x != null);
            if (vehicles != null)
            {
                vehicles.Remove(vehicle);
                Console.WriteLine("vehicle removed successfully");
            }
            else
            {
                Console.WriteLine("Vehicle not found!");
            }
        }

        public void ListVehicle()
        {
            if (vehicles.Count > 0)
            {
                Console.WriteLine("List of Vehicle: ");
                foreach (Vehicle vehicle in vehicles)
                {
                    vehicle.Details();
                }
            }
            else
            {
                Console.WriteLine("Empty stock.");
            }
        }
    }
}
