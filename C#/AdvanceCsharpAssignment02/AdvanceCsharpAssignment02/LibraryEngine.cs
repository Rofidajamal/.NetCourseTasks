using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdvanceCsharpAssignment02.program;

namespace AdvanceCsharpAssignment02
{
    internal class LibraryEngine
    {

        public static void ProcessBookFunctions(Book[] BookList, BookFunctionsDelegate fptr)
        {
            foreach (Book book in BookList)
            {
                Delegate[] delegates = fptr.GetInvocationList();
                foreach (BookFunctionsDelegate function in delegates)
                {
                    Console.WriteLine(function(book));
                }

                
                Console.WriteLine("======================");

            }
        }
    }
}
