using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Polymorphisim
{
    class Program
    {
        static void Main(string[] args)
        {
            Ford ford = new Ford();
            ford.printMake();

            Nissan nissan = new Nissan();
            nissan.printMake();


            Toyota toyota = new Toyota();
            toyota.printMake();
       
        }
    }
}
