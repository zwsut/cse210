public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse ;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int verse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endverse;
    }

    public void GetReferenceText()
    {
        if (_endVerse == 0)
        {
            Console.Write($"({_book} {_chapter.ToString()}:{_verse.ToString()}) ");
        } 
        else
        {
            Console.Write($"({_book} {_chapter.ToString()}:{_verse.ToString()}-{_endVerse}) ");
        }
    }

}
