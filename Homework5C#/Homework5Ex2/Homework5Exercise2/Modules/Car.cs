using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5Exercise2.Modules
{
    internal class Car
    {
        public Car()
        {
            
        }
        public Car (string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public float CalculateSpeed()
        {
            if(Driver == null)
            {
                throw new Exception("No driver assigned to the car! ");
            }
            return Driver.Level * Speed;
        }

    }
}
