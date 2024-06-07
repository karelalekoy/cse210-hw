using System;

class Program
{
    static void Main(string[] args)
    {
        

        Running run = new Running("June 5th, 2024", 15, 1.2);
        StationaryBike bike = new StationaryBike("June 1th, 2024", 22, 10);
        Swimming swim = new Swimming("June 1th, 2024", 22, 120);

        Console.WriteLine("Exercise activites for June:");
        Console.WriteLine(run.GetSummary());
        Console.WriteLine(bike.GetSummary());
        Console.WriteLine(swim.GetSummary());
    }
}