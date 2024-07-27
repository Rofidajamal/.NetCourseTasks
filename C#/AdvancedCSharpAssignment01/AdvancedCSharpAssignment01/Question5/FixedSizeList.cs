using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Create a generic class named FixedSizeList<T>.
Implement a constructor that takes the fixed capacity of the list as a 
parameter.
Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
Implement a Get method that retrieves an element at 
a specific index in the list but throws an exception for invalid indices.
 */
namespace AdvancedCSharpAssignment01.Question5
{
    internal class FixedSizeList <T>
    {
        public int Capacity { get; set; }
        private T [] arr ;
        private int size;
        public FixedSizeList(int Capacity)
        {
            size = 0;
    
            this.Capacity = Capacity;
            arr = arr = new T[Capacity];

        }

        public bool Add(T value)
        {
            if(size == Capacity)
            {
                throw new ArgumentException("ERROR, list is already full");
                return false;
            }
            arr[size]=value;
            size += 1;
            return true;
        }

        public T ValueAtIndix (int indx)
        {
            if (indx < 0 || indx > Capacity - 1)
            {
                throw (new ArgumentException("ERROR, Wrong indix"));
               
            }

            return arr[indx];
        }

        public void print()
        {
            Console.WriteLine("Array Elements: ");
            Console.Write("[ ");
           for(int i =0; i <size; i++)
                    Console.Write($"{arr[i]} ");
            Console.Write(" ] ");
        }
    }
}
