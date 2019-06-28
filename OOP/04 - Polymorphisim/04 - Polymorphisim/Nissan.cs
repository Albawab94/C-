using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Polymorphisim
{
    class Nissan :Cars
    {
        public string make = "Nissan";
        public override void printMake()
        {
            Console.WriteLine($"{make}");
        }
    }
}
