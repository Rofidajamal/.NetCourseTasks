using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP003.CarIplaneInterface
{
    internal class AirPlan : Vehicle, IMovable, IFlyable

    {
        void IMovable.Backward()
        {
            Console.WriteLine("Airplane moves Backword on ground");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("Airplane moves Backword on Air");
        }

        void IMovable.Forward()
        {
            Console.WriteLine("Airplane moves Forward on ground");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airplane moves Forward on Air");
        }
    }
}
