using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP003.Project2
{
    //Q1
    internal class _3DPoints: IComparable<_3DPoints>, ICloneable
    {
        // 1.	Define 3D Point Class and the basic Constructors (use chaining in constructors).

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

       public _3DPoints()
        {
            X = 0;
            Y = 0;
            Z = 0;

        }

        public _3DPoints(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        //Chaining Constructors
        public _3DPoints(int X, int Y): this(X, Y, 0){ }

        public _3DPoints(int X): this (X, 0) { }

        /*2.	Override the ToString Function to produce this output:
                Point3D P = new Point3D (10,10,10);
                Console. WriteLine (P. ToString( ));
                Output: “Point Coordinates: (10, 10, 10)”.
                */

        public override string ToString()
        {
            return $"Points Coordinates : ({X}, {Y}, {Z})";
        }


        //implementation for CompareTo that will be used by the sort function
        public int CompareTo(_3DPoints? other)
        {
            if (this.X > other.X && this.Y > other.Y) return 1;
            else if (this.X < other.X && other.Y < other.Y) return -1;
            else return 0;
        }
        //	Implement ICloneable interface to be able to clone the object.
        public object Clone()
        {
           return new _3DPoints(this.X, this.Y, this.Z);
        }
    }
}
