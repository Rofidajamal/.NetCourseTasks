using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment04.Abstract
{
    internal class Square : Base
    {
        public Square(decimal d): base(d, d)
        {

        }
        public override decimal Parameter {
            get { return Dim01 * 4; }
        }

     
    }
}
