using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP003.Binding
{
    internal class PartTimeEmployee : Employee
    {
        public decimal HoursRate { get; set; }

        public new void Function01()
        {
            Console.WriteLine("Child Class Part Time ");
        }

        public override void myFunction02()

        {
            base.myFunction02();
            Console.WriteLine($"Hours Rate: {HoursRate}");

        }

    }
}
