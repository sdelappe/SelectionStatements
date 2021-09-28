using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 27;

            Console.Write("Guess my favorite number: ");

            var userInput = int.Parse(Console.ReadLine());

            while (userInput != favNumber)
            {
                if (userInput < favNumber)
                {
                    Console.Write("Nope, too low. Try again: ");
                    userInput = int.Parse(Console.ReadLine());
                }
                else if (userInput > favNumber)
                {
                    Console.Write("Nope, too high. Try again: ");
                    userInput = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Nevermind.");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("What is your favorite subject in school: ");

            string favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "Chemistry":
                    Console.WriteLine("Your favorite subject is chemistry. Nerd!");
                    break;
                case "Biology":
                    Console.WriteLine("Biology, how fascinating.");
                    break;
                case "History":
                    Console.WriteLine("You find history to be the most interesting thing you study...?");
                    break;
                case "Art":
                    Console.WriteLine("Well well well, aren't you special.");
                    break;
                case "Gym":
                    Console.WriteLine("Pfff, all brawn and no brain. How sad.");
                    break;
                default:
                    Console.WriteLine("I don't know that one");
                    break;
            }
        }
    }
}
