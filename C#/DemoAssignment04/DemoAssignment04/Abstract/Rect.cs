using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment04.Abstract
{
    //Concrete Class
    internal class Rect : Base
    {
        public Rect(decimal d, decimal d2) : base(d, d2)
        {
        }

        public override decimal Parameter { 
            get { return (Dim01 + Dim02) * 2; } 
        }


    }
}
