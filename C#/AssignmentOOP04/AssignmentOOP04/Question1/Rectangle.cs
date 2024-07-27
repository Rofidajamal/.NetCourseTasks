using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Question1
{
    internal class Rectangle : IRectangle
    {
        private double area;
        public double Area
        {
            get
            {
                return area == null ? 0 : area;
            }
            set { area =  Dim01 * Dim02; }
        }

        public double Dim01 { get ; set ; }
        public double Dim02 { get ; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with Area : {Area}");
        }
    }
}
