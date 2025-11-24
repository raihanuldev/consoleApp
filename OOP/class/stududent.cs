namespace ConsoleApp;

public class Student
{
    public string name;
    public string dep;
    public string session;
    public int roll;

    public Student()
    {
        name = "Unknown";
        dep = "Unknown";
        session = "Unknown";
        roll = 0;
    }

    public Student(string sName, string sDep)
    {
        name = sName;
        dep = sDep;
    }

    public Student(string sName, string sDep, string Ssession, int Sroll)
    {
        name = sName;
        dep = sDep;
        session = Ssession;
        roll = Sroll;
    }

    public void getInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Student Of : " + dep);
        Console.WriteLine("Session : " + session);
        Console.WriteLine("Roll : " + roll);
    }
}
