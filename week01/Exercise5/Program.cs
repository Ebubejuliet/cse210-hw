using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

    }
    static void DisplayWelcomeMessage();
    {
        
        Console.WriteLine("Welcome to the program!");
    }
    static void PromptUserName();
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLiine();
        return userName;
    }
    static void PromptUserNumber();
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = Console.ReadLiine();
        return userNumber;
    }
    static void squaredNumber(int userNumber);
    {
        int SquareNumber = userNumber * userNumber;
        return SquareNumber;
    }
    static void DisplayResult(string userName, int SquareNumber);
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}