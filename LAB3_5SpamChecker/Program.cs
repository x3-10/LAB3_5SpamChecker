using System;

namespace LAB3_5SpamChecker
{
    class Program
    {
        //updated and works but needs refactoring
        //-more words in blacklist
        //-resolve Uppercase and lowercase issue with words
        //-use of external db or flatfile that is easy to update
        //   without having to update the code
        //- added by in 06 23 2020
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
