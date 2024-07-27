using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP003.Project_two
{
    internal class math
    {



        public static int Subtract(int X, int Y)
        {
            return X > Y ? X - Y : Y - X;

        }

        public static int Add(int X, int Y)
        {
            return X + Y;
        }

        public static int Multiply(int X, int Y)
        {
            return X * Y;
        }

        public static int Devision(int X, int Y)
        {
            if (Y != 0)
            {
                return X / Y;
            }
            else
            {
                return -1;
            }
        }
    }
}
