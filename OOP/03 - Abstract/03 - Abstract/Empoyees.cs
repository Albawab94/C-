using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Abstract
{
   abstract class Empoyees
    {
        public string name = "Abdul";
        public string department;

        public void PrintName() {
            Console.WriteLine($"{name}");
        }

        public abstract void PrintDepart(); 
    }
}
