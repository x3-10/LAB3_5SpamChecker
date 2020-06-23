using System;

namespace LAB3_5SpamChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a message.");
            string blackListWord = "Viagra";
            bool isSpam = false;
            string message = Console.ReadLine();

            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("The message is spam");
            }
            else
            {
                Console.WriteLine("The message is not spam.");

            }
        }
    }
}
