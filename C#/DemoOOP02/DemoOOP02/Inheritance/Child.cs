using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Inheritance
{
    internal class Child : Parent
    {
        public int Z { get; set; }

        public Child(int X, int Y, int _Z) : base(X, Y)
        {
            Z = _Z;
        }

        public override string ToString()
        {
            return base.ToString() + $" Z: {Z}";
        }


    }
}
