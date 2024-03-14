using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    // Scripture class to represent the scripture containing words and reference
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        // Constructor
        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            // Split the text into words and create Word objects
            string[] wordArray = text.Split(' ');
            foreach (string wordText in wordArray)
            {
                _words.Add(new Word(wordText));
            }
        }

        // Method to display the scripture text
        public void DisplayText()
        {
            Console.WriteLine($"Scripture Reference: {_reference.GetDisplayText()}\n");
            foreach (Word word in _words)
            {
                Console.Write($"{word.GetDisplayText()} ");
            }
            Console.WriteLine("\n");
        }

        // Method to hide a few random words in the scripture
        public void HideRandomWords(int numberToHide)
        {
            Random rand = new Random();
            for (int i = 0; i < numberToHide; i++)
            {
                int index = rand.Next(_words.Count);
                _words[index].Hide();
            }
        }

        // Method to check if all words in the scripture are hidden
        public bool AreAllWordsHidden()
        {
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
