using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
           


            int[,] b = new int[2, 2];
            b[0, 0] = 5;
            b[0, 1] = 6;
            b[1, 0] = 7;
            b[1, 1] = 8;

            int[,] result = new int[2, 2];
            result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
            result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
            result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];

            input(a);
            Multiply(a,b);
            Output(result);
        }

        static void Output(int[,] result)
        {

            for(int i =0; i < result.GetLength(0); i++)
            {
                for (int y = 0; y < result.GetLength(1); y++)
                {
                    Console.WriteLine(result[i,y]);
                }
            }
        }



        static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[2, 2];
            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    result[r, c] += a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
                }
            }
            return result;
        }

        static void input(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int y = 0; y < a.GetLength(1); y++)
                {
                    int r = Int32.Parse(Console.ReadLine());
                    a[i, y] = r;
                }
            }
        }
    }
}
