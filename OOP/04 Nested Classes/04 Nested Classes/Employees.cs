using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Nested_Classes
{
    class Employees
    {
        public string name = "Abdu";
        public int age = 33;
        public void print()
        {
            Console.WriteLine(name+" - "+age);
        }

        public class Department
        {
            public string departmentName = "administration";

            public void print()
            {
                Console.WriteLine(departmentName);
            }
        }
    }

}
