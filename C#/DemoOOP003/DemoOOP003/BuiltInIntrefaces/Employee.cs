using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP003.BuiltInIntrefaces
{
    internal class Employee: ICloneable, IComparable<Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Employee()
        {
            Id = 0;
            Name = " ";
            Salary = 0000;
        }


        //Copy Constructor
        public Employee (Employee emp)
        {
            this.Id = emp.Id;
            this.Name = emp.Name;
            this.Salary = emp.Salary;
        }

        public Object Clone()
        {
            return new Employee()
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary
            };
        }

        public override string ToString()
        {
           return $"ID: {Id}, Name: {Name}, Salary: {Salary}";
        }

        public int CompareTo(Employee? other)
        {
            if (this.Salary > other.Salary) return 1;
            else if (this.Salary < other.Salary) return  -1;
            else return 0;
        }
    }
}
