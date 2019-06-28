using System;

namespace _01_Methods
{
    class ExampleClass
    {
        static void Main()// eerste Method
        {
            Console.WriteLine("I am a Main metod");
            ExampleMetod("Hoi parameters");
            Console.WriteLine("I am a Main method ");

            Console.WriteLine();
            SecondClass.secondClass();
            Console.ReadKey();
        }
        static void ExampleMetod(string i) // Second Method
        {
            Console.WriteLine(i);
            Console.WriteLine("Hello Method"); // writeline . derde method
            SecondClass.secondClass();
        }
    }

    class SecondClass
    {
       public static void secondClass()
        {
            Console.WriteLine("I am a method from secondClass");
        }
    }
}
