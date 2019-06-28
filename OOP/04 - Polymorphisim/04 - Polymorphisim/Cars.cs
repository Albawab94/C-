using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Polymorphisim
{
    class Cars
    {
        public string enigneCapacity = "2.4L";
        public void PrintCapacity()
        {
            Console.WriteLine($"{enigneCapacity}");
        }

        public virtual void printMake()
        {

        }
    }
}
