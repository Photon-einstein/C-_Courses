using System;

namespace Section_1_Exercise_2_StackOverFlowPost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercise 2: Design a StackOverflow PostDesign a class called Post.
             * This class models a StackOverflow post.It should have properties 
             * for title, description and the date/time it was created.
             * We should be able to up-vote or down-vote a post.
             * We should also be able to see the current vote value.
             * In the main method, create a post, up-vote and down-vote it a few times 
             * and then display the the current vote value.
             * In this exercise, you will learn that a StackOverflow post should provide methods 
             * for up-voting and down-voting.You should not give the ability to set the Vote property 
             * from the outside, because otherwise, you may accidentally change the votes of a class 
             * to 0 or to a random number.And this is how we create bugs in our programs. 
             * The class should always protect its state and hide its implementation detail. */
            Post p = new Post("Advanced Encryption Standart (AES)",
                "The Advanced Encryption Standard (AES) is a symmetric block cipher chosen by the U.S. government\n" +
                "to protect classified information.\n\n" +
                "AES is implemented in software and hardware throughout the world to encrypt sensitive data.\r\nIt is essential for government computer security, " +
                "cybersecurity and electronic data protection.\n" +
                "The National Institute of Standards and Technology (NIST) started development of AES in 1997\nwhen it announced the need for an alternative to the\n" +
                "Data Encryption Standard (DES), which was starting to become vulnerable to brute-force attacks.", DateTime.Now);
            p.DisplayPost();
            p.UpVote();
            p.UpVote();
            p.DisplayPost();
            /* freeze the console */
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
