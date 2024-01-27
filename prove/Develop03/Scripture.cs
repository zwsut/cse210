using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string book, int chapter, int verse,int endVerse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        _words = new List<Word>();
        
        string[] eachWord = text.Split(' ');

        foreach (string word in eachWord)
        {
            Word x = new Word(word);
            _words.Add(x);
        }
    }

    public Scripture()
    {}


    public void HideRandomWords()
    {
        for (int i = 0; i <= 2; i++)
        {
            int length = _words.Count;
            Random rnd = new Random();
            int num = rnd.Next(0, length);
            _words[num].Hide();
        }
    }

    public string GetDisplayText()
    {
        _reference.GetReferenceText();

        string displayText = new string("");
        foreach (Word x in _words)
        {
                displayText += x.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool isCompletelyHidden()
    {
        foreach (Word x in _words)
        {
                if  (x.IsHidden() == false)
                {
                    return false;
                }
        }
        return true;

    }

    public void SetScripture(string inputBook,int inputChapterInt, int inputVerseInt, int inputEndVerseInt, string inputText)
    {
        _reference = new Reference(inputBook, inputChapterInt, inputVerseInt, inputEndVerseInt);
        _words = new List<Word>();
        
        string[] eachWord = inputText.Split(' ');

        foreach (string word in eachWord)
        {
            Word x = new Word(word);
            _words.Add(x);
        }       
    }
}

