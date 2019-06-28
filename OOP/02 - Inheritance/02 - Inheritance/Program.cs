using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars();
            car.model = "Corsa";
            car.printModel();

            Toyota MyToyota = new Toyota();
            MyToyota.model= "Toyota";
            MyToyota.printModel();
            

            
        }
    }
}
