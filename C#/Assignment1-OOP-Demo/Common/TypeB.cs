using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {
        public TypeB(int x)
        {  
             TypeA bb = new TypeA();
            bb.Y = x; // it works because Y is internal so we can access it inside its project

            //bb.X =3; // it's also gives an Error because it's private
        }

    }

}





