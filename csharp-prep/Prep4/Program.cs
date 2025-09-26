using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //Part 1
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The total is: {sum}");

        //Part 2
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Part 3
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");

        
    }
}