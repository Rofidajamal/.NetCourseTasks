using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment04.Abstract
{
    internal class Triangle: Shape

    {
        decimal Dim03 { get; set; }

        public override decimal Parameter { get { return 0.5m * Dim03 * Dim02; } }

        public Triangle (decimal dem1, decimal dem2 , decimal dem3) : base(dem1, dem2)
        {
            Dim01 = dem3;

        }

        public override decimal calculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
