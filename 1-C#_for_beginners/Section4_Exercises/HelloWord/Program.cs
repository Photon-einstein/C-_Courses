using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HelloWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ex0();
            ex1();
            ex2();
            ex3();
            ex4();
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
            return;
        }

        static void ex0()
        {
            Console.WriteLine("Ex0: Hello Word !");
        }

        static void ex1()
        {
            // ex 1
            Console.WriteLine("\nEx1: Please insert a number between 1 and 10.");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        static void ex2()
        {
            // ex 2
            Console.WriteLine("\nEx2");
            Console.WriteLine("Please insert number 1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert number 2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine("Max value is {0}", number1);
            }
            else if (number1 < number2)
            {
                Console.WriteLine("Max value is {0}", number2);
            }
            else
            {
                Console.WriteLine("Values are equal");
            }
        }

        static void ex3()
        {
            // ex 3
            Console.WriteLine("\nEx3");
            Console.WriteLine("Please insert width");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert height");
            int height = Convert.ToInt32(Console.ReadLine());
            if (height > width)
            {
                Console.WriteLine("Picture is a portrait.");
            }
            else
            {
                Console.WriteLine("Picture is a landscape");
            }
        }

        static void ex4()
        {
            /* ex 4 */
            Console.WriteLine("\nEx4");
            Console.WriteLine("Please insert the speed limit.");
            double speedLimit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please insert the speed of the car.");
            double speedCar = Convert.ToDouble(Console.ReadLine());
            if (speedCar < speedLimit)
            {
                Console.WriteLine("Ok.");
            }
            else
            {
                int demeritPoints = (int)(speedCar - speedLimit) / 5;
                Console.WriteLine("Demerit points: {0}", demeritPoints);
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License suspended.");
                }
            }
        }

    }
}
