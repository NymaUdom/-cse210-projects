using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            Reference reference = new Reference("John", 3, 16);
            Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
            
            // Display the complete scripture
            scripture.DisplayText();

            // Hide random words until all are hidden
            while (!scripture.AreAllWordsHidden())
            {
                Console.WriteLine("Press Enter to continue, or type 'quit' to exit...");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    scripture.HideRandomWords(3); // Hide 3 random words
                    Console.Clear();
                    scripture.DisplayText();
                }
            }
        }
    }
}
