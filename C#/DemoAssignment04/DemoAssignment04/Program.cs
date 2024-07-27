using DemoAssignment04.Abstract;
using DemoAssignment04.operatorOverLoading;
using DemoAssignment04.StaticAndConst;

namespace DemoAssignment04
{
    internal class Program
    {
        public static void Main(string [] args)
        {
            #region OperatorOverLoading 
            CComplex C1 = new CComplex()
            {
                Real = 5,
                Imag = 3,
            };

            CComplex C2 = new CComplex()
            {
                Real = 10,
                Imag =5,
            };
            CComplex C3 = new CComplex();

            #region Binary Operators

            // C3 = C1 + C2; // Needs Operator + overloading.
            //Console.WriteLine(C3);
            //CComplex C4 = C1 + C2 + C3;
            //Console.WriteLine(C4);

            #endregion

            #region Unary Operator
            //Console.WriteLine($"C1: {C1}");
            //C3 = ++C1;

            //Console.WriteLine($"C3 : {C3}");

            //C3 = --C1;
            //Console.WriteLine($"C3 : {C3}");


            #endregion


            #region Relational operator 
            //Console.WriteLine(C1 > C2);
            //Console.WriteLine(C1 < C2);
            #endregion

            #region Casting operator
            //int Y = (int) C1;
            //string s = C1;
            #endregion



            #region businees Nedd for Casting operator
            // User user = new User()
            // {
            //     Id = 1,
            //     Name = "Rana Hatem",
            //     Email = "Rana@gmail.com",
            //     password = "2222@50",
            //     SecurityStmp = Guid.NewGuid(),

            // };
            // // Manual Mapping
            // UserViewModel userviewmodel = user;
            //Console.WriteLine( userviewmodel.ToString());

            #endregion


            #endregion

            #region Abstraction
            //Rect rect = new Rect() { Dim01 =10, Dim02 =5 };

            //Console.WriteLine (rect);
            //decimal par = rect.Parameter;
            //Console.WriteLine (par);

            //Circle ci = new Circle(3);
            //Console.WriteLine($"Parameter {ci.Parameter}  Area: {ci.calculateArea()}");

            #endregion

           // Utality ut = new Utality(1, 2);
           //Console.WriteLine( Utality.CmToInch(254));








        }
    }
}