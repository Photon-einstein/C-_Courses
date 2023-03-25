using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Section8
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
        }

        static void ex1()
        {
            /* ex 1: 1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
            * Work out if the numbers are consecutive. 
            * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: 
            * "Consecutive"; otherwise, display "Not Consecutive".*/
            string[] numbersS;
            string commaList;
            Console.WriteLine("\nEx1: Please enter a series of hyphen separated number list.");
            commaList = Console.ReadLine();
            commaList = commaList.Trim('-');
            numbersS = commaList.Split('-');
            if (testConsecutiveNumbers(numbersS))
            {
                Console.WriteLine("The numbers {0} are consecutive numbers.", commaList);
            }
            else
            {
                Console.WriteLine("The numbers {0} are not consecutive numbers.", commaList);
            }
        }

        static void ex2()
        {
            /* ex 2: 2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
            * If the user simply presses Enter, without supplying an input, exit immediately; otherwise, 
            * check to see if there are duplicates. If so, display "Duplicate" on the console. */
            string[] numbersS2;
            string commaList2;
            Console.WriteLine("\nEx2: Please enter a series of hyphen separated number list.");
            commaList2 = Console.ReadLine();
            commaList2 = commaList2.Trim('-');
            numbersS2 = commaList2.Split('-');
            if (commaList2 == "")
            {
                Console.WriteLine("Invalid input.");
            }
            else if (testDuplicatedNumbers(numbersS2) == true)
            {
                Console.WriteLine("The numbers {0} have duplicated numbers.", commaList2);
            }
            else
            {
                Console.WriteLine("The numbers {0} haven't duplicated numbers.", commaList2);
            }
        }

        static void ex3()
        {
            /* ex 3: 3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
            * A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
            * If the user doesn't provide any values, consider it as invalid time. */
            Console.WriteLine("\nEx3: Please enter a valid 24-hour time format (e.g. 19:00).");
            string timeS = Console.ReadLine();
            if (String.IsNullOrEmpty(timeS) == true)
            {
                Console.WriteLine("Invalid time.");
            }
            DateTime dateTime;

            try
            {
                dateTime = DateTime.Parse(timeS);
                if (testValidTime(dateTime) == true)
                {
                    Console.WriteLine("Valid time. Ok");
                }
                else
                {
                    Console.WriteLine("Invalid time.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid time.");
            }
        }

        static void ex4()
        {
            /* ex 4: 4- Write a program and ask the user to enter a few words separated by a space. 
             * Use the words to create a variable name with PascalCase. For example, if the user types: 
             * "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. 
             * So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents". */
            string s, pascalCaseVariable;
            string[] sArray;
            Console.WriteLine("\nEx4: Please enter a few words separated by a space.");
            s = Console.ReadLine();
            s.Trim();
            sArray = s.Split(' ');
            if (sArray.Length == 0)
            {
                Console.WriteLine("Invalid input.");
            }
            pascalCaseVariable = getPascalCaseVariable(sArray);
            Console.WriteLine("New PascalCase variable: '{0}'.", pascalCaseVariable);
        }

        static void ex5()
        {
            /* ex 5: 5- Write a program and ask the user to enter an English word. 
            * Count the number of vowels (a, e, o, u, i) in the word. 
            * So, if the user enters "inadequate", the program should display 6 on the console. */
            string s;
            int nVowels;
            Console.WriteLine("\nEx5: Please enter an English word.");
            s = Console.ReadLine();
            nVowels = calcNumberOfVowels(s);
            Console.WriteLine("There are {0} vowels in the word {1}.", nVowels, s);
            /* freeze the console */
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        static bool testConsecutiveNumbers(string[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return false;
            }
            List<int> numbersList = new List<int>();
            int n, i;
            // conversion of strings into integers 
            foreach (string number in numbers)
            {
                if (Int32.TryParse(number, out n) == false)
                {
                    Console.WriteLine("Value {0} entered is not a number.", number);
                    return false;
                }
                else
                {
                    numbersList.Add(n);
                }
            }
            // test consecutive numbers
            for(i = 1; i < numbersList.Count; ++i)
            {
                if (Math.Abs(numbersList[i-1] - numbersList[i]) != 1)
                {
                    return false;
                }
            }
            return true;
        }

        static bool testDuplicatedNumbers(string[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return false;
            }
            List<int> numbersList = new List<int>();
            int n, i;
            // conversion of strings into integers 
            foreach (string number in numbers)
            {
                if (Int32.TryParse(number, out n) == false)
                {
                    Console.WriteLine("Value {0} entered is not a number.", number);
                    return true;
                }
                else
                {
                    numbersList.Add(n);
                }
            }
            numbersList.Sort();
            // test diferent numbers
            for (i = 1; i < numbersList.Count; ++i)
            {
                if (numbersList[i - 1] == numbersList[i])
                {
                    return true;
                }
            }
            return false;
        }

        static bool testValidTime(DateTime dateTime)
        {
            if (dateTime == null)
            {
                return false;
            }
            if (dateTime.Hour >= 0 && dateTime.Hour < 24 && dateTime.Minute >= 0 && dateTime.Minute < 60)
            {
                return true;
            } else
            {
                return false;
            }  
        }

        static string getPascalCaseVariable(string[] sArray)
        {
            string res="", aux;
            foreach(string s in sArray)
            {
                aux = "";
                for(int i = 0; i  < s.Length; ++i) { 
                    if (i == 0)
                    {
                        aux += Char.ToString(Char.ToUpper(s[0]));
                    } else
                    {
                        aux += char.ToLower(s[i]);
                    }
                }
                res += aux;
            }
            return res;
        }

        static int calcNumberOfVowels(string s)
        {
            int nVowels = 0;
            char test;
            foreach(char c in s)
            {
                test = Char.ToLower(c);                
                if (test == 'a' || test == 'e' || test == 'i' || test == 'o' || test == 'u')
                {
                    nVowels++;
                }
            }
            return nVowels;
        }


    }
}
