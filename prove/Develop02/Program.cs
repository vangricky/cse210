using System;

class Program
{
    static void Main(string[] args)
    {
        //TODO:
        // Create a Journal Object
        // Prompt the User with menu

        List<string> prompts = new List<string>();

        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        // if user picks option to add a new entry
        // 1. Pick a random prompt from list above.
        // 2. Display the random selected prompt.
        // 3. Save response from user
        // 4. Create Response Object
        // 5. Save Response object to Journal Object

        Entry entry = new Entry();
        entry.EntryDate = DateTime.Now.ToShortDateString();
        entry.Prompt = ""; // from prompt above 
        entry.Response = ""; // pull from user's response

        Journal journal = new Journal();
        journal.JournalName = ""; // ask user for name
        journal.Entries = new List<Entry>();
        journal.Entries.Add(entry);

        // save jorunal to file system



    }
}