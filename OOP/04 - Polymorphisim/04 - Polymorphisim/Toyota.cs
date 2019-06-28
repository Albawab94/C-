using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Polymorphisim
{
    class Toyota : Cars
    {
        public int engineSize = 5;
        public string make = "Toyota";
        public void PrintEngi()
        {
            Console.WriteLine($"{engineSize}");
        }
         public override void printMake()
        {
            Console.WriteLine($"{make}");
        }
    
    }
}
