namespace Assignment01Advanced
{
    internal class program {
        public static void Main (string [] args)
        {
            #region Partial Class
            //Employee employee = new Employee()
            //{
            //    Name = "Rofida",
            //    Age = 22,
            //    Id = 1,
            //    Salary = 2000
            //};
            #endregion

            #region Before/After Generic
            //int x = 5, y = 10;
            //Helper.SWAP(ref x, ref y);
            //Console.WriteLine($"X: {x}     Y: {y}");

            //////////////////////////////////////////

            //object xx = 5.5, yy = 10.25; // Boxing
            //Helper.SWAP(ref xx, ref yy);
            //Console.WriteLine($"X: {xx}     Y: {yy}");


            ///////////////////////////////////////////

            //Point p1 = new Point(1, 3);
            //Point p2 = new Point(2, 3);
            //Helper.SWAP(ref p1, ref p2);
            //Console.WriteLine(p1.ToString() + " || " + p2.ToString());



            #endregion

            #region Generic Search
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine (Helper<int>.searchArray(arr, 7));

            #endregion

            #region BubbleSort
            int[] arr = { 1, 4, 5, 2, 7, 3,  6,  8 };
            Helper<int>.BubbleSort ( ref arr);
            foreach (int i in arr)
            {
                Console.WriteLine (i);
            }


            #endregion



        }


    }
}
