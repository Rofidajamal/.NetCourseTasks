using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB : TypeA
    {
        public void Test01()
        {
            // Without Inheritance: 
            //TypeA obj = new TypeA();
            // obj.X =2; // Error X is private
            // obj.Y = 3; // Error Y is private
            //obj.Z = 10; // Z is Internal so I can use it through the project

            //With inheritance 
            // X , Y are inherited as private
            // Z is inherited as internal
            X = 10; // it's  not Error as it's #protected and private
            

        }
    }
}
