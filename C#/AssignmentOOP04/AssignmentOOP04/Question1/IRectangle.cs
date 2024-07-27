using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04.Question1
{
    internal interface IRectangle: IShape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }
    }
}
