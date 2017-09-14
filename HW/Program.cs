using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;
            int maxVal = 100;
            int[] array = new int[size];
            int sum;
            int ind1, ind2;

            Console.WriteLine("Addition two numbers from array\n");

            array = fillArrayRandom(size, maxVal);

            Console.WriteLine();

            bool flag = true;
            do
            {
                try
                {
                    ind1 = numInput();
                    ind2 = numInput();
                    sum = array[ind1] + array[ind2];
                    Console.WriteLine("{0} + {1} = {2} ", array[ind1], array[ind2], sum);
                    flag = false;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
                catch (IndexOutOfRangeException ie)
                {
                    Console.WriteLine(ie.Message);
                }

            } while (flag);


        }

        static int numInput()
        {
            Console.Write("\nWrite index of element: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static int[] fillArrayRandom(int size, int maxVal)
        {
            int[] array = new int[size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(maxVal);
                Console.Write(array[i] + "-{0} ", i + " ");
            }
            return array;
        }
       
    }
}
