using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guessNumber = -1;

        while (guessNumber != magicNumber) 
        {

        Console.Write("What is your guess? ");
        guessNumber = int.Parse((Console.ReadLine()));
 
        if (guessNumber < magicNumber)
        {
            Console.WriteLine("Go higher");
        }
        else if (guessNumber > magicNumber)
        {
            Console.WriteLine("Go lower");
        }
        else 
        {
            Console.WriteLine("you guessed it!");
        }
        }


        
    }
}