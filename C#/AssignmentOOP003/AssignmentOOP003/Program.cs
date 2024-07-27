using AssignmentOOP003.Project_two;
using AssignmentOOP003.Project2;
using AssignmentOOP003.Project3;

namespace AssignmentOOP003
{
    internal class program
    {
        
        public static void Main (string[] args)
        {
            #region Project one

            // _3DPoints point1 = new _3DPoints();
            // Console.WriteLine("Enter 3 values of the first point");
            // point1.X = int.Parse(Console.ReadLine());
            // point1.Y= int.Parse(Console.ReadLine());
            // point1.Z = int.Parse(Console.ReadLine());

            // _3DPoints point2 = new _3DPoints();
            // Console.WriteLine("Enter 3 values of the second point");
            // int.TryParse(Console.ReadLine(), out int X);
            // point2.X = X;
            // int.TryParse(Console.ReadLine(), out int Y);
            // point2.Y = Y;
            // int.TryParse(Console.ReadLine(), out int Z);
            // point2.Z = Z;

            // Console.WriteLine($"Point 1 Data :\n{point1.ToString()}");
            // Console.WriteLine($"Point 1 Data :\n{point2.ToString()}");

            // if(point1 == point2) // it worked as if they are the same object (has the same hash code) but not checking on values
            // {
            //     Console.WriteLine("They are equal");
            // }
            // else
            // {
            //     Console.WriteLine("They are not equal");

            // }

            // //5.Define an array of points and sort this array based on X &Y coordinates.
            // _3DPoints [] points = { point1, point2, new _3DPoints(2,1,0)};
            //Array.Sort(points);
            // foreach(_3DPoints point in points)
            // {
            //     Console.WriteLine(point.ToString());
            // }

            // _3DPoints[] pointsClone = (_3DPoints[]) points.Clone();
            // Console.WriteLine(points.GetHashCode());
            // Console.WriteLine(pointsClone.GetHashCode());





            #endregion

            #region project two
            //Access the function without making an instance

            //Console.WriteLine( math.Add(3, 10));
            //Console.WriteLine( math.Subtract(3, 10));
            //Console.WriteLine(math.Multiply(3, 10));
            //Console.WriteLine (math.Devision(3, 10));

            #endregion

            #region project 3
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());

            Duration D2= new Duration(3600);
            Console.WriteLine(D2.ToString());

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());

            Duration D4= new Duration(666);
            Console.WriteLine(D4.ToString());

            //Duration sum = D1 + D2;
            //Console.WriteLine("Sum: "+ sum.ToString());

            //sum = D1 + 7800;
            //Console.WriteLine("Sum: " + sum.ToString());

            //sum = 666 + D3;
            //Console.WriteLine("Sum: " + sum.ToString());

            //Duration result = ++D1;
            //Console.WriteLine($"result : {result}");

            // result = --D1;
            //Console.WriteLine($"result : {result}");

            //Duration sub = D1 - D2;
            //Console.WriteLine("Sub: "+ sub.ToString());


            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj.ToString());


            #endregion

        }
    }

}
