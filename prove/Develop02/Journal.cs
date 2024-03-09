using System;
using System.Collections.Generic;

namespace YourNamespace
{
    public class Journal
    {
        public List<Entry> _entries;

        public Journal()
        {
            _entries = new List<Entry>();
        }

        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        public void SaveToFile(string file)
        {
            // Implement logic to save the journal to a file
        }

        public void LoadFromFile(string file)
        {
            // Implement logic to load the journal from a file
        }
    }
}



