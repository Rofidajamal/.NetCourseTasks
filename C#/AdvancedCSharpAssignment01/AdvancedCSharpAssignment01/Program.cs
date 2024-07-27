using AdvancedCSharpAssignment01.Question1;
using AdvancedCSharpAssignment01.Question2;
using AdvancedCSharpAssignment01.Question5;
using System.Collections;

namespace AdvancedCSharpAssignment01
{


    internal class program
    {
        #region Function Q3
        /* You are given an ArrayList containing a sequence of elements. 
         * try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. 
         * Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
        */

        public static void ReversedArray(ref ArrayList arr)
        {
            if (arr is not null)
            {
                int temp = 0;

                for (int i = 0; i < arr.Count / 2; i++)
                {
                    temp = (int)arr[i];
                    arr[i] = arr[arr.Count - i - 1];
                    arr[arr.Count - i - 1] = temp;
                }
            }
            else
                throw new Exception("ERROR Array is Null");


        }
        #endregion


        #region Function Q4
        /*You are given a list of integers. Your task is to find and return 
         * a new list containing only the even numbers from the given list.*/

        public static int[] EvenList(int[] arr)
        {
            int[] evenList = new int[arr.Length];
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenList[k] = arr[i];
                    k++;
                }
            }
            return evenList;
        }

        #endregion

        #region Function Q6
        /*Given a string, find the first non-repeated character in it and return its index.
         * If there is no such character, return -1. Hint you can use dictionary*/

        public static int FindFirsrtNonRepeated(string sentence)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            Dictionary<char, int> charIndex = new Dictionary<char, int>();

            for (int i = 0; i < sentence.Length; i++)
            {
                char c = sentence[i];
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                    charIndex[c] = i;
                }
            }

            foreach (var element in charCount)
            {
                if (element.Value == 1)
                {
                    return charIndex[element.Key];
                }
            }
            return -1;
        }

        #endregion
        public static void Main(string[] args)
        {
            #region Q1
            //int[] vs = { 1, 2, 3, 4 };
            //int[] vs = { 1, 11, 2, 5, 3, 10 };
            //try
            //{
            //    BubbleSort<int>.EnhancedBubbleSort(ref vs);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //BubbleSort<int>.PrintAfterSorting(vs);

            #endregion

            #region Q2
            //Range<int> R = new Range<int>(10, 20);
            //Console.WriteLine(R.IsInRange(15).ToString());
            //Console.WriteLine(R.Length());


            #endregion

            #region Q3
            //ArrayList arr = new ArrayList() { 1, 2, 3, 4, 5 };
            //try{
            //ReversedArray( ref arr);
            //}
            //catch(Exception ex){
            //        Console.WriteLine(ex.Message);
            //    }


            //foreach (int i in arr)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region Q4
            //int[] vs = { 1, 11, 2, 5, 3, 10, 8, 20 };
            //int[] even = EvenList(vs);
            //foreach(int i in even)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion


            #region Q5
            //FixedSizeList <int> fixedSizeList = new FixedSizeList<int>(3);
            //try
            //{
            //    fixedSizeList.Add(5);
            //    fixedSizeList.Add(1);
            //    fixedSizeList.Add(2);
            //   // fixedSizeList.Add(3); // it will throw an exception
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    Console.WriteLine($"Value at index 1 is: {fixedSizeList.ValueAtIndix(1)}");
            //    //Console.WriteLine($"Value at index 1 is: {fixedSizeList.ValueAtIndix(100)}"); // Throw an Exception
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //fixedSizeList.print();

            #endregion


            #region Q6
            // string sentance = "Hello e";
            ////sentance = "eeeeeee";
            // Console.WriteLine($"the index of non repeated character: {FindFirsrtNonRepeated(sentance)}");
            #endregion


        }
    }
}

