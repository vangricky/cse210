public class Resume
{
    public string Name;
    public List<Job> Jobs = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Jobs:");
        foreach (Job job in Jobs)
        {
            job.DisplayJobDetails();
        }
    }
}