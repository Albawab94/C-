using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Abstract
{
    class HR:Empoyees
    {
        public override void PrintDepart()
        {
            Console.WriteLine(department);
        }
    }
}
