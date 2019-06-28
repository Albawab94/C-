using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type here your name");
            string name = Console.ReadLine();
            Console.WriteLine("type here your age");
            int age = Int32.Parse(Console.ReadLine());

            Person person = new Person();
            person.setName(name);
            person.SetAge(age);
            person.Print();
        }
    }
}
