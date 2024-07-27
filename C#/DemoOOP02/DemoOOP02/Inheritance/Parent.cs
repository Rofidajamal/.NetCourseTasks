using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Inheritance
{
    internal class Parent
    {
        #region Attributes
        public int X
        { set;
          get;
        }

        public int Y
        {
            set;
            get;
        }
        #endregion

        #region Constructor
        public Parent(int _X, int _Y)
        {
            X = _X;
            Y = _Y;

        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"X: {X}    Y: {Y}";
        }

        #endregion
    }

}
