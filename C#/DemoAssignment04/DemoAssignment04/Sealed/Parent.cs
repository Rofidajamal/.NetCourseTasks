using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment04.Sealed
{
    internal class Parent
    {
        public virtual void PRINT()
        {
            Console.WriteLine("Iam Parent");
        }
    }

    internal class Child : Parent
    {
       sealed  override public void PRINT() {
            Console.WriteLine("Iam Child");
        }
    }

    //Sealed child
    internal sealed class GrandChild : Child
    {
        //ERROR -> Sealed method
        //public override void PRINT() {
        //    Console.WriteLine("I'm grand child")
        //}

    }
}
