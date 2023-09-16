using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("");
        Console.Write("What is your grade percentage? ");
        string finalGrade = Console.ReadLine();
        int gradePercentage = int.Parse(finalGrade);

        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your final grade is A.");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your final grade is B.");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your final grade is C.");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your final grade is D.");
        }
        else 
        {
            Console.WriteLine("Your final grade is F.");
        }


        string letter = "";

        if (gradePercentage >= 90) 
        {
            letter = "A";
        }
        else if (gradePercentage >= 80) 
        {
            letter = "B";
        }
        else if (gradePercentage >= 70) 
        {
            letter = "C";
        }
        else if (gradePercentage >= 60) 
        {
            letter = "D";
        }
        else {
            letter = "F";
        }
        Console.WriteLine($"Your final grade is: {letter}");


        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congrats, you have passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, but you have failed this class. Try again next semester!");
        }
    }
}