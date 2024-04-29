using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int newNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (newNumber != 0)
        {
            Console.Write("Enter a number:");
            newNumber = int.Parse((Console.ReadLine()));

            if (newNumber != 0) 
            {
            numbers.Add(newNumber); 
            }
        }
        
        int sum = 0;
        int max = 0;
        
        foreach (int num in numbers)
        {
            sum += num; 
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"the total sum is: {sum}");

        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        Console.WriteLine($"The max number is: {max}");

    }
}