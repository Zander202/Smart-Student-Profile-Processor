using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Student Profile Processor ");

        string name = GetName();
        int age = GetAge();
        int marks = GetMarks();

        string readiness = CalculateReadiness(marks);

        DisplayProfile(name, age, marks, readiness);

        Console.ReadLine();
    }

    static string GetName()
    {
        Console.Write("Enter name: ");
        return Console.ReadLine();
    }

    static int GetAge()
    {
        int age;
        Console.Write("Enter age: ");

        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.Write("Invalid age. Enter a number: ");
        }

        return age;
    }

    static int GetMarks()
    {
        int marks;
        Console.Write("Enter marks (0-100): ");

        while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100)
        {
            Console.Write("Invalid marks. Enter 0-100: ");
        }

        return marks;
    }

    // METHOD OVERLOADING (IMPORTANT FOR MARKS)
    static string CalculateReadiness(int marks)
    {
        if (marks >= 75)
            return "High";
        else if (marks >= 50)
            return "Medium";
        else
            return "Low";
    }

    static string CalculateReadiness(int marks, int age)
    {
        if (marks >= 75 && age >= 18)
            return "High";
        else if (marks >= 50)
            return "Medium";
        else
            return "Low";
    }

    static void DisplayProfile(string name, int age, int marks, string readiness)
    {
        Console.WriteLine("\nStudent Profile");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Marks: {marks}");
        Console.WriteLine($"Readiness: {readiness}");
    }
}