using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
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
        }

        static void ex1()
        {
            List<string> likes = new List<string>();
            string likeName;
            while (true)
            {
                Console.WriteLine("Ex1: Please enter a like name to add to the list, press 'ENTER' to exit");
                likeName = Console.ReadLine();
                if (likeName == "")
                {
                    break;
                }
                likes.Add(likeName);
            }
            if (likes.Count == 1)
            {
                Console.WriteLine("{0} likes your post.", likes[0]);
            }
            else if (likes.Count == 2)
            {
                Console.WriteLine("{0} and {1} likes your post.", likes[0], likes[1]);
            }
            else if (likes.Count == 3)
            {
                Console.WriteLine("{0} and {1} and {2} other like your post.", likes[0], likes[1], likes.Count - 2);
            }
            else if (likes.Count > 4)
            {
                Console.WriteLine("{0} and {1} and {2} others like your post.", likes[0], likes[1], likes.Count - 2);
            }
        }

        static void ex2()
        {
            string name, nameInverted;
            char[] revNameArray;
            while (true)
            {
                Console.WriteLine("\nEx2: Please enter a name to be reversed.");
                name = Console.ReadLine();
                if (name != "")
                {
                    break;
                }
            }
            revNameArray = new char[name.Length];
            for (int i = name.Length - 1, j = 0; i >= 0; --i, ++j)
            {
                revNameArray[j] = name[i];
            }
            nameInverted = new string(revNameArray);
            Console.WriteLine("'{0}' inverted is '{1}'.", name, nameInverted);
        }

        static void ex3()
        {
            List<int> list = new List<int>();
            string valueS;
            int n;
            while (true)
            {
                Console.Write("\nEx3: Please enter a new unique number.\nValues already in memory: '");
                for (int i = 0; i<list.Count; i++)
                {
                    Console.Write("{0} ", list[i]);
                }
                Console.WriteLine("'");
                valueS = Console.ReadLine();
                if (int.TryParse(valueS, out n) == false)
                {
                Console.WriteLine("Value Entered is not an integer, please try again.");
                continue;
                }
                if (list.Contains(n) == false)
                {
                list.Add(n);
                }
                else
                {
                    Console.WriteLine("Value Entered is already in memory, please try again.");
                }
                /* break condition */
                if (list.Count == 5)
                {
                    break;
                }
            }
            list.Sort();
            Console.Write("Values in memory sorted: '");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0} ", list[i]);
            }
            Console.WriteLine("'");
        }

        static void ex4()
        {
            List<double> list2 = new List<double>();
            string valueS;
            double n2;
            while (true)
            {
                Console.WriteLine("\nEx4: Please enter a new number. Type \"Quit\" to exit.");
                valueS = Console.ReadLine();
                Console.WriteLine();
                if (valueS.ToLower() == "quit")
                {
                    break;
                }
                if (double.TryParse(valueS, out n2) == false)
                {
                    Console.WriteLine("Value Entered is not a number, please try again.");
                    continue;
                }
                if (list2.Contains(n2) == false)
                {
                    list2.Add(n2);
                }
            }
            Console.Write("Unique values in memory entered: '");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write("{0} ", list2[i]);
            }
        }

        static void ex5()
        {
            string commaList;
            string[] numbersS;
            double[] numbersD;
            List<double> numbers3 = new List<double>();
            double n3;
            List<double> list3 = new List<double>();
            while (true)
            {
                Console.WriteLine("\nEx5: Please enter a series of at least 5 comma separated number list.");
                commaList = Console.ReadLine();
                numbersS = commaList.Split(',');
                for (int i = 0; i < numbersS.Length; i++)
                {
                    if (double.TryParse(numbersS[i], out n3) == false)
                    {
                        Console.WriteLine("Value {0} entered is not a number.", numbersS[i]);
                    }
                    else
                    {
                        list3.Add(n3);
                    }
                }
                /* test list created */
                if (list3.Count == 0)
                {
                    Console.WriteLine("Invalid list, list is empty.");
                }
                else if (list3.Count < 5)
                {
                    Console.WriteLine("Invalid list, list has less than 5 elements.");
                    list3.Clear();
                }
                else
                {
                    list3.Sort();
                    Console.Write("The 3 smaller numbers entered were: '");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("{0} ", list3[i]);
                    }
                    Console.WriteLine("'");
                    break;
                }
            }
        }

    }
}
