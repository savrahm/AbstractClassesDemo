using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year = "2015";
        public string Make = "Ford";
        public string Model = "Focus";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"Now driving this {Year} {Make} {Model}");
        }
    }
}
