using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP003.Binding
{
    internal class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public new void Function01()
        {
            Console.WriteLine("Child Class Full Time ");
        }

        public override void myFunction02()

        {
            base.myFunction02();
            Console.WriteLine($"Salary: {Salary}");

        }


    }
}
