using System;

namespace Greeting
{
    ///<summary>The Greeting class will print the value . The value is  "Hello world"</summary>
    class Greeting
    {
        static void Main(string[] args)
        {
            string myName;

            Console.Write("What is your name ?");
            myName = Console.ReadLine();

            Console.WriteLine("Hello {0}", myName);
            Console.ReadKey();
        }
    }
}
