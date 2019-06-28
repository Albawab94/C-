using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_static
{
    class Static
    {
        public double balance;

        public static double newBalnce ;

        static Static()
        {
            newBalnce =9;
        }
        public void print(int n)
        {
            newBalnce = n;
            Console.WriteLine(newBalnce);
        }
    }

    static class StaticClass
    {
        static public string name = "Abdul";

        static public void n() {
            Console.WriteLine(name);
        }
    }
}
