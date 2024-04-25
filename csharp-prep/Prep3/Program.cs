using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {

        //Console.Write("What is the magic number? ");
        Random random = new();
        string input = String.Empty;
        int magicNumber = random.Next(1, 101);
        int guessNumber = 0;
        int countGuesses = 0;
        do
        {
            Console.Write("What is your guess? ");
            input = Console.ReadLine();
            guessNumber = int.Parse(input);
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
            countGuesses++;
        } while (guessNumber != magicNumber);
        Console.WriteLine($"You guessed it in {countGuesses} times!");

    }
}