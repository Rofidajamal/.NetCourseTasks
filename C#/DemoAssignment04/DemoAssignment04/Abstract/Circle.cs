using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment04.Abstract
{
    internal class Circle : Shape
    {
        public Circle(decimal radius): base(radius, radius)
        {
            

        }
        public override decimal Parameter { get{ return Dim01 * 2 * 3.14m; } }

        public override decimal calculateArea()
        {
            return 3.14m * Dim01* Dim02;
        }
    }
}
