using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    #region Q1-Enum
    enum WeekDays
    {
        Monday = 1, Tuesday = 2 , Wednsday = 3 ,
        Thursday = 4,  Friday = 5, Saturday = 6, Sunday = 7
    }
    #endregion

    #region Q2-Struct
    struct Person
    {
        public int Age;
        public string Name;

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
    #endregion


    #region Q3-Enum
    enum SeasOn
    {
        Spring, Summer, Autumn, Winter

    }
    #endregion

    #region Q4-Enum
    enum Permissions
    {
        Read, write, Delete, Execute
    }
    #endregion

    #region Q5-Enum
    enum Colors
    {
        Red, Blue, Green
    }
    #endregion

    #region Q6-Struct
    struct Point
    {
        public int X;
        public int Y;

      public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;

        }
    }
   
    #endregion

    internal class Program
    {


        static void Main(string[] args)
        {
            #region Q1
            /*Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
             * Then, write a C# program that prints out all the days of the week using this enum.
             */

            //foreach (WeekDays wd in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(wd.ToString());

            //}

            #endregion

            #region Q2
            /*Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and
             * populate it with data. Then, 
              write a C# program to display the details of all the persons in the array.*/

            //Person [] person = new Person[3] {  new Person ("Ahmed", 20),
            //                                    new Person ("Omar", 22), 
            //                                    new Person("Rofida", 22) };

            //for(int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine($"Name of {i+1 }: {person[i].Name}    Age: {person[i].Age} ");

            //}


            #endregion


            #region Q3
            /*Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
             * Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
             * Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            */

            //Console.WriteLine("Enter the mobth to know the season");

            //string month = Console.ReadLine().ToLower();

            //if(month.Equals("march") || month.Equals("april") || month.Equals("may"))
            //{
            //    Console.WriteLine($"The season is {(SeasOn.Spring).ToString()}");
            //}
            //else if (month.Equals("june") || month.Equals("july") || month.Equals("august"))
            //{
            //    Console.WriteLine($"The season is {(SeasOn.Summer).ToString()}");
            //}
            //else if (month.Equals("september") || month.Equals("october") || month.Equals("november"))
            //{
            //    Console.WriteLine($"The season is {(SeasOn.Autumn).ToString()}");
            //}
            //else if (month.Equals("december") || month.Equals("jenuary") || month.Equals("february"))
            //{
            //    Console.WriteLine($"The season is {(SeasOn.Winter).ToString()}");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong input");
            //}

            #endregion

            #region Q4

            /*Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
             * Create Variable from previous Enum to Add and Remove Permission from variable,
             * check if specific Permission is existed inside variable
             */
            //string permission = Console.ReadLine();
            //bool flag = false;

            //foreach (Permissions per in Enum.GetValues(typeof(Permissions))) {
            //    if (permission.Equals(per.ToString()))
            //    {
            //        flag = true;

            //    }

            //}
            //if(flag){
            //    Enum.TryParse(permission, out Permissions permissions);
            //    Console.WriteLine($"Permission of {permissions.ToString()} is added");
            //}
            //else
            //{
            //    Console.WriteLine("this permission is not exist");
            //}



            #endregion

            #region Q5
            /*Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. 
             * Write a C# program that takes a color name as input from the user 
             * and displays a message indicating whether the input color is a primary color or not.*/

            //Console.Write("Enter a color name: ");
            //string inputColor = Console.ReadLine();
            //bool flag = false;


            //    foreach (Colors c in Enum.GetValues(typeof(Colors)))
            //    {
            //        if (inputColor.Equals(c.ToString()))
            //        {
            //            flag = true;

            //        }
            //    }
            //    if (flag)
            //    {
            //        Console.WriteLine("The color is primary color");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The color is not primary color");

            //    }



            #endregion

            #region Q6
            /* Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
             * Write a C# program that takes two points as input from the user and calculates the distance between them.*/


            //Console.WriteLine("Enter the value of x for the first point");
            //int x1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the value of y for the first point");
            //int y1 = int.Parse(Console.ReadLine());

            //Point point1 = new Point(x1, y1);


            //Console.WriteLine("Enter the value of x for the second point");
            //int x2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the value of y for the second point");
            //int y2 = int.Parse(Console.ReadLine());

            //Point point2 = new Point(x2, y2);

            //double distance = Math.Sqrt(Math.Pow((point2.X - point1.X),2) + Math.Pow((point2.Y - point1.Y),2));
            //Console.WriteLine($"The distance between the two points = {distance}");





            #endregion


            #region Q7
            /*Create a struct called "Person" with properties "Name" and "Age".
             * Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.*/

            //We already have Struct Person 

           // Person[] person = new Person[3];
           // string Name;
           // int Age;
           // for(int i = 0; i< person.Length; i++)
           // {
           //     Console.WriteLine($"Enter the data of {i+1} person (Name, Age)");
           //     Name = Console.ReadLine();
           //     Age = int.Parse(Console.ReadLine());
           //     person[i] = new Person(Name,Age);

           // }
           //int Max = -999;
           // int index = 0;
           // for(int i = 0; i < person.Length; i++)
           // {
           //     if(person[i].Age > Max)
           //     {
           //         Max= person[i].Age;
           //         index = i;
           //     }
           // }

           // Console.WriteLine($"The name of the oldest person is {person[index].Name}");




            #endregion

        }
    }
}
