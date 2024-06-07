using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to this Goals Planner!!");
        
        GoalManager goalManager = new();
        goalManager.Start();   
    }
}