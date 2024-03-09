using System;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();

            // Main menu loop
            while (true)
            {
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.\n");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"Prompt: {prompt}");

                        Console.Write("Enter your response: ");
                        string entryText = Console.ReadLine();

                        Entry newEntry = new Entry(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), prompt, entryText);
                        myJournal.AddEntry(newEntry);
                        Console.WriteLine("Entry added successfully!\n");
                        break;

                    case 2:
                        Console.WriteLine("\n--- Journal Entries ---");
                        myJournal.DisplayAll();
                        Console.WriteLine("-----------------------\n");
                        break;

                    case 3:
                        Console.Write("Enter the file name to save: ");
                        string saveFileName = Console.ReadLine();
                        myJournal.SaveToFile(saveFileName);
                        Console.WriteLine($"Journal saved to {saveFileName} successfully!\n");
                        break;

                    case 4:
                        Console.Write("Enter the file name to load: ");
                        string loadFileName = Console.ReadLine();
                        myJournal.LoadFromFile(loadFileName);
                        Console.WriteLine($"Journal loaded from {loadFileName} successfully!\n");
                        break;

                    case 5:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.\n");
                        break;
                }
            }
        }
    }
}