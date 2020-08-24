using System;

namespace MadLibsGame
{
    class Program
    {

        static void GetInput(out string input)
        {
            Console.WriteLine("> ");
            input = Console.ReadLine().ToLower().Trim();
            
        }




        static void StartGame()
        {
            string input;
            Console.WriteLine("Welcome to my Mad Libs game! Do you know how Mad Libs work?\n");
            GetInput(out input);

            if (input == "yes")
            {
                Console.WriteLine("Then lets get started!");
            } else if (input == "no")
            {
                Console.WriteLine("Okay, so I'm going to ask you to give me some information like nouns, adverbs, actions, etc. \n " +
                    "I'm going to use the answers you give me to place them in a funny sentence! Best part about it, you don't know \n" +
                    "what the sentence is going to be before you give me the answers.\n");
                Console.WriteLine("\n Do you understand how to play?\n");
                //Console.ReadLine()
                
            }
        }
        
        static void MadLibStory()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
