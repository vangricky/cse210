public class Person
{
    public string GivenName = "";
    public string FamilyName = "";
    public Person()
    {

    }

    public void ShowEasternName()
    {
        Console.WriteLine($"{FamilyName}, {GivenName}");
    }
    public void ShowWesternName()
    {
        Console.WriteLine($"{GivenName} {FamilyName}");
    }
}