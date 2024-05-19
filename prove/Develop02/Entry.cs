using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

   
    public void Display()
    {
        Console.WriteLine($"date: {_date}");
        Console.WriteLine($"Prompt text: {_promptText}");
        Console.WriteLine($"entry: {_entryText}");
    }
}