using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_rental_system
{
    public interface ICustomer
    {
        string GetName();
        void RentVehicle(Vehicle vehicle, int days);
        List<Vehicle> GetRentedVehicles();
    }
}
