using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment5
{
    class Emplyee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }


    #region Struct 
    struct Point
    {
        public int X;
        public int Y;
        //Constructor is a special Function

        //ParameterLess Constructor
        /* public Point()
          {
              X = 0;

              Y = 0;

          }
        */


        //Parametrized Constructor
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
    #endregion


    #region Enum
    enum Gender
    {
        Male =0, M=0, Female =1, F =1
    }

    enum Grades
    {
        //Labels
        A, B, C, D, F // values = 0, 1, 2, 3, 4
    }
    #endregion

    internal class Program
    {
        static void SumMul (int x , int y , out int sum, out int mul)
        {
            sum = x + y;
            mul = x * y;


        }

        static int SumArray (int x, params int [] arr)
        {
            int sum = 0;
            if (arr != null) {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        static void DoSomeProtectiveCode()
        {
            int X, Y, Z;

            do
            {
                Console.WriteLine("Please Enter the value of X");
        
            }
            while (!int.TryParse(Console.ReadLine(), out X) );

            do
            {
                Console.WriteLine("Please Enter the value of Y");

            }
            while (!int.TryParse(Console.ReadLine(), out Y) || Y==0);

            Z = X / Y;
            Console.WriteLine($"The value of Z = {Z} ");

            int[] Arr = { 1, 2, 30 };
            if(Arr?.Length > 100)
            {
                Arr[100] = 1000;
            }
            else
            {
                Console.WriteLine("Out of Range");
            }
        }
        static void Main(string[] args)
        {
            #region ArrayMethods
            int[] Numbers = { 1, 2, 3,7 ,4, 5, 6};
            int[] Arr01 = { 1, 2, 3 };
            int[] Arr02 = new int [5];

            #region ClassMemberMethods [Static]
            //Array.Sort(Numbers); // sort the array in ascending order 
            //foreach (int n in Numbers)
            //{
            //    Console.WriteLine(n);

            //}
            //Console.WriteLine("=================================================");

            //Array.Copy(Arr01, Arr02, 2);

            //foreach (int n in Arr02)
            //{
            //    Console.WriteLine(n);

            //}
            //Console.WriteLine("=================================================");

            //Array.Clear(Arr02,0,5);
            //foreach (int n in Arr02)
            //{
            //    Console.WriteLine(n);

            //}

            //Array.ConstrainedCopy(Arr01, 1, Arr02, 1, 2);

            //foreach (int n in Arr02)
            //{
            //    Console.WriteLine(n);

            //}
            //int[,,] Arr03 = (int[,,])Array.CreateInstance(typeof(int), 2, 3, 10); //3D array [2] [3] [10]



            #endregion

            #region ObjectMemberMethods
            //Console.WriteLine(Numbers.Length);
            //Arr01.CopyTo(Arr02, 1);
            //foreach (int i in Arr02)
            //{
            //    Console.WriteLine(i); // 0 1 2 3 0 
            //}

            //Arr01.SetValue(20, 0);
            //Console.WriteLine(Arr01[0]);
            #endregion
            #endregion

            #region Passing By Out

            //int sum, mul;
            //SumMul(10, 5, out sum, out mul);
            //Console.WriteLine($"Sum = {sum}\nMultiplication = {mul}");

            #endregion

            #region Function-Params

            //int total = SumArray (1, 2, 3, 4, 5);
            //Console.WriteLine (total);
            #endregion

            #region Exception + Protective Code

            try
            {
                DoSomeProtectiveCode();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            #endregion


            #region Enum 
            //Grades myGrade = Grades.A;

            //if(myGrade == Grades.B)
            //{
            //    Console.WriteLine(":)");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong, The grades is " + myGrade.ToString());
            //}

            //myGrade = (Grades)2;
            //Console.WriteLine(myGrade.ToString());

            #endregion

            #region Point Struct
            //Point p1;
            //p1.X = 3;
            //p1.Y = 4;
            //Console.WriteLine($"X= {p1.X}\nY = {p1.Y}");
            //p1 = new Point(10, 20);
            //Console.WriteLine($"X= {p1.X}\nY = {p1.Y}");
            //p1 = new Point();
            //Console.WriteLine($"X= {p1.X}\nY = {p1.Y}");


            #endregion



        }
    }
}
