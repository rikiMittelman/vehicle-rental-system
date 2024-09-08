using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_rental_system
{
    public class Truck: Vehicle
    {
        private int Capacity;
        public Truck(string licensePlate, string make, string model, double rentalPrice,int Capacity) : base(licensePlate, make, model, rentalPrice)
        {
            this.Capacity = Capacity;
        }
        public override double CalculateRentalCost(int days)
        {
            return (RentalPrice + Capacity * 0.5) * days; 
        }
        public int GetCapacity()
        {
            return Capacity;
        }
    }
}
