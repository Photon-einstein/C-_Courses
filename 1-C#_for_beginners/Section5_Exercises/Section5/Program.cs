using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Section5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ex1();
            ex2();
            ex3();
            ex4();
            ex5();
            /* freeze the console */
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
            return;

        }

        static void ex1()
        {
            // ex 1 
            int count = 0, min = 1, max = 100;
            for (int i = min; i <= max; ++i)
            {
                if (i % 3 == 0)
                {
                    ++count;
                }
            } 
            Console.WriteLine("Ex1: There are {0} numbers divible by 3 between {1} and {2}.", count, min, max);
        }

        static void ex2()
        {
            // ex 2 
            double number, sum = 0;
            string str;
            Console.WriteLine("\nEx2");
            while (true)
            {
                Console.WriteLine("Please enter a number or write 'ok' to exit.");
                str = Console.ReadLine();
                if (str.ToLower() == "ok")
                {
                    Console.WriteLine("The sum of all the numbers entered until now is {0}.", sum);
                    break;
                }
                sum += Convert.ToDouble(str);

            }
        }

        static void ex3()
        {
            // ex 3
            int nFac, fac = 1, i;
            string str;
            bool isNumber;
            Console.WriteLine("\nEx3:")
            while (true)
            {
                Console.WriteLine("Please enter a non negative number to make the calculation of the factorial.");
                str = Console.ReadLine();
                isNumber = int.TryParse(str, out nFac);
                if (isNumber == true && nFac >= 0)
                {
                    break;
                }
            }
            for (i = nFac; i > 1; --i)
            {
                fac *= i;
            }
            Console.WriteLine("{0}! = {1}", nFac, fac);
        }

        static void ex4()
        {
            // ex 4
            int guess, secret;
            Random rnd = new Random();
            secret = rnd.Next(1, 10);
            Console.WriteLine("Ex4");
            for (int i = 0; i < 4; ++i)
            {
                Console.WriteLine("\nPlease enter the guess of a random number between 1 and 10.");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == secret)
                {
                    Console.WriteLine("The guess was correct!");
                    break;
                }
                else
                {
                    Console.WriteLine("The guess was not correct!");
                }
            }
        }

        static void ex5()
        {
            /* ex 5 */
            string strCommas;
            int max = int.MinValue, n;
            Console.WriteLine("\nEx5: Please enter a series of numbers separated by commas.");
            strCommas = Console.ReadLine();
            string[] numbersS = strCommas.Split(',');
            foreach (string s in numbersS)
            {
                n = int.Parse(s);
                if (n > max)
                {
                    max = n;
                }
            }
            Console.WriteLine("The max value entered was {0}.", max);
        }


    }
}
