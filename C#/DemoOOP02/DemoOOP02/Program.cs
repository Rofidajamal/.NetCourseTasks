using DemoOOP02.Inheritance;

namespace DemoOOP02
{
    //Rofida Gamal Muhammed 
    internal class program
    {
        #region OverLoading

        // changing in 1- type of parametes, or return data type. 
        //2- order of parameters

        public static int Sum (int x, int y)
        {
            return x + y;
        }

        public static int Sum(int x, int y , int z)
        {
            return x +y + z;
        }

        public static double Sum (double x, double y)
        {
            return x + y;
        }





        #endregion
       public static  void Main(string [] args)
        {
            #region Constructor Chaining
            Car car = new Car(1, "Hunday");

            Console.WriteLine("\n" + car +"\n");

            Car car1 = new Car(2);

            #endregion

            #region Inheritance
            //Child ch = new Child(3, 2, 10);

            Parent pr = new Child(10, 20, 30);
            Console.WriteLine(pr);
            #endregion

            Console.WriteLine(); // is type of overloading functions



        }
    }
}
