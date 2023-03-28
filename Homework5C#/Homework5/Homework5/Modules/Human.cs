using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5.Modules
{
    internal class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetHumanDetails()
        {
            return $"FullName: {FirstName} {LastName},\n {Age} years old! ";
        }
    }
}
