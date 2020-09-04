using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public bool HasSideCar = true;

        public override void DriveAbstract()
        {
            if(HasSideCar)
            {
                Console.WriteLine("Get in, loser, we're going shopping.");
            }
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Now driving this 1972 Ducati 450 Desmo Racer");
        }
    }
}
