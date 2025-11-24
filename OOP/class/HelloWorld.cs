namespace ConsoleApp;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Student s2 = new Student("Raihanul Islam", "CST", "2022-23", 789144);
        Student s1 = new Student("Saomi", "Computer Science and technology");
        Student s0 = new Student();

        Console.WriteLine("<<<<<--------------->>>>>>");
        s0.getInfo();
        Console.WriteLine("<<<<<--------------->>>>>>");
        s1.getInfo();
        Console.WriteLine("<<<<<--------------->>>>>>");
        s2.getInfo();
        Console.WriteLine("<<<<<--------------->>>>>>");
    }
}
