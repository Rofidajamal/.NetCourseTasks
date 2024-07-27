using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment04.Abstract
{
    //Class that contains a partial implemenatation for another class
    //You cannot create an instance from abstract class because it's not fully implemented 
    internal abstract class Shape
    {
        public Shape (decimal d, decimal d2)
        {
            Dim01 = d;
            Dim01 = d2;
        }
        public abstract decimal Parameter { get; }
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

         public abstract decimal calculateArea();
    }
}
