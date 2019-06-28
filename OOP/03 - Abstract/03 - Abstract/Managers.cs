using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Abstract
{
    class Managers : Empoyees
    {
        public override void PrintDepart() {
            Console.WriteLine($"{department}");
        }
    }
}
