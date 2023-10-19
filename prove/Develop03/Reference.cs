public class Reference
{
    private string Book;
    private int Chapter;
    private int Verse;
    private int EndVerse;

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endverse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endverse;
    }

    public string GetString()
    {
        string text = $"{Book} {Chapter}: {Verse}";
        return text;
    }
}