using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP003.Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age  {get; set;}

        public void Function01()
        {
            Console.WriteLine("I'm Employee");
        }

        public virtual void myFunction02()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");

        }

    }
}
