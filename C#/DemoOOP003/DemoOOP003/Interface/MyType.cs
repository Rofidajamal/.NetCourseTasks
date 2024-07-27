using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP003.Interface
{
    internal class MyType : IMyType // Implementation for the interface
    {
        public int Salary { get; set ; }

        public void MyFunction()
        {
            Console.WriteLine("Implemented class");
        }
    }
}
