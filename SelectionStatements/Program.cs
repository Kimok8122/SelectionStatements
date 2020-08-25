using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------Excerise 1 if / else

            var r = new Random();  //assigns r a random number
            var favNumber = r.Next(1, 1000); // gens a random number 

            Console.WriteLine("Guess what number I'm thinking?");

            var userInput = int.Parse(Console.ReadLine());

            if(userInput < favNumber)
            {
                Console.WriteLine($"You guessed too low.");
            }
            else if(userInput > favNumber)
            {
                Console.WriteLine($"You guessed too high.");
            }
            else
            {
                Console.WriteLine("You got me!!!");
            }

        }
    }
}
