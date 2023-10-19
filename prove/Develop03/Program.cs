using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("");

        Reference reference1 = new Reference("John", 11, 35);
        Console.WriteLine(reference1.GetString());

    }
}