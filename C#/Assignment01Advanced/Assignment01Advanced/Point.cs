using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced
{
    internal class Point: IComparable <Point>
    {
        int X { get; set; }
        int Y { get; set; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y; 
        }

        public override string ToString()
        {
            return $"X: {X}   Y: {Y}";
        }


        public int CompareTo(Point? other)
        {
            if (other == null) return -1;
            if (other.X == this.X)
                return (other.Y > this.Y) ? 1 : 0;
            else if (other.Y == this.Y)
            {
                return (other.X > this.X) ? 1 : 0;
            }
            else
                return 0;
        }
    }
}
