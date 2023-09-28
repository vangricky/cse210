using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine("");

        //Job.cs
        Job job1 = new Job();
        job1.Company = "Tesla";
        job1.JobTitle = "Software Engineer";
        job1.StartYear = 1998;
        job1.EndYear = 2023;

        Job job2 = new Job();
        job2.Company = "The Church of Jesus Chris of Latter-day Saints";
        job2.JobTitle = "Web Developer";
        job2.StartYear = 2024;
        job2.EndYear = 2060;

        //Step 4
        Console.WriteLine("(Step 4)");
        Console.WriteLine(job1.JobTitle);
        Console.WriteLine("");

        //Step 5
        Console.WriteLine("(Step 5)");
        job1.DisplayJobDetails();

        Console.WriteLine("");
        //Resume.cs
        Resume resume1 = new Resume();
        resume1.Name = "Cheemeng Ricky Vang";
        resume1.Jobs.Add(job1);
        resume1.Jobs.Add(job2);

        resume1.DisplayResumeDetails();

    }
}