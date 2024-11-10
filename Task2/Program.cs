using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write(array[i] + " ");
            }
           
            int min = array[0];
            int max = array[0];

            Console.WriteLine();

            foreach (int j in array)
            {
                if (j > max)
                {
                    max = j;
                }
                else if (j < min)
                {
                    min = j;
                }
                else
                {

                }
            }

            int sum = min + max;
            Console.WriteLine($"Сумма наибольшего и наименьшего элементов массива равна: {sum}");

            Console.ReadKey();

        }
    }
}
