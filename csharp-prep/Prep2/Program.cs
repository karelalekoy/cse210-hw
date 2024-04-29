using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        
        string letter = "";

        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }


        Console.WriteLine($"your grade is: {letter}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulation you passed the course");
        }
        else 
        {
            Console.WriteLine("I am sorry, you did not pass the course, I hope next term you show what you are capable of :)");
        }
    }
}