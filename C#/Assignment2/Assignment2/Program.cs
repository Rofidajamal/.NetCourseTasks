/* Rofida Gamal SUN-WED 7:30 Online */

#region Q1
/*1- Write a program that takes a number from the user 
 * then print yes if that number can be divided by 3 and 4 otherwise print no.*/
    int num = 0;
//num = int.Parse(Console.ReadLine());

//if (num % 3 == 0 && num % 4 == 0) {
//    Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}

#endregion

#region Q2
/*2- Write a program that allows the user to insert an integer then
 * print negative if it is negative number otherwise print positive.*/

//num = int.Parse(Console.ReadLine());
//if(num < 0)
//{
//    Console.WriteLine("It's a negative number");
//}
//else
//{
//    Console.WriteLine("It's a positive number");
//}
#endregion

#region Q3
/*3-  Write a program that takes 3 integers from the user then prints 
 * the max element and the min element.*/

//int x, y, z;
//x = int.Parse(Console.ReadLine()); 
//y = int.Parse(Console.ReadLine()); 
//z = int.Parse(Console.ReadLine());

//if(y> x && y> z)
//{
//    Console.WriteLine($"The max elememt is {y}");
//}
//else if (z> x && z> y)
//{
//    Console.WriteLine($"The max elememt is {z}");
//}
//else { 
//    Console.WriteLine($"The max elememt is {x}");
//}

//if (y < x && y < z)
//{
//    Console.WriteLine($"The min elememt is {y}");
//}
//else if (z < x && z < y)
//{
//    Console.WriteLine($"The min elememt is {z}");
//}
//else
//{
//    Console.WriteLine($"The min elememt is {x}");
//}
#endregion

#region Q4
/*Write a program that allows the user to insert an integer 
 * number then check If a number is even or odd.*/
//num = int.Parse(Console.ReadLine());

//if(num%2 == 0)
//{
//    Console.WriteLine("It's an even number");
//}
//else
//{
//    Console.WriteLine("It's an odd number");

//}
#endregion

#region Q5
/*5- Write a program that takes character from the user then if it is a
 * vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).*/

//char c = char.Parse(Console.ReadLine());
//switch (c)
//{
//    case 'a':
//    case 'A':
//        goto case 'u';
//        break;
//    case 'e':
//    case 'E':
//        goto case 'u';
//        break;
//    case'i':
//    case 'I':
//        goto case 'u';
//        break;
//    case 'o':
//    case 'O':
//        goto case 'u';
//        break;
//    case 'u':
//    case 'U':
//        Console.WriteLine("Vowel");

//        break;
//    default:
//        Console.WriteLine("Constant");
//        break;

//};

#endregion

#region Q6
/*6- Write a program that allows the user to insert an integer then
 * print all numbers between 1 to that number.*/
//num = int.Parse(Console.ReadLine());

//for (int i = 1; i <num; i++)
//{
//    Console.WriteLine(i);
//}


#endregion

#region Q7
/*7- Write a program that allows the user to insert an integer then 
print a multiplication table up to 12.
*/

//num = int.Parse(Console.ReadLine());
//for(int i = 1; i <= 12; i++)
//{
//    Console.WriteLine($"{i} * {num} = {i*num}");
//}
#endregion

#region Q8
/*8- Write a program that allows to user to insert number 
 * then print all even numbers between 1 to this number*/
//num = int.Parse(Console.ReadLine());

//for (int i = 1; i < num; i++)
//{
//    if(i%2== 0)
//        Console.WriteLine(i);
//}

#endregion

#region Q9
/* 9- Write a program that takes two integers then prints the power.*/
//num = int.Parse(Console.ReadLine());
//int pow = int.Parse(Console.ReadLine());
//int result = 1;

//for(int i = 0; i < pow; i++)
//{
//    result = result * num;

//}
//Console.WriteLine(result);
#endregion

#region Q10
/*10- Write a program to enter marks of five subjects and calculate total,
 * average and percentage.*/
//double grade =0;
//double sum = 0;
//double average = 0;
//for (int i = 0; i < 5; i++)
//{
//    grade = int.Parse(Console.ReadLine());
//    sum+= grade;
//}
//average = sum / 5;
//Console.WriteLine($"Total = {sum}\nAverage = {average}\nPercentage = {average} ");

#endregion

#region Q11
/*11- Write a program to input the month number
 * and print the number of days in that month.*/

//num = int.Parse(Console.ReadLine());
//if (num == 1 || num == 3 || num == 5 || num == 7
//    || num == 8 || num == 10 || num == 12) {
//    Console.WriteLine("this Month is 31 Days");

//}
//else if (num == 2)
//{
//    Console.WriteLine("This month is 28 or 29 days");
//}
//else {
//    Console.WriteLine("this month is 30 days"); }
#endregion

#region Q12
/*Write a program to create a Simple Calculator.*/

//int x, y;
//x = int.Parse(Console.ReadLine());
//y = int.Parse(Console.ReadLine());

//char opr = char.Parse(Console.ReadLine());

//switch (opr)
//{
//    case '+':
//        Console.WriteLine($"x + y = {x + y}");
//        break;
//    case '-':
//        if(x >y)
//            Console.WriteLine($"x-y = {x-y}");
//        else
//            Console.WriteLine($"y-x = {y - x}");
//        break;
//    case '*':
//        Console.WriteLine($"x*y = {x*y}");
//        break;
//    case '/':
//        if(y!= 0)
//            Console.WriteLine($"x/y = {x / y}");
//        else
//            Console.WriteLine("ERROR, You can devide over Zero");
//        break;
//    default:
//        Console.WriteLine("ERROR invalid operator");
//        break;
//};
#endregion

#region Q13
/*13- Write a program to allow the user to enter a string
 * and print the REVERSE of it.*/

//string statement = Console.ReadLine();
//for (int i = statement.Length-1; i>=0; i--)
//{
//    Console.WriteLine(statement[i]);
//}
#endregion

#region Q14
/*14- Write a program to allow the user to enter int
 * and print the REVERSED of it.*/
//num = int.Parse(Console.ReadLine());

//int _bit = 0;
//while (num!= 0)
//{
//    _bit = num % 10;
//    Console.WriteLine(_bit);
//    num = num / 10;
//}

#endregion

#region Q15
/*Write a program in C# Sharp to find prime numbers within a range of numbers.*/

//Console.WriteLine("Enter the start number");
//int p1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the start number");
//int p2 = int.Parse(Console.ReadLine());
//int flag = 1;
//Console.WriteLine("The prime number between 1 and 50 are: ");
//for(int i = p1; i <= p2; i++)
//{
//    flag = 1;
//    for (int j = 2; j <= 10; j++)
//    {
//        if (i != j)
//        {
//            if (i % j == 0)
//            {
//                flag = 0;
//                break;
//            }
//        }

//    }
//    if(flag == 1 && i !=1)
//    {
//        Console.WriteLine(i);

//    }

//}

#endregion

#region Q16
/*16- . Write a program in C# Sharp to convert a decimal number
 * into binary without using an array.*/

    //num = int.Parse(Console.ReadLine());
    //string result="";
    //while (num > 0)
    //{
    //    int _bit = num % 2;
    //    result = _bit.ToString() + result;
    //    num = num/ 2;
    //}
    //Console.WriteLine(result);
#endregion