using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public bool HasSeatBelts = true;

        public override void DriveAbstract()
        {
            if(HasSeatBelts)
            {
                Console.WriteLine("Buckle up");
            }
        }
    }
}
