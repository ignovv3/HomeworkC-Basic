using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5Exercise2.Modules
{
    internal class Driver
    {
        public Driver()
        {
            
        }
        public Driver (string name, int level)
        {
            Name = name;
            Level = level; 
        }

        public string Name { get; set; }
        public int Level { get; set; }
    }
}
