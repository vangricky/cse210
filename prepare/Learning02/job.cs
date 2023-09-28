public class Job
{
    public string Company;
    public string JobTitle;

    public double StartYear;

    public double EndYear ;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}