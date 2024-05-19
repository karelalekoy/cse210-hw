using System;
public class PrompGenerator 
{
    public static string[] _prompt = {
        "What was the best part of my day?",
        "What was the best meal of today? what was it?",
        "What did you learn today?",
        "Who made your day better today?",
        "What was the best idea you had today?",
        "did you meet someone new today?",
        "what made you smile today?",
        "what made you feel upset today?",
        "what would you do different from today",
        "if you have an extra hour, when and what would you do?",
        "What was the most peaceful moment today?",
        "from your routine, what was your favorite part today?"
    };
    public List<string> _prompts = new List<string>(_prompt);
    
    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        string journalPrompt = _prompt[index];
        
        return journalPrompt;
        
    }
}