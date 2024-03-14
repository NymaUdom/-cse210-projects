using System;

namespace ScriptureMemorizer
{
    // Reference class to represent scripture references like "John 3:16"
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int _endVerse;

        // Constructor for a single verse reference
        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = verse;
            _endVerse = verse;
        }

        // Constructor for a range of verses
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = endVerse;
        }

        // Method to display the reference text
        public string GetDisplayText()
        {
            if (_startVerse == _endVerse)
            {
                return $"{_book} {_chapter}:{_startVerse}";
            }
            else
            {
                return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
            }
        }
    }
}
