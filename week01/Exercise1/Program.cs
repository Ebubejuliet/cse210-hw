using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("What is your first name? ");
        string firstname = Console.Readline();
        Console.Write("What is your last name? ");
        string lastname = Console.Readline();
        Console. WriteLine($"Your name is {lastname}, {firstname} {lastname}");
    }
}