using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP003.Overriding
{
    internal class TypeA
    {
        public int A {get; set;}
        public TypeA(int A)
        {
            this.A = A;

        }
        
        public void function01() 
        {
            Console.WriteLine("I'm parent base");
        }

        public virtual void function02()  
        {
            Console.WriteLine($"A value : {A}");

        }
        
    }
}
