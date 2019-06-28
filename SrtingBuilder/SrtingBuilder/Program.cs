using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrtingBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();

            string bye = string.Empty;
            for (int i = 0; i < 20; i++)
            {
                stringBuilder.Append("Hello");

                stringBuilder.AppendFormat(i.ToString());
                stringBuilder.AppendLine();
                for (int l = 0; l < 4; l++)
                {
                    bye += "bye :"+ i+" - " +l +" \n ";
                }
            }
            stringBuilder.Append(bye);
            Console.WriteLine(stringBuilder);

            Console.ReadKey();
        }
    }
}
