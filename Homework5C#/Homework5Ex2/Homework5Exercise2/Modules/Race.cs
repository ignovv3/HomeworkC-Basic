using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5Exercise2.Modules
{
    internal class Race
    {
        private List<Car> cars;
        private List<Driver> drivers;
        private Car winner;

        public Race()
        {
            drivers = new List<Driver>
            {
                new Driver { Name = "Bob", Level = 3 },
                new Driver { Name = "Greg", Level = 2 },
                new Driver { Name = "Jill", Level = 4 },
                new Driver { Name = "Anne", Level = 5 },
            };

            cars = new List<Car>
            {
                new Car { Model = "Hyundai", Speed = 100 },
                new Car { Model = "Mazda", Speed = 100 },
                new Car { Model = "Ferrarri", Speed = 100 },
                new Car { Model = "Porsche", Speed = 100 },
            };
        }
    }
}
