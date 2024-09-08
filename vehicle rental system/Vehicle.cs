using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_rental_system
{
    public abstract class Vehicle
    {
        private string LicensePlate;
        private string Make;
        private string Model;
        protected double RentalPrice;
        public Vehicle(string LicensePlate, string Make, string Model, double RentalPrice)
        {
            this.LicensePlate = LicensePlate;
            this.Make = Make;
            this.Model = Model;
            this.RentalPrice = RentalPrice;
        }
        public string getLicensePlate()
        {
            return LicensePlate;
        }
        public string getMake() 
        {
            return Make;
        }
        public string getModel()
        {
            return Model;
        }
        public double getRentalPrice() 
        { 
            return RentalPrice;
        }
        public abstract double CalculateRentalCost(int days);
        
    }
}
