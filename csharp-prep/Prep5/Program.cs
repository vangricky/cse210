using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string firstName = Console.ReadLine();
        return firstName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        //Above, we needed to type 'int.Parse()' to 
        return favNumber;
    }
    static int SquareNumber(int favNumber)
    {
        int square = favNumber * favNumber;
        return square;
    }

    static void DisplayResult(string firstName, int square)
    {
        Console.WriteLine($"{firstName}, the square of your number is {square}");
    }
}
