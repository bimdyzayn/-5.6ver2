using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Алгоритмы 
{
    class Program
    {

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int[,] array = new int[x, x];


            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = (i + j) % 2 == 1 ? 0 : 1;

                    Console.Write("{0,3}", array[i, j]);
                }

            }


            Console.ReadKey();

        }

    }
}
