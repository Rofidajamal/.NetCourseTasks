using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Aggregation
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee[] ? Employees { get; set; }

        public  Department (string name)
        {
            Name = name;
        }

        public Department (string name, Employee [] emp)
        {
            Name=name;
            Employees = emp;
        }
    }
}
