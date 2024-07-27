using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP003.Project3
{
    /*1.	Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

2.	Override All System.Object Members (ToString, Equals,GetHasCode) .
*/
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int Hours, int Minutes, int Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
        }

        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }
        public Duration(int value)
        {
            Hours = value / 3600;
            value %= 3600;
            Minutes = value / 60;
            Seconds = value % 60;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }


        public override bool Equals(object? obj)
        {
            Duration other = (Duration)obj;
            if (this.Hours == other.Hours && this.Minutes == other.Minutes && this.Seconds == other.Seconds)
            {
                return true;

            }
            else
                return false;
        }


        /*4.	Implement All required Operators overloading to enable this Code:
                ●	D3=D1+D2
                ●	D3=D1 + 7800
                ●	D3=666+D3
                ●	D3= ++D1 (Increase One Minute)
                ●	D3 = --D2 (Decrease One Minute)
                ●	D1= D1 -D2
                ●	If (D1>D2)
                ●	If (D1<=D2)
                ●	If (D1)
                ●	DateTime Obj = (DateTime) D1
        */


        public TimeSpan ToTimeSpan()
        {
            return new TimeSpan(Hours, Minutes, Seconds);
        }

        // Explicit conversion operator to DateTime
        public static explicit operator DateTime(Duration d)
        {
            DateTime baseDate = new DateTime(2023, 7, 17); 
           
            
            return baseDate + d.ToTimeSpan();
        }


        public static bool operator true(Duration d)
        {
            return d.Hours != 0 || d.Minutes != 0 || d.Seconds != 0;
        }

       
        public static bool operator false(Duration d)
        {
            return d.Hours == 0 && d.Minutes == 0 && d.Seconds == 0;
        }

        public static bool operator >(Duration obj1, Duration obj2)
        {
            return obj1.Hours > obj2.Hours && obj1.Minutes > obj2.Minutes && obj1.Seconds > obj2.Seconds;
        }

        public static bool operator <(Duration obj1, Duration obj2)
        {
            return obj1.Hours < obj2.Hours && obj1.Minutes < obj2.Minutes && obj1.Seconds < obj2.Seconds;
        }

        public static bool operator <=(Duration obj1, Duration obj2)
        {
            return obj1.Hours <= obj2.Hours && obj1.Minutes <= obj2.Minutes && obj1.Seconds <= obj2.Seconds;
        }

        public static bool operator >=(Duration obj1, Duration obj2)
        {
            return obj1.Hours >= obj2.Hours && obj1.Minutes >= obj2.Minutes && obj1.Seconds >= obj2.Seconds;
        }


        public static Duration operator -(Duration obj1, Duration obj2)
        {
            Duration result = new Duration();
            result.Hours = obj1.Hours - obj2.Hours;
            result.Minutes = obj1.Minutes - obj2.Minutes;
            result.Seconds = obj1.Seconds - obj2.Seconds;

            return result;

        }

        public static Duration operator --(Duration obj)
        {
            obj.Minutes--;
            return obj;
        }

        public static Duration operator ++(Duration obj) {
            obj.Minutes++;
            return obj;
          }

        public static Duration operator +(Duration obj1, Duration obj2)
        {
            Duration result = new Duration();
            result.Hours = obj2.Hours + obj1.Hours;
            result.Minutes = obj2.Minutes + obj1.Minutes;
            result.Seconds = obj2.Seconds + obj1.Seconds;

            return result;

        }

        public static Duration operator +(Duration obj1, int seconds)
        {
            Duration obj2 = new Duration(seconds);
            Duration result = obj1 + obj2;
            return result;
        }

        public static Duration operator +( int seconds, Duration obj1)
        {
            Duration obj2 = new Duration(seconds);
            Duration result = obj1 + obj2;
            return result;
        }


    }
}
