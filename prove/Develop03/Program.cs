using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        string userInput = "";

        while (!scripture.IsCompletelyHidden() && !string.Equals(userInput, "quit", StringComparison.OrdinalIgnoreCase))
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            scripture.HideRandomWords();
            Console.WriteLine("\nType 'quit' to exit or press Enter to continue.");
            userInput = Console.ReadLine();
        }

        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words are hidden. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
