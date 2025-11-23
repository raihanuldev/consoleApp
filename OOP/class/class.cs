using System;

public class Student
{
    public
        string name;
        string dep;
        string session;
        int roll;
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

public class HelloWorld
{

    public static void Main(string[] args)
    {
        Student raihan = new Student("Raihanul Islam", "CST", "2022-23", 789144);
        raihan.getInfo();
        Student habib = new Student("Habibur Rahaman","AT","2023-24",789111);
        habib.getInfo();
        Console.WriteLine("This is Topic about Class Constructor !");
    }
}