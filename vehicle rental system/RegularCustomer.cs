using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_rental_system
{
    public class RegularCustomer:ICustomer
    {
        private string Name;
        private List<Vehicle> RentedVehicles = new List<Vehicle>();

        public RegularCustomer(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void RentVehicle(Vehicle vehicle, int days)
        {
            RentedVehicles.Add(vehicle);
            Console.WriteLine($"{Name}  rented {vehicle.getMake()} {vehicle.getModel()} for {days} days.  cost: ${vehicle.CalculateRentalCost(days)} ₪");

        }

        public List<Vehicle> GetRentedVehicles()
        {
            return RentedVehicles;
        }
    }

}

