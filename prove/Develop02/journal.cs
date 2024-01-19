using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName, Journal journal)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry ent in journal._entries)
            {
                outputFile.WriteLine($"\"{ent._date}\",\"{ent._prompt}\",\"{ent._response}\"");
            }
        }
    }

    public Journal LoadFromFile(string fileName)
    {
        Journal journal = new Journal();
        TextFieldParser parser = new TextFieldParser(fileName);
        parser.HasFieldsEnclosedInQuotes = true;
        parser.SetDelimiters(",");

        string[] fields;

        while (!parser.EndOfData)
        {
            fields = parser.ReadFields();
            Entry entry = new Entry();
            entry._date = fields[0];
            entry._prompt = fields[1];
            entry._response = fields[2];
            journal.AddEntry(entry);          
        } 

        return journal;
    }
}