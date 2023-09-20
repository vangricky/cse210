using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //          WHILE LOOPS
        // string response = "yes";
        // while (response == "yes")
        // {
        //     Console.WriteLine("Do you want to continue? ");
        //     response = Console.ReadLine();
        // }
        
        //          DO-WHILE LOOPS
        // string response;
        // do 
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // } while (response == "yes");

        //          FOR LOOPS
        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        //          FOREACH LOOPS
        // foreach (string color in colors)
        // {
        //     Console.WriteLine(color);
        // }

        //          RANDOM NUMBERS
        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 11);


        //          Task #1
        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int theNumber = int.Parse(magicNumber);

        // Console.Write("What is your guess? ");
        // string guess = Console.ReadLine();
        // int yourGuess = int.Parse(guess);

        // if (yourGuess > theNumber)
        // {
        //     Console.WriteLine("Lower");
        // }
        // else if (yourGuess < theNumber)
        // {
        //     Console.WriteLine("Higher");
        // }
        // else
        // {
        //     Console.WriteLine("You Guessed it!");
        // }

        //          Task #2
        // Console.Write("What is the magic number? ");
        // int theNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int theNumber = randomGenerator.Next(1, 100);

        int yourGuess = 0;

        while (yourGuess != theNumber)
        {
            Console.Write("What is your guess? ");
            yourGuess = int.Parse(Console.ReadLine());

            if (yourGuess > theNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (yourGuess < theNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}