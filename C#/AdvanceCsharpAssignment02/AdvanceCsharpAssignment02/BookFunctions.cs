using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCsharpAssignment02
{
    internal class BookFunctions
    {

        public static string GetTitle (Book B)
        {
            if (B is not  null)
                return B.Title;
            else
            {
                throw new Exception("Book cannot be NULL");
            }
        }

        public static string GetAuthors (Book B)
        {
            if (B is not null)
                return (B.Authors).ToString();
            else
            {
                throw new Exception("Book cannot be NULL");
            }

        } 

        public static string GetPrice (Book B)
        {
            if (B is not null)
            {
               
                return (B.Price).ToString();
            }
            else
            {
                throw new Exception("Book cannot be NULL");
            }

        }
    }
}
