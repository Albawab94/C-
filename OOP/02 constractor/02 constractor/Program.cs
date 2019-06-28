using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_constractor
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "sam";
            int age = 3;
            Person myObject = new Person();
            myObject.print();

            Person sam = new Person(name,age);
            sam.print();

            Person rayan = new Person("rayan");
            rayan.print();
        }
    }
}
