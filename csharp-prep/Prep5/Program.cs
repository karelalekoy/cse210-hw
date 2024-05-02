using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PrompUserName();
        int userNumber = PrompUserNumber();
        int square = SquareNumber(userNumber);  

         DisplayResult(userName, square);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PrompUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        
        return name;
    }
    static int PrompUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse((Console.ReadLine()));
        
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}