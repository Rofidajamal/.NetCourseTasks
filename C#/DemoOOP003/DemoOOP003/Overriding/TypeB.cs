using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP003.Overriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int B, int A) : base(A)
        {
            this.B = B;
            
        }

        //Static Binding {Early binding}
        //Compilation time
        public new void function01() // New Version of the function 
        {
            Console.WriteLine("Child function");
        }

        //Dynamic binding {Late binding}
        // Running time 
        public override void function02() // Applying the overrideing
        {
            base.function02();
            Console.WriteLine($"B value: {B}");
        }
    }
}
