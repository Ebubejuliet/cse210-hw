using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Ramdon ramdonGenerator = new Ramdon();
        int number = ramdonGenerator.Next(1, 11);
        string keepplaying = "yes";

        int guess;
        do
        {
            Console.Write("What is your magic number? ");
            guess = int.Parse(Console.ReadLine());
         while (guess != number);
        }
        if (guess > number);
        {
            Console.WriteLine("Lower");
        }
        if (guess < number);
        {
            Console.WriteLine("Higher");
        }
        else;
        {
            Console.WriteLine("You guessed it!")
        }
        while (keepplaying == "yes");
        {
            Console.Write("Do you want to keep playing? ");
            keepplaying = Console.ReadLine();
        }



    }
}