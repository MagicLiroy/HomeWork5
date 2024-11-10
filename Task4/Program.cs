using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[size, size];

            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 0; j < size; j++)
                    {
                        array[i, j] = (j % 2 != 0) ? 1 : 0;

                        Console.Write($"{array[i, j]} ");

                    }
                    Console.WriteLine();

                }
                else
                {
                    for (int j = 0; j < size; j++)
                    {
                        
                         array[i, j] = (j % 2 != 0) ? 0 : 1;

                         Console.Write($"{array[i, j]} ");

                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
