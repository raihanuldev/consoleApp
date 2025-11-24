// using System;

// public class Student
// {
//     public
//         string name;
//         string dep;
//         string session;
//         int roll;
    
//     //NO parametar
//     public Student()
//     {
//         name="Unknown";
//         dep ="Unknwn";
//         session ="UKnown";
//         roll = 0;
//     }
//     // 2 parametar constructor
//     public Student(string sName,string sDep)
//     {
//         name=sName;
//         dep = sDep;
//     }
//     // 4 parametar constructor
//     public Student(string sName, string sDep, string Ssession, int Sroll)
//     {
//         name = sName;
//         dep = sDep;
//         session = Ssession;
//         roll = Sroll;
//     }
//     public void getInfo()
//     {
//         Console.WriteLine("Name: " + name);
//         Console.WriteLine("Student Of : " + dep);
//         Console.WriteLine("Session : " + session);
//         Console.WriteLine("Roll : " + roll);
//     }
// }

// public class HelloWorld
// {

//     public static void Main(string[] args)
//     {
//         Student s2 = new Student("Raihanul Islam", "CST", "2022-23", 789144);
//         Student s1= new Student("Saomi","Computer Science and technology");
//         Student s0 = new Student();

//         // Display data
//         Console.WriteLine("<<<<<--------------->>>>>>");
//         s0.getInfo();
//         Console.WriteLine("<<<<<--------------->>>>>>");
//         s1.getInfo();
//         Console.WriteLine("<<<<<--------------->>>>>>");
//         s2.getInfo();
//         Console.WriteLine("<<<<<--------------->>>>>>");
//     }
// }