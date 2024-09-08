using System;
using System.Collections.Generic;
using vehicle_rental_system;

public class VehicleRental
{
    public static void Main(string[] args)
    {
        // יצירת רכבים
        Vehicle Car1 = new Car("123-ABC", "Toyota", "Corolla", 50, "Sedan");
        Vehicle Car2 = new Car("5898927", "Mazda", "MPV", 80, "Sedan");
        Vehicle Truck1 = new Truck("456-DEF", "Ford", "F-150", 80, 1000);

        // יצירת לקוחות
        ICustomer RegularCustomer = new RegularCustomer("Yossef Levi");
        ICustomer CorporateCustomer = new CorporateCustomer("Moshe Cohen", "Tech Corp");

        // הדגמת השכרות רכבים
        RegularCustomer.RentVehicle(Car1, 3);
        CorporateCustomer.RentVehicle(Truck1, 5);
        CorporateCustomer.RentVehicle(Car2, 7);

        // הדפסת רשימת הרכבים שהושכרו
        List<Vehicle> rentedByRegular = RegularCustomer.GetRentedVehicles();
        Console.WriteLine($"\nRented vehicles by {RegularCustomer.GetName()}:");
        foreach (Vehicle v in rentedByRegular)
        {
            Console.WriteLine(v.getMake() + " " + v.getModel());
        }

        List<Vehicle> rentedByCorporate = CorporateCustomer.GetRentedVehicles();
        Console.WriteLine($"\nRented vehicles by {CorporateCustomer.GetName()}:");
        foreach (Vehicle v in rentedByCorporate)
        {
            Console.WriteLine(v.getMake() + " " + v.getModel());
        }
        Console.WriteLine();
    }
}
