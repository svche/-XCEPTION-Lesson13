using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЕXCEPTION_Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {

            bool b = true;
            int num = 0;

            do
            {
                try
                {
                    num = numInput();

                    Console.WriteLine("Random Number is " + generate(num));
                    b = false;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Wrong input. " + fe.Message);
                }
                catch (ArithmeticException ae)
                {
                    Console.WriteLine("Wrong input. " + ae.Message);
                }
            } while (b);

            /////////////////////////////////////////////////////////
            //bool flag = true;
            //int num1, num2;
            //double div ;

            //do
            //{
            //    try
            //    {
            //        num1 = numInput();
            //        num2 = numInput();

            //        div = num1 / num2;
            //        Console.WriteLine("{0} / {1} = {2}", num1, num2, div);
            //        flag = false;

            //    }
            //    catch (DivideByZeroException dz)
            //    {
            //        Console.WriteLine(dz.Message);
            //    }
            //} while (flag);
            /////////////////////////////////////////////////////////////




            Console.ReadLine();
        }

        static int generate(int num)
        {
            int result;
            if (num < 0 || num > 255)
                {
                    throw new ArithmeticException();
                } else
                {
                    Random rand = new Random();
                    result = rand.Next(num);
                }
            return result;
        }

        static int numInput()
        {
            int num;
            Console.Write("Enter number : ");
            num = int.Parse(Console.ReadLine());

            return num;
        }
        
    }
}
