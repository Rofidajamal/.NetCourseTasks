using System.Collections;
using System.Collections.Generic;

namespace DemoAdvancedCSharp2
{
    //Step 0: Decleration for Delegate
    public delegate int  StringFuncDelegate (string s);

    internal class program
    {
        public static void Main (string [] args)
        {
            #region Non-Genneric- Collection
            //ArrayList arrlist = new ArrayList(); // Non-Generic Collection
            //Console.WriteLine (arrlist.Count); // Return the actual elements in the list 
            //Console.WriteLine(arrlist.Capacity); // Elements that array can hold
            //arrlist.Add(1);
            //Console.WriteLine(arrlist.Count);  
            //Console.WriteLine(arrlist.Capacity); // Capacity = default capacity = 4

            //arrlist.Add (2);
            //Console.WriteLine(arrlist.Count);
            //Console.WriteLine(arrlist.Capacity);
            //arrlist.AddRange(new int[] { 1, 2, 3 });
            //Console.WriteLine(arrlist.Count); // To add more than one element

            //arrlist.TrimToSize(); // free unalocated places in the array list.
            //Console.WriteLine(arrlist.Count);
            //Console.WriteLine(arrlist.Capacity);

            //Console.WriteLine("============================================");
            //foreach (int i in arrlist)
            //{
            //    Console.WriteLine(i);
            //}

            //arrlist.Add("Rofida"); //No error but it gives an exception "Non-Generic" we deal with object- Casting
            //                       //Compiler will not enforce Type- Safty at compile time.

            #endregion

            #region Generic- Collections

            #region List
            //List<int> ts = new List<int>(); // The same as array list but generic (No casting)
            //Console.WriteLine(ts.Capacity);
            //Console.WriteLine(ts.Count);
            //ts.Add(5);

            //ts.AddRange(new int[] { 1, 2, 3, 4, 5 });
            //ts.Insert(0, 2); // Add element 2 at index 0
            //ts.InsertRange(ts.Count, new int []{ 5, 7, 8, 10}); // add elements to the list in an index
            //Console.WriteLine("==================================");
            //Console.WriteLine(ts.Count);
            //Console.WriteLine(ts.Capacity);

            //Console.WriteLine("==================================");
            //Console.WriteLine(ts.BinarySearch(3));
            //Console.WriteLine(ts.BinarySearch(6)); // -Num as it's not exist
            //Console.WriteLine(ts.Contains(6)); // retuens False 
            ////Console.WriteLine(ts.EnsureCapacity(20)); //Increase the capacity to the number

            //Console.WriteLine(ts.IndexOf(5));
            //Console.WriteLine(ts.LastIndexOf(7));



            //Console.WriteLine("==================================");

            //foreach (int i in ts)
            //{
            //    Console.WriteLine(i);
            //}
            //ts.Clear();

            //ts.Add("R"); // Gives me an Error at Compilation because it's type safty (Generic)

            //We can use indixer in updating or retive data but not adding (Invaliv).

            #endregion

            #region LinkedList
            //LinkedList<int> list = new LinkedList<int>(); 
            //Console.WriteLine (list.Count);
            //list.AddFirst (0);
            //list.AddAfter(list.Find(0), 5);
            //list.AddBefore(list.Find(5), 100);
            //list.AddLast (5);

            //Console.WriteLine(list.Count);

            //foreach (int i in list)
            //{
            //    Console.WriteLine (i);
            //}

            #endregion

            #region Stack
            //LIFO -> LAST INPUT , FIRST OUTPUT 
            //Stack<int> st = new Stack<int> ();
            //st.Push (1);
            //st.Push (2);
            //st.Push (3);
            //Console.WriteLine("===========================");
            //Console.WriteLine(st.Peek ()); // Return without removing it 
            //foreach (int i in st)
            //{
            //    Console.WriteLine (i);
            //}
            //Console.WriteLine("===========================");
            //Console.WriteLine (st.Pop()); // Return with removing it 
            //foreach (int i in st)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Queue
            //FIFO -> First In First Out

            //Queue<int> vs = new Queue<int>();
            //vs.Enqueue(1);
            //vs.Enqueue(2);
            //vs.Enqueue(3);
            //Console.WriteLine(vs.Count);

            //vs.Dequeue();
            //foreach (int i in vs)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion



            #region Dectionary
            //Dictionary<int, string> phoneBook = new Dictionary<int, string>();
            //phoneBook.Add(1, "Rofida");
            //phoneBook.Add(2, "Rahma");

            //if(!phoneBook.ContainsKey(1))
            //{
            //    phoneBook.Add(1, "Mona");
            //}

            //phoneBook.TryAdd(2, "Khamees");
            //foreach (KeyValuePair<int,string> item in phoneBook)
            //{
            //    Console.WriteLine(item);

            //}

            #endregion

            #region Hash-Set
            //HashSet<int> set = new HashSet<int> ();
            //set.Add (1);
            //set.Add (2);
            //set.Add (3);
            //set.Add (1); // Will not be added because elements in set are unique (No repetation)
            //foreach (int i in set)
            //{
            //    Console.WriteLine (i);

            //}

            #endregion






            #endregion


            #region Delegate 
            //Pointer ro Function

            int X = 3;
            // int Y = StringFunctions.GetCountUpperChars; //Invalid, use delegate insteade
            // step 1 Declare Reference for delegate

            // StringFuncDelegate stringdelegate = new StringFuncDelegate (StringFunctions.GetCountUpperChars);

            StringFuncDelegate stringdelegate = StringFunctions.GetCountUpperChars; //Syntax Sugar
           // int result = stringdelegate.Invoke("RofIDa");
           // Console.WriteLine(result);

            stringdelegate += StringFunctions.GetCountLowerChars;
           int result = stringdelegate.Invoke("Meow");
            Console.WriteLine(result);



            #endregion



        }
    }
}