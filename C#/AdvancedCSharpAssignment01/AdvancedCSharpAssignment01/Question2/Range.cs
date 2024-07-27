using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*create a generic Range<T> class that represents a range of values from a minimum value to a maximum value.
 * The range should support basic operations such as checking if a value is within the range and determining
 * the length of the range.
Requirements:

        1- Create a generic class named Range<T> where T represents the type of values.
        2- Implement a constructor that takes the minimum and maximum values to define the range.
        3- Implement a method IsInRange(T value) that returns true if the given 
               value is within the range, otherwise false.
        4- Implement a method Length() that returns the length of the range
        (the difference between the maximum and minimum values).

*/

namespace AdvancedCSharpAssignment01.Question2
{
    internal class Range <T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }

        public Range(T Min, T Max)
        {
           this.Min = Min;
           this.Max = Max;
           
        }

        public bool IsInRange(T value)
        {
            return (value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0);
        }

        public T Length()
        {
            dynamic min = Min;
            dynamic max = Max;
            return max - min;
        }

       
    }
}
