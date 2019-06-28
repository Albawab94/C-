using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_firstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.enginSize = 4;
            Console.WriteLine(vehicle.manufacuter);
            Console.WriteLine(vehicle.enginSize);
        }
    }
}
