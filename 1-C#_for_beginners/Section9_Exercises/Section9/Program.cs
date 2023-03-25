using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Section9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ex1();
            ex2();
            /* freeze the console */
            Console.WriteLine("\nPress any key to close");
            Console.ReadKey();
        }

        static void ex1()
        {
            /* ex 1: 1- Write a program that reads a text file and displays the number of words. */
            string fileName = "./../../Input/AddContactActivity.java";
            string text = File.ReadAllText(fileName);
            int nWords = countWords(text);
            Console.WriteLine("\nEx1: It were detected {0} words in the file '{1}'.", nWords, fileName);
        }

        static void ex2()
        {
            /* ex 2: 2- Write a program that reads a text file and displays the longest word in the file. */
            string fileName2 = "./../../Input/AddContactActivity.java";
            string text2 = File.ReadAllText(fileName2);
            string longestWord = findLongestWord(text2);
            Console.WriteLine("\nEx2: The longest word in the file '{0}' is '{1}'.", fileName2, longestWord);
        }

        static int countWords(string text)
        {
            char[] separator = { ' ', ',', '\n' };
            string[] words = text.Split(separator);
            Console.WriteLine("Words detected: ");
            int count = 0;
            foreach(string word in words)
            {
                if (word.Length > 0)
                {
                    ++count;
                    Console.WriteLine(word);
                }
            }
            return count; 
        }

        static string findLongestWord(string text)
        {
            char[] separator = { ' ', ',', '\n' };
            string[] words = text.Split(separator);
            Console.WriteLine("Words detected: ");
            string res="";
            int maxLength = 0;
            foreach (string word in words)
            {
                if (word.Length > maxLength) 
                {
                    res = word;
                    maxLength = word.Length;
                }
            }
            return res;
        }

    }
}
