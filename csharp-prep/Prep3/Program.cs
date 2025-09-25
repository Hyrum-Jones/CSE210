using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic numnber? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -1;
        int guessCount = 0;


        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it! ");
            }
        }

        Console.WriteLine($"It took you {guessCount} attempts to get the correct number! ");


    }
}