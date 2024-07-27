using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP003.Interface
{
    internal interface IMyType
    {
        public int Salary { get; set; } // signature for the property 

        public void MyFunction(); // signature for the function

        public void print()
        {
            Console.WriteLine("Default Method");
        }


    }
}
