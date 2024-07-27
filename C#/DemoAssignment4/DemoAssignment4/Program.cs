using System.Text;
#region Loops
#region For loop
//Process withou loop
//Console.WriteLine(1);
//Console.WriteLine(2);
//Console.WriteLine(3);
//Console.WriteLine(4);
//Console.WriteLine(5);    
//Console.WriteLine(6);
//Console.WriteLine(7);
//Console.WriteLine(8);
//Console.WriteLine(9);
//Console.WriteLine(10);
//Console.WriteLine("*********************");
//for(int i = 1; i<=10; i++)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("*********************");
//// or we can use arrays

//int [] Numbers = {1,2,3,4,5,6,7,8,9,10};
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(Numbers[i]);
//}

#endregion

#region Foreach

//int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//foreach(int number in Numbers)
//{
//    Console.WriteLine(number);
//}

#endregion

#region Do-While
//int Nummber;
//bool flag;

//do
//{
//    Console.WriteLine("Enter an Even Number");
//    flag = int.TryParse(Console.ReadLine(), out Nummber);

//}
//while (Nummber %2 ==1 || !flag);

//Console.WriteLine($"You entered {Nummber}");

#endregion

#region While
//int x = 4;
//while (x%2 == 0)
//{
//    Console.WriteLine("Even number \nplease enter an odd number");
//    x = int.Parse(Console.ReadLine());

//}
//Console.WriteLine($"odd number {x}");

#endregion

#endregion

#region String vs StringBuilder
#region String 

//string name = "Rahma"; // Syntax suger
//string Name01 = "Ahmed";
//string Name02 = "Omar";
//Name01 = "Rofida";
//Console.WriteLine(Name01);
//Console.WriteLine(Name02);
//Console.WriteLine(Name01.GetHashCode());
//Console.WriteLine(Name02.GetHashCode());
//// String is a Refrence type and immutable 
//// so the hashcode of two variables are different

//string Message = new string("Hello");
//Console.WriteLine(Message);
//Message += "Route"; // create a new object with different new identity

#endregion

#region StringBuilder
//StringBuilder SB = new StringBuilder(); // is a Reference type but mutable 
//SB.Append("Hello");
//Console.WriteLine(SB);
//Console.WriteLine(SB.GetHashCode());
//SB.Append("Route");
//Console.WriteLine(SB);
//Console.WriteLine(SB.GetHashCode()); // has the same hashCode



#endregion


#endregion

#region Arrays

#region 1D array
//int[] Numbers;
//Numbers = new int[10]; // Default values of the array is ZERO 0.
//Console.WriteLine(Numbers[0]);
//Numbers[0] = 10;
//Console.WriteLine(Numbers[0]);

//int [] Numbers2 = new int[] {1,2,3};

//Console.WriteLine(Numbers2.Length +" " + Numbers2.Rank);

//for(int i = 0; i < Numbers2.Length ; i++)
//{
//    Console.WriteLine(Numbers2[i]);

//}


#endregion

#region 2D array
//int[,] mat = new int[2,4] { { 1,2,3,4}, { 5, 6, 7, 8 } };
//Console.WriteLine(mat.Length + " " + mat.Rank);

//int[,] marks = new int[2, 4];
//Console.WriteLine(marks.GetLength(0)); // to return the count of rows
//Console.WriteLine(marks.GetLength(1)); // to return the count of columns

//// nested loops to take the value
//for(int i = 0; i < marks.GetLength(0); i++)
//{
//    Console.WriteLine($"Enter thr marks of student {i+1}");
//    for(int j = 0; j < marks.GetLength(1); j++)
//    {
//        marks[i, j] = int.Parse(Console.ReadLine());
//    }
//}

//Console.WriteLine("*******************************");
//Console.WriteLine("*******************************");

//// nested loops to print

//for (int i = 0; i < marks.GetLength(0); i++)
//{
//    Console.WriteLine($"The Markes of srudent {i + 1}");
//    for(int j = 0;j < marks.GetLength(1); j++)
//    {
//        Console.WriteLine($"The grade of subject {j + 1}: {marks[i,j]}");
//    }

//    Console.WriteLine("\n");
//}


#endregion

#endregion

#region Boxing vs UnBoxing

// Boxing Casting from data type (Value type) to Date type (Reference Type)
// UnBoxing Casting from data type (Reference type) to Date type (Value Type)
#region Example01
//object obj = null;

//obj = new object();
//obj = new string("Rofida");
//obj = 'A'; // Casting Char (Value type)  to Object (Reference type) -> Implicity (Boxing)
//obj = 10; // Casting int (Value type)  to Object (Reference type) -> Implicity (Boxing)

//obj = true;
//bool flag = (bool)obj; // Explicit cating - UnBoxing - Unsafe Casting

#endregion

#region Example02
//int x = 5;
//object o1 = x; // Casting from int to object -> Boxing

//Console.WriteLine(o1);

//object o2;
//o2 = "Ahmed";
//int Y = (int)o2; // UNSAFE UnBoxing



#endregion



#endregion

