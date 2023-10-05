using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    internal class Inheritance
    {
        public class Vehicle
        {
            public string VinNumber { get; set; }
            public string Manufacturer { get; set; }
            public DateTime ProductionDate { get; set; }
            public string FuelType { get; set; }

            public Vehicle(string vinNumber, string manufacturer, DateTime productionDate, string fuelType)
            {
                this.VinNumber = vinNumber;
                this.Manufacturer = manufacturer;
                this.ProductionDate = productionDate;
                this.FuelType = fuelType;
            }

            public virtual string VehicleInformation()
            {
                //... some code for generating vehicle information
                return $"..."; // Replace with the proper implementation
            }
        }

        public class SportUtilityVehicle : Vehicle
        {
            public string Drivetrain { get; set; }

            public SportUtilityVehicle(string vinNumber, string manufacturer, DateTime productionDate, string fuelType, string drivetrain)
                : base(vinNumber, manufacturer, productionDate, fuelType)
            {
                this.Drivetrain = drivetrain;
            }

            public override string VehicleInformation()
            {
                //... some code for generating vehicle information for SUV
                return $"..."; // Replace with the proper implementation
            }
        }

    }
}
