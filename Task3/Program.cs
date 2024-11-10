using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write(array[i] + " ");
            }

            

            Console.WriteLine();

           for (int i = 0; i < 9; i++)
            {
                if (i < 4)
                {
                    for (int j = i + 1; j < 5; j++)
                    {

                        if (array[i] > array[j])
                        {
                            int min = array[i];
                            array[i] = array[j];
                            array[j] = min;
                        }
                    }

                }
                else
                {
                    for (int j = i + 1; j < 10; j++)
                    {

                        if (array[i] < array[j])
                        {
                            int max = array[i];
                            array[i] = array[j];
                            array[j] = max;
                        }
                    }
                }
                
                
            }

            for (int i = 0; i < 10; i ++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
