using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            
        }
        public bool HasSidecar { get; set; }
        public string TopSpeed { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Moto Gogo");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Moto Gogo virtual style");
        }
    }
}
