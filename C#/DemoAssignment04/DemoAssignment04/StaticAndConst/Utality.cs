using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment04.StaticAndConst
{
    internal class Utality
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static double pi;

       
        public static double PI { get { return pi; }
            set { pi = value; } }
        public Utality( int X, int Y)
        {
            this.X = X;
            this.Y = Y;
            PI = 3.14;

        }

        static Utality()
        {
            pi = 3.14;
        }

        public override string ToString()
        {
            return $"X: {X}   Y: {Y}";
        }

        //Class Member method
        public static double CmToInch (double cm)
        {
            return cm /2.54;
        }

        public static double CalcCircleArea (double R)
        {            return PI * R* R ;
        }

    }
}
