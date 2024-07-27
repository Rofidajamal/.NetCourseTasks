using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases,
 * which makes it inefficient for large datasets. How we can optimise the Bubble Sort algorithm 
And implement the code of this optimised bubble sort algorithm
*/

//We can make it by comparing j with length-i-1 as we have the biggest number
//each iteration we don't need to compare it again and again.
//We can add flag to check if the array already sorted or not after the first iteration.


namespace AdvancedCSharpAssignment01.Question1
{
    internal class BubbleSort <T> where T : IComparable
    {


       public static void EnhancedBubbleSort(ref T [] arr)
        {
            if (arr is not null)
            {
                T temp;
                bool flag = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) == 1)
                        {
                            flag = true;
                            temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }

                    }
                    if (!flag)
                    {
                        Console.WriteLine("It's already sorted");
                        break;
                    }
                }
            }
            else
            {
                throw new Exception("ERROR, Array is null");
            }

           
        }

     public static void PrintAfterSorting (T [] arr)
        {
            foreach(T i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
