using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Polymorphisim
{
    class Ford :Cars
    {
        public string make = "Ford";
        public override void printMake()
        {
            Console.WriteLine($"{make}");
        }
    }
}
