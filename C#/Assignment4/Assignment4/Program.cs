
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {

        #region FunctionsQ1
        static public void PassingByValueExample(int n)
        {
            n = 10;
            Console.WriteLine($" the value of n while calling the function {n}");
        }

        static public void PassingByREferenceExample(ref int n)
        {
            n = 10;
            Console.WriteLine($" the value of n while calling the function {n}");
        }

        #endregion


        #region FunctionsQ2
        static public void PassingByValueReference(int[] arr)
        {
            arr[0] = 100;
            arr = new int[4];
            Console.WriteLine(arr.GetHashCode());
        }

        static public void PassingByRefReference(ref int[] arr)
        {
            arr[0] = 100;
            arr = new int[4];
            Console.WriteLine(arr.GetHashCode());
        }
        #endregion


        #region FunctionQ3
        static public void operations(int num1, int num2, ref int sum, ref int sub)
        {
            sum = num1 + num2;
            sub = num1 - num2;

        }
        #endregion

        #region FunctionQ4
        static public int SumDigit(int n)
        {
            int digit, sum = 0;
            while (n > 0)
            {
                digit = n % 10;
                sum += digit;
                n /= 10;

            }
            return sum;
        }
        #endregion

        #region FunctionQ5
         static public bool isPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            for (int i = 2; i < n/2; i++)
            {
                if(n%i == 0)
                {
                    return false;
                }

            }
            return true;
        }
        #endregion

        #region functionQ6


        static public void MinMaxArray (ref int [] arr, ref int min, ref int max)
        {
            min = arr[0];
            max = arr[0];
            for(int i=1; i< arr.Length; i++)
            {
                if(min > arr[i])
                {
                    min = arr[i];
                }

                if(max < arr[i])
                {
                    max = arr[i];
                }
            }

        }

        #endregion

        #region FunctionQ7

        static public int Factorial (int n)
        {
            int fact = 1;
            for(int i = 1; i <= n; i++)
            {
                fact*= i;

            }
            return fact;
        }
        #endregion

        #region FunctionQ8

        static public void CharReplacingByPos(ref StringBuilder message, int pos, char replacingWith)
        {
           message[pos] = replacingWith;
            
        }

        static public void CharRelacingByChar(ref StringBuilder message,char letter, char replacingWith)
        {
            for(int i = 0; i < message.Length; i++)
            {
                if(message[i] == letter)
                {
                    message[i] = replacingWith;
                }

            }
        }
        #endregion 



        static void Main(string[] args)
        {
            #region Q1
            /* Explain the difference between passing (Value type parameters)
             * by value and by reference then write a suitable c# example.*/

            //Passing by value will take a copy of the value, If we make any changes of this value in the Function
            // the main value in the Main function will not change 
            //example on Passing by value
            //int n = 1;
            //PassingByValueExample (n);
            //Console.WriteLine ($" the value of n after calling the function {n}"); // n did not change.

            //////////////////////////////////////////////////////////////////////////////////////////

            //While Passing by reference will take the address of the variable SO any change will happen in the function
            // will change the value in the Main function.
            // Example on Passing by reference 

            //PassingByREferenceExample ( ref n );
            //Console.WriteLine($" the value of n after calling the function {n}"); // the value of n will change




            #endregion

            #region Q2
            /*Explain the difference between passing (Reference type parameters) by value and 
             * by reference then write a suitable c# example.*/

            //passing by value: the copy of the reference is passed. 
            //the method can modify the object that the reference points to,
            //but it cannot change the reference itself to point to a new object.

            //Example on Passing by value for Reference Type
            //int[] arr = new int[4] {1, 2, 3, 4};
            //PassingByValueReference (arr);
            //Console.WriteLine(arr[0]); // it changed from 1 to 100
            //Console.WriteLine(arr.GetHashCode()); // it differs from the Code of the array in the function

            ///////////////////////////////////////////////////////////////////////////////////////////////


            //Passing by Reference : you pass the actual memory address of the parameter.
            //the method can modify  the reference itself.
            //PassingByRefReference(ref arr);

            //Console.WriteLine(arr[0]); // it changed from 1 to 100
            //Console.WriteLine(arr.GetHashCode()); // it's the same as the Code of the array in the function









            #endregion

            #region Q3

            /*Write a c# Function that accept 4 parameters from user and return result of 
             * summation and subtracting of two numbers*/
            //int num1, num2, sum =0, sub=0;
            //Console.WriteLine("Enter two numbers");
            //num1 = int.Parse(Console.ReadLine());
            //num2 = int.Parse(Console.ReadLine());
            //operations(num1, num2, ref sum, ref sub);
            //Console.WriteLine($"The Summation result : {sum}");
            //Console.WriteLine($"The Subtraction result : {sub}");



            #endregion

            #region Q4
            /*Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.*/
            //Console.WriteLine("Enter the number");
            //int num = int.Parse(Console.ReadLine());
            //int result = SumDigit(num);
            //Console.WriteLine(result);

            #endregion

            #region Q5
            /*Create a function named "IsPrime", which receives an integer number and
             * retuns true if it is prime, or false if it is not*/

            //Console.WriteLine("Enter the number");
            //int num = int.Parse(Console.ReadLine());
            //bool isprime = isPrime(num);
            //string message =isprime? "The number is prime" : "The number is not prime" ;
            //Console.WriteLine(message);

            #endregion

            #region Q6 
            /*Create a function named MinMaxArray, 
             * to return the minimum and maximum values stored in an array, using reference parameters*/

            //int[] arr = new int[4] { 1, 2, 3, 4 };
            //int min = 0, max = 0;
            //MinMaxArray(ref arr, ref min, ref max);
            //Console.WriteLine($"Min value: {min}\nMax value: {max}");
            #endregion

            #region Q7
            /*Create an iterative (non-recursive) function to calculate the factorial of
             * the number specified as parameter*/

            //Console.WriteLine("Enter the number you want to get it's factorial");
            //int num = int.Parse(Console.ReadLine());
            //int result = Factorial(num);
            //Console.WriteLine(result);
            #endregion

            #region Q8
            /* Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string,
             * replacing it with a different letter*/



            //StringBuilder message = new StringBuilder("Hello World");
            //char  replaceingChar;
            //int pos = 0;
            //Console.WriteLine(message.ToString());
            //Console.WriteLine("Enter the position you want to replace ");
            //pos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the char you want to replace by ");
            //replaceingChar = char.Parse(Console.ReadLine());

            //CharReplacingByPos(ref message, pos, replaceingChar);

            //Console.WriteLine($"the string after replacing {message}");





            #endregion
        }
    }
}
