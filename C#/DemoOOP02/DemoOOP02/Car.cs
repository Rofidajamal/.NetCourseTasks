using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02
{
    internal class Car
    {
        private int id;
        private double speed;
        private string model;

        public Car(int _id, string _model, double _speed)
        {
            Console.WriteLine("Constructor 1");
            this.id = _id;
            this.model = _model;
            this.speed = _speed;
        }

        // Constructor Chaining 
        public Car(int _id) : this(_id, "BMW", 2500){
            Console.WriteLine("Constructor 2");
        } 

        public Car (int _id, string _model) : this(_id, _model, 2000) {
            Console.WriteLine("Constructor 3");
        }

        public override string ToString()
        {
            return $"ID: {id}\nModel: {model}\nSpeed: {speed}";
        }
    }
}
