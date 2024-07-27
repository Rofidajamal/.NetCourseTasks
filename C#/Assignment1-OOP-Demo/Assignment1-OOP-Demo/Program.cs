using System;
using Common;


namespace AssignmentDemoOOP
{

    public class Program
    {
        static public  void Main(string [] args)
        {
            //Employee emp = new Employee(12223, "Rofida", 30000);

            //emp.Id = 2001; // Direct Access to the Attrbute if it's public

            //emp.setName("Rana");

            //emp.Salary = 5000;

           // Console.WriteLine(emp.ToString());
           // TypeA obj = new TypeA();
            // obj.X = 5; //Gives an Error because it's Private. We can access it inside its class only.
           // obj.Y = 3; // Gives an Error because it's Internal. We can access it inside its project only.
           // obj.Z = 10;


            Car car = new Car();
            car.Id = 122;
            Console.WriteLine(car.Id);


         



        }
    }


}