using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDemoOOP
{
    internal class Car
    {

        #region Attributes and Properties

        public int Id
        {
            get;
            set;
        }

        private string Model { get; set; }
        private double Speed { get; set; }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"ID: {Id}   Mode: {Model}   Speed: {Speed}";
        }
        #endregion

        #region Constructors
        public Car(int id, string model, double speed)
        {
            Id = id; 
            Model = model;
            Speed = speed; 
        }

        public  Car(int id, string model)
        {
            Id=id;
            Model = model;
            Speed = 000;
        }

        public Car()
        {
            Id = 00;
            Model = "  ";
            Speed = 000;
        }

        #endregion
    }
}
