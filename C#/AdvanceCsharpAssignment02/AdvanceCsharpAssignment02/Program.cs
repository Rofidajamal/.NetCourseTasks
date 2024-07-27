namespace AdvanceCsharpAssignment02
{

    internal class program
    {
        public delegate string BookFunctionsDelegate(Book B);


        public static void Main(string[] args)
        {
            Book B = new Book ("2251", "Ay 7aga" ,new string[] { "Amr", "Rofida", "Rana" },
                new DateTime().Date, 2000);

            Book B1 = new Book("2251", "Book2", new string[] { "Amr", "Rofida", "Rana" },
               new DateTime().Date, 2000);
            Book[] Bs = new Book [] { B, B1 };

            BookFunctionsDelegate bookdelegate = BookFunctions.GetTitle;

            bookdelegate += BookFunctions.GetPrice;
            bookdelegate += BookFunctions.GetAuthors;
            //(Book book) => string.Join(", ", BookFunctions.GetAuthors(book))

            LibraryEngine.ProcessBookFunctions(Bs, bookdelegate);

            //Console.WriteLine(BookFunctions.GetTitle(B));
            //Console.WriteLine(BookFunctions.GetPrice(B));
            //string[] auth = BookFunctions.GetAuthors(B);


            //foreach (string authItem in auth)
            //{
            //    Console.WriteLine( authItem);
            //}


        }
    }
}