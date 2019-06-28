using System;

namespace _03_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Static s = new Static();
            s.balance = 4;
            s.print(7);

            Static.newBalnce = 2;
            Console.WriteLine( Static.newBalnce);

            // Static class
            //  StaticClass staticClass = new StaticClass(); fout Error

            StaticClass.n();
        }
    }
}
