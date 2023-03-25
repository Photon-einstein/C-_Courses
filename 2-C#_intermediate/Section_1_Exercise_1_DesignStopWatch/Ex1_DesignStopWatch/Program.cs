
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_DesignStopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercise 1: Design a StopwatchDesign a class called Stopwatch. 
             * The job of this class is to simulate a stopwatch. 
             * It should provide two methods: Start and Stop. 
             * We call the start method first, and the stop method next. 
             * Then we ask the stopwatch about the duration between start and stop. 
             * Duration should be a value in TimeSpan. Display the duration on the console. 
             * We should also be able to use a stopwatch multiple times. 
             * So we may start and stop it and then start and stop it again. 
             * Make sure the duration value each time is calculated properly. 
             * We should not be able to start a stopwatch twice in a row 
             * (because that may overwrite the initial start time). 
             * So the class should throw an InvalidOperationException if its started twice. */
             
            StopWatch stopWatch= new StopWatch();
            string s;
            /* test 1: should throw */
            try
            {
                stopWatch.Start();
                stopWatch.Start();
            }
            catch (InvalidOperationException ex) { 
                Console.WriteLine(ex.Message);
            }
            /* test 2: 1s interval */
            try
            {
                stopWatch.Start();
                System.Threading.Thread.Sleep(1000);
                stopWatch.Stop();
                stopWatch.Duration();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            do
            {
                Console.WriteLine("\nPress '1' to start the timer, '2' to stop the timer or 'q' to quit the simulation.");
                s = Console.ReadLine();
                if (s == "1")
                {
                    try
                    {
                        stopWatch.Start();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } else if (s == "2")
                {
                    try
                    {
                        stopWatch.Stop();
                        stopWatch.Duration();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } else if (s.ToLower() == "q")
                {
                    break;
                } else
                {
                    Console.WriteLine("Invalid character.");
                }
            } while (true);
            /* freeze the console */
            Console.WriteLine("Press any key to close");
            Console.ReadKey();

        }
    }
}
