class Program
{
    static void Main()
    {
        var person = new Person();
        person.Name = "Joao";
        person.Job = "programmer";
        Console.WriteLine($"{ person.Name } is a { person.Job }");
    }
}

public class Person
{
    private string _name;
    public string Job;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    
}