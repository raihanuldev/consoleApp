
// // Online C# Editor for free
// // Write, Edit and Run your C# code using C# Online Compiler

// using System;

// class Car{
//    public
//     string color;
//     string name;
//     string owner;

//     public Car(string colorName,string nameP,string ownerP){
//         color = colorName;
//         name=nameP;
//         owner = ownerP;
//     }
//     public void printDetails(){
//         Console.WriteLine(name);
//         Console.WriteLine(color);
//         Console.WriteLine(owner);
//     }

// }


// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         Car mycar = new Car("red","BMW","Raihan Sharif");
//         mycar.printDetails();
//         Console.WriteLine ("Try programiz.pro");
//     }
// }

// // using System;

// // class Program
// // {
// //     // Class-level methods → can be overloaded
// //     static int MethodOverloading(int x, int y)
// //     {
// //         Console.WriteLine("Int Version method overloaded");
// //         return x + y;
// //     }

// //     static float MethodOverloading(float x, float y)
// //     {
// //         Console.WriteLine("Float version called");
// //         return x + y;
// //     }

// //     static void Main()
// //     {
// //         Console.WriteLine(MethodOverloading(12, 22));           // int → 34
// //         Console.WriteLine(MethodOverloading(12.5f, 13.5f));     // float → 26
// //     }
// // }


// // // // static void mymethod()
// // // // {
// // // //     Console.WriteLine("This is from Method");
// // // // }
// // // // static int recivedPatametar(int num1, int num2)
// // // // {
// // // //     return num1+num2;
// // // // }

// // // // Console.WriteLine("Hello world Iam here to Explore C-Sharp! ");
// // // // mymethod();
// // // // Console.WriteLine(recivedPatametar(12,22));

// // // // string[] cars={"BMS","XYS","SSSS"};
// // // // cars.Append("BMW");


// // // // for(int i=0; i < 10; i++)
// // // // {
// // // //     Console.WriteLine(i);
// // // // }

// // // // int i = 0;
// // // // while (true)
// // // // {
// // // //     i++;
// // // //     if (i == 10)
// // // //     {
// // // //         Console.WriteLine("LOOP Are breaked broo");
// // // //         break;
// // // //     }
// // // //     Console.WriteLine(i);
// // // // }


// // // // string input = Console.ReadLine();
// // // // int age;
// // // // int.TryParse(input,out age);

// // // // if (age >= 18)
// // // // {
// // // //     Console.WriteLine("THis Person are adult! ");
// // // // }
// // // // else
// // // // {
// // // //     Console.WriteLine("This not adult");
// // // // }

// // // // Boolean
// // // bool isCSharpFun = true;


// // // // String
// // // string greeting = "Nice to meet you";
// // // // Console.WriteLine("Length of string: "+greeting.Length);
// // // // Console.WriteLine("UPPER ALL=> "+ greeting.ToUpper());
// // // // Console.WriteLine("LOWER ALL=> "+ greeting.ToLower());

// // // // Special Char
// // // string text = "We are so called \"vondo\"from the gruops ";
// // // // Console.WriteLine(text);

// // // // // access the string
// // // // Console.WriteLine(greeting[1]);
// // // // Console.WriteLine(greeting.IndexOf("e"));

// // // // // Math
// // // // int maxValue = Math.Max(6,109);
// // // // int minvalue = Math.Min(42,21);
// // // // double sqrt = Math.Sqrt(64);
// // // // Math.Abs(-12.2);


// // // // // Operator

// // // // int x =5;
// // // // x+=4;

// // // // // Assignment operator, aithmatic,logical operator,comparisom


// // // // // Take User Input
// // // // Console.WriteLine("Enter your UserName: ");
// // // // string userName = Console.ReadLine();
// // // // Console.WriteLine("userName: "+ userName);
// // // // // Console.WriteLine($"userName: {userName}");


// // // // int myNum = 100;
// // // // double myDouble = myNum; //Type Casting

// // // // string myStr = Convert.ToString(myNum);
// // // // Console.WriteLine("This is type Casting Converted string: "+ myStr);
// using System;

// public class Student
// {
//     public
//         string name;
//         string dep;
//         string session;
//         int roll;
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
//         Student raihan = new Student("Raihanul Islam", "CST", "2022-23", 789144);
//         raihan.getInfo();
//         Console.WriteLine("This is Topic about Class Constructor !");
//     }
// }
