using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        // //      MAKING LISTS IN C#
        // List<int> numbers = new List<int>();
        // List<string> words = new List<string>();

        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        // //          GETTING THE LIST SIZE
        // Console.WriteLine("GETTING THE LIST SIZE!");
        // Console.WriteLine(words.Count);

        // Console.WriteLine("");

        // //          ITERATING THROUGH A LIST
        // Console.WriteLine("ITERATING THROUGH A LIST!");
        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

        List<int> everyNumber = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int yourNumber = -1;

        while (yourNumber != 0)
        {
            Console.Write("Enter number: ");
            everyNumber.Add(int.Parse(Console.ReadLine()));
        }


    }
}