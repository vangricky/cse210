using System;

class Program
{
    static Random random = new Random();

    static void Main()
    {
        Reference reference1 = new Reference("John", 11, 35);
        Scripture scripture1 = new Scripture(reference1, "Jesus wept");
        List<int> hiddenWordsIndices = new List<int>();
        List<int> hiddenWordsIndices2 = new List<int>();

        int totalWords1 = scripture1.GetWords().Count;
        Console.WriteLine("");
        // Console.WriteLine(reference1.GetString() + scripture1.GetRenderedText());
        // Console.Write("Press ENTER to hide a word.");
        // Console.ReadLine();

        while (hiddenWordsIndices.Count < totalWords1)
        {
            Console.WriteLine(reference1.GetString() + scripture1.GetRenderedText());
            Console.Write("Press ENTER to hide a word.");
            Console.ReadLine();

            int randomIndex;
            do
            {
                randomIndex = random.Next(totalWords1);
            } while (hiddenWordsIndices.Contains(randomIndex));

            scripture1.GetWords()[randomIndex].Hide();
            hiddenWordsIndices.Add(randomIndex);
        }

        Console.WriteLine("All words are now hidden.");

        Console.WriteLine("");
        Reference reference2 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture2 = new Scripture(reference2, "Trust in the Lord with all thine heart and lean not into thine own understandings. In all thy ways acknowledge him and he shall direct thy paths.");
        int totalWords2 = scripture2.GetWords().Count;
        Console.WriteLine("");

        while (hiddenWordsIndices2.Count < totalWords2)

        {
            Console.WriteLine(reference2.GetStringTwo() + scripture2.GetRenderedText());
            Console.Write("Press ENTER to hide a word.");
            Console.ReadLine();

            int randomIndex;
            do
            {
                randomIndex = random.Next(totalWords2);
            } while (hiddenWordsIndices2.Contains(randomIndex));

            scripture2.GetWords()[randomIndex].Hide();
            hiddenWordsIndices2.Add(randomIndex);
        }

        Console.WriteLine("All words are now hidden.");
    }
}