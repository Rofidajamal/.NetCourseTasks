using DemoOOP003.Overriding;
using DemoOOP003.Binding;
using DemoOOP003.Interface;
using DemoOOP003.CarIplaneInterface;
using DemoOOP003.BuiltInIntrefaces;

namespace DemoOOP003
{
    internal class Program
    {
        #region Employee Overriding

        //public static void ProcessEmployee(Employee FT)
        //{
        //    if (FT is not null)
        //    {
        //        FT.Function01();
        //        Console.WriteLine("=====================");
        //        FT.myFunction02();
        //    }

        //}
        #endregion
        public static void Main(string[] args)
        {
            #region Binding
            //TypeA refObject = new TypeB(3, 10);
            //refObject.function01();
            //Console.WriteLine("=============================");
            //refObject.function02();
            #endregion

            #region Binding is Behavior
            //FullTimeEmployee FT = new FullTimeEmployee()
            //{
            //    Id = 10,
            //    Name = "Rahma",
            //    Age = 21,
            //    Salary = 8000
            //};

            //ProcessEmployee(FT);

            //PartTimeEmployee PT = new PartTimeEmployee()
            //{
            //    Id = 100,
            //    Name = "Rofida",
            //    Age = 21,
            //    HoursRate = 130
            //};

            //Console.WriteLine("====================================");
            //Console.WriteLine("====================================");
            //ProcessEmployee(PT);


            #endregion


            #region Interface
            //IMyType mytype = new MyType();
            //mytype.MyFunction();
            //mytype.print(); // defaul method appears because the object is IMyType reference

            #endregion

            #region Car/Airplane interface Example
            //IMovable airplane = new AirPlan();
            //IFlyable airplane = new AirPlan();
            //airplane.Backward();

            #endregion

            #region Copy Shallow/Deep

            //int[] Arr01 = { 1, 2, 3};
            //int [] Arr02 = { 10, 20, 30 };
            //Console.WriteLine("Before Copy: ");
            //Console.WriteLine("Hash code of array 01 "+Arr01.GetHashCode());
            //Console.WriteLine("Hash code of array 02 " + Arr02.GetHashCode());

            //Console.WriteLine("=============================");
            //Console.WriteLine("After Copy: ");
            #region Shallow
            ////Shallow Copy
            ////  Arr02 = Arr01;
            //// Object {1,2,3} has 2 references (Arr01, Arr02)
            //// Object {10, 20, 30} unreacheble object (Garbage collector will delete it)

            #endregion

            #region Deep
            //Arr02 = (int[]) Arr01.Clone();
            //#endregion
            //Console.WriteLine("Hash code of array 01 " + Arr01.GetHashCode());
            //Console.WriteLine("Hash code of array 02 " + Arr02.GetHashCode());


            #endregion
            #endregion


            #region  (Iclonable) 
            //BuiltInIntrefaces.Employee emp = new BuiltInIntrefaces.Employee()
            //{
            //    Id = 5,
            //    Name = "Ranma",
            //    Salary = 30000

            //};

            //BuiltInIntrefaces.Employee emp2 = new BuiltInIntrefaces.Employee()
            //{
            //    Id = 10,
            //    Name = "Manar",
            //    Salary = 10000

            //};

            //Console.WriteLine($"First Employee Hash code {emp.GetHashCode()}");
            //Console.WriteLine($"Second Employee Hash code {emp2.GetHashCode()}");
            //emp2 =(BuiltInIntrefaces.Employee) emp.Clone();

            //Console.WriteLine("================================");
            //Console.WriteLine("After Cloning");
            //Console.WriteLine($"First Employee Hash code {emp.GetHashCode()}");
            //Console.WriteLine($"Second Employee Hash code {emp2.GetHashCode()}");






            #endregion

            #region  ICombarable

            //BuiltInIntrefaces.Employee[] emps =
            //{
            //    new BuiltInIntrefaces.Employee (){Id =1, Name = "R", Salary = 1000},
            //    new BuiltInIntrefaces.Employee (){Id =2, Name = "M", Salary = 2000},
            //    new BuiltInIntrefaces.Employee (){Id =3, Name = "S", Salary = 5000},


            // };

            ////Array.Sort(emps); //ERROR
            //int Result = emps[1].CompareTo(emps[0]);
            //Console.WriteLine(Result ==1 ? "Greater than" : Result == -1 ? "Less than" : "Equal");


            #endregion










        }
    }
}