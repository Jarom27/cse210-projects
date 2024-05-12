public class Reference
{
    private int _beginVerse;
    private int _endVerse;
    private string _book;
    private int _chapter;
    public Reference(string book, int chapter, int beginVerse)
    {
        _book = book;
        _chapter = chapter;
        _beginVerse = beginVerse;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int beginVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _beginVerse = beginVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse != 0)
        {
            return $"{_book} {_chapter}:{_beginVerse}-{_endVerse}";
        }
        return $"{_book} {_chapter}:{_beginVerse}";
    }

}