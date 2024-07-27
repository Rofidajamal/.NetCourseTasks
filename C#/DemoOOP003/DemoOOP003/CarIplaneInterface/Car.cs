using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP003.CarIplaneInterface
{
    internal class Car : Vehicle, IMovable
    {
        public void Backward()
        {
            Console.WriteLine("Car moves Backword");
        }

        public void Forward()
        {
            Console.WriteLine("Car moves Forward");

        }
    }
}
