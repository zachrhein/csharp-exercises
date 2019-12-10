using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm doing a giveaway!");
            Console.WriteLine("Please pick a number from 1-10. ");
            string user = Console.ReadLine();

            string winner = "";
            if (user == "3")
               winner = "You have won a new car!";
            else if (user == "4")
                winner = "you were so close! Sorry, you didn't win";
            else
            { 
                winner = "sorry, you did not win this time";
            }

            Console.WriteLine("You entered {0}, {1}", user, winner);
            Console.ReadLine();

        }
    }
}
