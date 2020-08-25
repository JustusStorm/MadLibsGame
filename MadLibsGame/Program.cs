using System;
using System.Diagnostics;
using System.Threading;
using Custom;

namespace MadLibsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play Mad Libs!");
            UI.Spacer();
            string name = AskName();
            string noun = AskNoun();
            string verb = AskVerb();
            string place = AskPlace();
            UI.Spacer();

            string[] sentences =
            {
                $"Did you hear about what {name} did near the {place}? They said he {verb} their {noun} a little too hard last night.",
                $"I wonder how {name} feels about how Chad {verb} his {noun} behind the {place}.", 
                $"You see that {place}, thats where {name} {verb} with a {noun}a few days ago.",
                $"I told {name} to move thier {noun}, but they didn't, so I {verb} their {noun} all the way to the {place}", 
                $"I rode that {noun} so hard after {name} {verb} it at the {place}.",
                $"{name} said they {verb} {noun} at the {place}, and I got a video of it.",
                $"{name}'s {noun} fell out of their pocket in the middle of the {place}. I was really {verb}.",
                $"{name} painted a {noun} on the front of Jimmy's {place}. When he saw it he {verb} {name} worse than a fat kid eating cake. ",
                $"When we got closer to {name}'s {place}, Peyton {verb} thier {noun} like she had never seen it before.",
                $"{name} {verb} their little {noun} a little more when we arrived at {name}'s {place}."

            };

            UI.Spacer();
            Random rand = new Random();
            int index = rand.Next(0, sentences.Length);
            Console.WriteLine(sentences[index]);


        }
        static string AskName()
        {
            Console.Write("Enter a name:");
            return Console.ReadLine().Trim();
        }
        static string AskNoun()
        {
            Console.Write("Enter a noun(thing, animal, object, etc.):");
            return Console.ReadLine().Trim();
        }
        static string AskVerb()
        {
            Console.Write("Enter a action (verb, past tense):");
            return Console.ReadLine().Trim();
        }
        static string AskPlace()
        {
            Console.Write("Enter a place:");
            return Console.ReadLine().Trim();
        }
        
        

    }
}
    

