using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Question1
{
    /*Define an interface named IShape with a property Area and a method DisplayShapeInfo. */
    internal interface IShape
    {

        public double Area { set; get; }

        public void DisplayShapeInfo();

    }
}
