using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment04.operatorOverLoading
{
    internal class CComplex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        #region Binary Operator (+ -)
        // Must be non private, Class member function 

        public static CComplex operator +(CComplex left, CComplex right)
        {


            return new CComplex()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0),
            };
        }


        public static CComplex operator -(CComplex left, CComplex right)
        {


            return new CComplex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0),
            };
        }

        #endregion

        #region Unary Operators

        public static CComplex operator ++(CComplex C)
        {
            return new CComplex()
            {
                Real = C?.Real ?? 0 + 1,
                Imag = C?.Imag ?? 0
            };
        }

        public static CComplex operator --(CComplex C)
        {
            return new CComplex()
            {
                Real = C?.Real ?? 0 - 1,
                Imag = C?.Imag ?? 0
            };
        }

        #endregion

        #region Relational operators

        public static bool operator >(CComplex left, CComplex right)
        {
            if (left?.Real == right?.Real)
            {
                return left?.Imag > right?.Imag;

            }
            else
            {
                return left?.Real > right?.Real;
            }

        }

        public static bool operator <(CComplex left, CComplex right)
        {
            if (left?.Real == right?.Real)
            {
                return left?.Imag < right?.Imag;

            }
            else
            {
                return left?.Real < right?.Real;
            }

        }

        #endregion

        #region Casting Operator

        //Explicit casting to int 
        public static explicit  operator int (CComplex C){
            return C?.Real ?? 0;
            }
        //Implicit casting to string 
        public static implicit operator string(CComplex C)
        {
            return C?.ToString() ?? String.Empty;
        }


        #endregion 
        public override string ToString()
        {
            return $"{Real} + {Imag}I";
        }




    }
}
