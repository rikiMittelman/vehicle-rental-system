using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace vehicle_rental_system
{
    public class CorporateCustomer:ICustomer
    {
        private string Name;
        private string CompanyName;
        private List<Vehicle> RentedVehicles = new List<Vehicle>();
        private const double DiscountRate = 0.9;
        public CorporateCustomer(string name, string companyName)
        {
            this.Name = name;
            this.CompanyName = companyName;
        }

        public string GetName()
        {
            return Name;
        }

        public void RentVehicle(Vehicle vehicle, int days)
        {
            RentedVehicles.Add(vehicle);
            double discountedCost = vehicle.CalculateRentalCost(days) * DiscountRate;
            Console.WriteLine($"{Name} from {CompanyName} rented {vehicle.getMake()} {vehicle.getModel()} for {days} days. Discounted cost: ${discountedCost}");
        }

        public List<Vehicle> GetRentedVehicles()
        {
            return RentedVehicles;
        }
    }
}
