using System;
using System.Diagnostics;
using System.Threading;

namespace MadLibsGame
{
    class Program
    {

        // creates a little banner to use to seperate chunks of information
        static void Banner()
        {
            Console.WriteLine("**********************************************************************************");
        }

        // use this to print a statement to the user telling them their input is invalid for a yes or no question
        static void InvalidInputYesNo()
        {
            string input;
            do
            {
                Console.WriteLine("\n Your input is an invalid answer. Please type yes or no in the input.\n");
                Console.Write("> ");
                input = Console.ReadLine().ToLower().Trim();
            } while (input != "yes" || input != "no") ;
        }



        // function that allows you to take input from the user
        static void GetInput(out string input)
        {
            Console.Write("> ");
            input = Console.ReadLine().ToLower().Trim();

        }



        // Function to start the game, making sure user knows how game is played and explains how to play
        static void StartGame()
        {
            string y = "yes";
            string n = "no";
            string input;


            Console.WriteLine("Welcome to my Mad Libs game! Do you know how Mad Libs work? (yes/no) \n");
            GetInput(out input);

            if (input == "yes")
            {
                Console.WriteLine("\nThen lets get started!\n");
            }
            else if (input == "no")
            {
                Console.WriteLine("\n Okay, so I'm going to ask you to give me some information like nouns, adverbs, actions, etc. \n " +
                    "I'm going to use the answers you give me to place them in a funny sentence! Best part about it, you don't know \n" +
                    "what the sentence is going to be before you give me the answers.\n");

                Console.WriteLine("\n Do you understand how to play? (yes/no) \n");
                GetInput(out input);

                if (input == "yes")
                {
                    Console.WriteLine("\n Lets play!\n");
                }
                else
                {
                    Console.WriteLine("\n Go to Google and look up MadLibs for more information on the game style.\n");
                }
            }
            else
            {
                InvalidInputYesNo();

            }
        }
            



        












        // Start of Program

        static void Main(string[] args)
        {
            Banner();

            StartGame();
            Thread.Sleep(2000); // allows 2 seconds between last input in StartGame() and clearing the terminal
            Console.Clear();

            // Console.WriteLine("Test");
        }
    }
}
    

