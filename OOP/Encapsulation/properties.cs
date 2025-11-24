namespace ConsoleApp;

public class Ex
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Ex first = new Ex();
        first.Name = "Lamia";
        Console.WriteLine(first.Name);
    }
}
