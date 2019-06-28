using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] row = new int[3] { 2, 4, 2 };
            int[,] grid = new int[2, 4];
            int[,,] grid3 = new int[3, 4, 2];

            Console.WriteLine("This is the rank of row " +row.Rank);
            Console.WriteLine("This is the length of row " +row.Length);

            Console.WriteLine("This is the Rank of grid " + grid.Rank);
            Console.WriteLine("This is the length of grid 2*4 :" + grid.Length);

            Console.WriteLine("This is the Rank of grid3 " + grid3.Rank);
            Console.WriteLine("This is the length of grid3 3*4*2 :" + grid3.Length);

           Array.Sort(row);
            Console.WriteLine( "this is the sort of row array"+row[0] +" -"+ row[1] + " -" + row[2] + " -" );

            int[] clone = (int[])row.Clone();

            Console.WriteLine(" this is a copy of the row (row.Clone)"+clone[0]);

            Array.Clear(row, 1, 2);
            for(int i =0; i < row.Length; i++)
            {
                Console.WriteLine("value of row after clear "+row[i]);
            }
            Console.ReadKey();



        }
    }
}
