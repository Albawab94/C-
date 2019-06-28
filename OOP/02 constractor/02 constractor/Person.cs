using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_constractor
{
    class Person
    {

        public string name;
        public int age;


        // default construtor
        public Person()
        {
            name = "Abdul";
            age = 33;
        }
        /// <summary>
        /// constructor
        /// </summary>
        public Person(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// constructor
        /// </summary>
        public Person(string value, int age)
        {
            name = value;
            this.age = age;
        }

        /// <summary>
        /// method 
        /// </summary>
        /// 
        public void print()
        {
            Console.WriteLine($"{name} and { age}");
        }
    }
}
