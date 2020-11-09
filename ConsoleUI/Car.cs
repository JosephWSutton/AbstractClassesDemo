using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
           
        }
        public int NumberOfDoors { get; set; }
        public string TopSpeed { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("Car go vroom");
        }
    }
}
