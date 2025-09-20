using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");

        // string firstName = "Bob";

        // Console.WriteLine("Hello " + firstName);
        // Console.WriteLine($"Hello {firstName}");
        // Console.Write($"Hello Bob");
        // Console.Write($"This is another line\n");

        // Console.Write("What is your favorite color? ");
        // string favoriteColor = Console.ReadLine();

        // Console.WriteLine($"{firstName}, your favorite color is {favoriteColor}.");

        // Console.Write("How old are you?");
        // int age = int.Parse(Console.ReadLine());
        // Console.WriteLine($"{firstName}, you are {age} years old.");

        // int a = 13;
        // int b = 7;

        // int c = a + b;

        // Console.WriteLine($"c is {c}");
        // Console.WriteLine($"a/b is {a / b}");
        // Console.WriteLine($"{(double)a / b}");

        // int x = 5;
        // Console.WriteLine(x);

        // Console.Write("What is your favorite color? ");
        // string color = Console.ReadLine();
        // Console.Write($"{color} is also my favorite color.");

        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}. ");

    }
}