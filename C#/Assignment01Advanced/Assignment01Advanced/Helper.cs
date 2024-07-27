using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced
{
    internal class Helper <T> where T : IComparable
    {

        #region Swap Before Generics
        //Before Generic 
        //public static void SWAP(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //}

        //public static void SWAP(ref double x, ref double y)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;

        //}

        //public static void SWAP(ref Point x, ref Point y)
        //{
        //    Point temp = x;
        //    x = y;
        //    y = temp;

        //}


        //////////////////////////////////////////////////////////

        //Using Object (Boxing and Unboxing)
        //public static void SWAP(ref object x, ref object y)
        //{
        //    object temp = x;
        //    x = y;
        //    y = temp;

        //}

        #endregion

        #region Swap Using Genereics
        public static void SWAP <T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;

        }

        #endregion

        #region Search 
        public static int searchArray <T>(T [] arr, T value)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals( value))
                        return i;
                }

            }
            return -1;
        }
        #endregion



        #region BubbleSort
        public static void BubbleSort (ref T [] arr)
        {
            if(arr is not null)
            {
                for(int i =0; i < arr.Length; i++)
                {
                    for(int j = 0; j < arr.Length-1-i; j++)
                    {
                        if (arr[j].CompareTo(arr[j+1]) == 1)
                        {
                            SWAP(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }
        }

        #endregion
    }


}
