using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Question1
{
    internal class Circle : ICircle
    {
        public double Radius { get ; set ;}
        private double area ;
        public double Area {
            get {
                return area == null ? 0 : area;
            }
            set { area= 3.14 * Radius * Radius; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"it's a Circle which area is: {Area} ");
            
        }
    }
}
