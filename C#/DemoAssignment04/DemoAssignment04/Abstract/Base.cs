using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment04.Abstract
{
    abstract class Base: Shape
    {
        protected Base(decimal d, decimal d2) : base(d, d2)
        {
        }

        public override decimal calculateArea()
        {
            return Dim01 * Dim02;
        }
    }
}
