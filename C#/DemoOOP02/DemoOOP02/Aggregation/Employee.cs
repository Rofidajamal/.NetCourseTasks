using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Aggregation
{
    internal class Employee
    {
        // it's an option relation ship so it will accept nullable
        public int Id { get; set; }
        public string? Name { get; set; }

        public decimal Salary { get; set; }

        public string? Address { get; set; }
    }
}
