using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new list<int>();
        user = -1;
        while (user != 0);
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLiine();
            int user = int.parse(response);

        
            if (user != 0);
            {
                numbers.Add(user);
            }
        
            
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}")
        float average = (float(sum)) / numbers.count;
        Console.WriteLine($"The average is: {average}")

        int maximum = numbers[0];
        foreach (int number in numbers);
        {
        if (number > max)
        {
            maximum = number
        }
        }
        Console.WriteLine($"The maximum number is: {maximum}")

    }
}