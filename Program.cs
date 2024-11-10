using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Заполните масив: ");

            int[] array = new int[7];

            int sum = 0;
            int maxElements = array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                sum += array[i];

            }

            double averageValue = ((double)sum) / maxElements;
            Console.WriteLine("Среднее арифметическое знаачение: {0:f2}",  averageValue);

            Console.ReadKey();
        }
    }
}
