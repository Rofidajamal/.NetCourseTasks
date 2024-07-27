using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDemoOOP
{
    internal struct Employee
    {

        #region Attributes
        private int id;
        private string name;
        private decimal salary;
        #endregion

        //Parametrized Constructor

        //public Employee(int id, string name, decimal salary)
        //{
        //    this.Id = id;
        //    this.name = name;
        //    this.salary = salary;
        //}

            #region Setters and Getters

       //     public void setID(int Id)
       // {
       //     this.Id = Id;
       // }

       //public void setName(string Name)
       // {
       //     this.Name = Name;
       // }

       // public void setSalary(decimal salary)
       // {
       //     this.salary = salary;
       // }

       //public int getID()
       // {
       //     return Id;
       // }

       // public string getName()
       // {
       //     return Name;
       // }

       // public decimal getSalary()
       // {
       //     return salary;
       // }
            #endregion

            #region Properties

            //Full Property
            public decimal Salary
        {
            get { return Salary; }
            set { Salary = value; }
        }

        //Automatic Property

        public int  Id
        {
            get;
            set;
        }
            #endregion


       

        public override string ToString()
        {
            return $"Name : {name}  ID: {id}    Salary: {salary}";
        }
    }
}
