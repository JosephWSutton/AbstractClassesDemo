using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            var ducatti = new Motorcycle();
            ducatti.Model = "x11";
            ducatti.Year = "2020";
            ducatti.Make = "Duactti";
            ducatti.TopSpeed = "201mph";
            ducatti.HasSidecar = false;

            var gWagon = new Car()
            {
                Year = "2019",
                Model = "G100",
                Make = "Mercedes",
                NumberOfDoors = 4,
                TopSpeed = "145mph"

            };

            Vehicle Indian = new Motorcycle()
            {
                Year = "1980",
                Model = "LightFeather",
                Make = "Indian",
                TopSpeed = "92mph",
                HasSidecar = false

            };

            Vehicle Outback = new Car()
            {
                NumberOfDoors = 4,
                Model = "Outback",
                Make = "Subaru",
                Year = "2018",
                TopSpeed = "113mph"

            };


            vehicles.Add(ducatti);
            vehicles.Add(gWagon);
            vehicles.Add(Indian);
            vehicles.Add(Outback);

            foreach(Vehicle v in vehicles)
            {
                Console.WriteLine($"The {v.Year} {v.Make} {v.Model}");
            }

            Indian.DriveAbstract();
            Indian.DriveVirtual();
            Outback.DriveAbstract();
            Outback.DriveVirtual();

            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
