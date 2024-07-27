using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Part02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Questions 15-16 are in the last assignment so I did not write it again.*/
            #region Q17
            /*17- Create a program that asks the user to input three points (x1, y1), (x2, y2),
             * and (x3, y3), and determines whether these points lie on a single straight line.*/
            //double[,] points = new double[3, 2];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter the values of point {i+1}");
            //    for(int j =0; j<2; j++)
            //    {
            //        points[i, j] = double.Parse(Console.ReadLine());

            //    }

            // }
            //double p1_P2 = Math.Sqrt(Math.Pow((points[1, 0] - points[0, 0]),2) + Math.Pow((points[1,1] -points[0,1]),2));
            //double p2_p3 = Math.Sqrt(Math.Pow((points[2, 0] - points[1, 0]), 2) + Math.Pow((points[2, 1] - points[2, 1]), 2));
            //double p1_p3 = Math.Sqrt(Math.Pow((points[2, 0] - points[0, 0]), 2) + Math.Pow((points[2, 1] - points[0, 1]), 2));


            //if (p1_P2 + p2_p3 == p1_p3)
            //    Console.WriteLine("They are on the straight line");
            //else
            //    Console.WriteLine("They are not");
            #endregion

            #region Q18
            /*18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. 
             * A worker's efficiency level is determined as follows: 
            - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
            - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
            - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
            - If the worker takes more than 5 hours, they are required to leave the company. 
            To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

            */
            //double hours;
            //Console.WriteLine("Enter the hours");
            //hours = double.Parse(Console.ReadLine());

            //if(hours >=2 && hours <= 3)
            //{
            //    Console.WriteLine("High Efficiency");
            //}
            //else if (hours >=3 && hours <= 4)
            //{
            //    Console.WriteLine("they need to be instructed to increase their speed");

            //}
            //else if (hours <= 4 && hours <= 5)
            //{
            //    Console.WriteLine("they need to be provided with training to enhance their speed.");

            //}
            //else if (hours > 5)
            //{
            //    Console.WriteLine("they are required to leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Input");
            //}

            #endregion

            #region Q19
            /* Write a program that prints an identity matrix using for loop, 
             * in other words takes a value n from the user and shows the identity table of size n * n.*/

            //Console.WriteLine("Enter the size of the array");
            //int MatSize = int.Parse(Console.ReadLine());
            //int[,] Matrix = new int [MatSize, MatSize];
            //for(int i = 0; i < MatSize; i++)
            //{
            //    for(int j=0; j < MatSize; j++)
            //    {
            //        if(i == j)
            //        {
            //            Matrix[i,j] = 1;
            //        }
            //    }

            //}

            //for(int i = 0;i < MatSize; i++)
            //{

            //        for(int j = 0; j< MatSize; j++)
            //    {
            //        Console.Write(Matrix[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q20
            /*  Write a program in C# Sharp to find the sum of all elements of the array.*/

            //int[] arr = new int[5];
            //int sum= 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //   arr[i] = int.Parse( Console.ReadLine());
            //    sum += arr[i];
            //}

            //Console.WriteLine(sum);
            #endregion

            #region Q21
            /*21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.*/
            //int[] arr1 = new int[5] {3, 4, 5, 7, 10 };
            //int [] arr2 = new int[5] {1, 2, 6, 8, 9};
            //int Size = arr1.Length + arr2.Length;
            //int[] merged = new int[Size];
            //int i = 0;
            //int j = 0;

            //for(int k = 0; k < Size; k++)
            //{

            //    if (i >= arr1.Length)
            //    {
            //        merged[k] = arr2[j++];
            //    }
            //    else if (j >= arr2.Length)
            //    {
            //        merged[k] = arr1[i++];
            //    }
            //    else if (arr1[i] <= arr2[j])
            //    {
            //        merged[k] = arr1[i++];
            //    }
            //    else
            //    {
            //        merged[k] = arr2[j++];
            //    }
            //}


            //foreach (int n in merged)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion

            #region Q22
            /* 22- Write a program in C# Sharp to count the frequency of each element of an array.*/
            //int [] freqArr = new int [11];
            //int [] arr = new int[15] {10, 10, 0, 1 , 1 , 6, 6, 2,0, 0,3, 2, 8, 7, 7};

            //for (int i = 0; i < arr.Length; i++)
            //{

            //     freqArr[arr[i]]++;


            //}

            //foreach(int i in freqArr)
            //{

            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q23
            /*23- Write a program in C# Sharp to find maximum and minimum element in an array*/
            //int [] arr = new int [5] { 1, 2, 3, 4, 5 };
            //int max = -999;
            //int min = 9999;
            //for (int i = 0;i<5; i++)
            //{
            //    if(arr[i] > max)
            //    {
            //        max = arr[i];
            //    }

            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}

            //Console.WriteLine($"Max value is {max}\nmin value is {min}");

            #endregion

            #region Q24
            /*24 Write a program in C# Sharp to find the second largest element in an array.*/

            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            //int max = -999;

            //for (int i = 0; i < 5; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}
            //int max2 = -999;

            //for (int i = 0; i < 5; i++)
            //{
            //    if (arr[i] > max2 && arr[i] != max)
            //    {
            //        max2 = arr[i];
            //    }
            //}
            //Console.WriteLine(max2);




            #endregion

            #region Q25
            /*25- Consider an Array of Integer values with size N, having values as in this Example
             * write a program find the longest distance between Two equal cells. In this example.
             * The distance is measured by the number Of cells- for example,
             * the distance between the first and the fourth cell is 2 (cell 2 and cell 3).
             * In the example above, the longest distance is between the first 7 and the
                10th 7, with a distance of 8 cells, i.e. the number of cells between the 1st
                And the 10th 7s.
             */
            //Console.WriteLine("Please, enter the size of the array");
            //int N = int.Parse(Console.ReadLine());
            //int[] arr = new int[N];
            //Console.WriteLine("Please, enter the elements of the array");
            //for (int i = 0; i < N; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int firstOCC = 0;
            //int endOCC = 0;
            //int dist = 0;
            //int Counter = 0;
            //int max = -9999;

            //for (int i = 0; i < N; i++)
            //{
            //    if (Counter == 0)
            //    {
            //        firstOCC = i;
            //    }
            //    for (int j = i + 1; j < N; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            Counter++;
            //            endOCC = j;
            //            dist = endOCC - firstOCC;
            //            if (dist > max)
            //            {
            //                max = dist;
            //            }


            //        }

            //    }
            //    Counter = 0;

            //}

            //Console.WriteLine($"the longest distance is {max - 1}");



            #endregion

            #region Q26

            /* Given a list of space separated words, reverse the order of the words.*/
            //Console.WriteLine("Enter your sentance");

            //string Words = Console.ReadLine();

            //string [] splittedWords = Words.Split(' ');

            //foreach (string word in splittedWords.Reverse())
            //{
            //    Console.Write(word);
            //}
            #endregion

            #region Q27
            /*Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. 
             * Now copy all the elements of first array on second array and print second array.*/

            //int[,] arr = new int[2,4];
            //int[,] arr2 = new int[2, 4];

            //for(int i = 0; i< arr.GetLength(0); i++)
            //{
            //    for(int j = 0; j<arr2.GetLength(1); j++)
            //    {
            //        arr[i,j] = int.Parse(Console.ReadLine());

            //    }
            //}

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        arr2[i, j] = arr[i,j];

            //    }
            //}

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //       Console.Write( arr2[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region Q28
            /*28 Write a Program to Print One Dimensional Array in Reverse Order*/

            //int [] arr = new int [5] { 1, 2, 3, 4, 5 };
            //for(int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}



            #endregion
        }
    }
}
