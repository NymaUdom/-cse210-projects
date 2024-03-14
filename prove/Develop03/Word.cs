using System;

namespace ScriptureMemorizer
{
    // Word class to represent individual words in the scripture
    public class Word
    {
        private string _text;
        private bool _isHidden;

        // Constructor
        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        // Method to hide the word
        public void Hide()
        {
            _isHidden = true;
        }

        // Method to reveal the word
        public void Show()
        {
            _isHidden = false;
        }

        // Method to check if the word is hidden
        public bool IsHidden()
        {
            return _isHidden;
        }

        // Method to get the display text of the word (either hidden or not)
        public string GetDisplayText()
        {
            if (_isHidden)
            {
                return "______"; // Display underscores for hidden words
            }
            else
            {
                return _text;
            }
        }
    }
}
