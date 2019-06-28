using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Inheritance
{
    class Cars
    {
        // The relation is "is a kind"
       public string model;
       public string make;
        string year;

        public void printModel()
        {
            Console.WriteLine($"{model}");
        }


    }
}
