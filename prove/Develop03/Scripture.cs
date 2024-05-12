public class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    public Scripture(string text, string reference)
    {
        _words = new List<Word>();
        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
        _reference = DivideReferenceString(reference);

    }
    private Reference DivideReferenceString(string reference)
    {
        string[] divider = reference.Split(" ");
        string book = "";
        int chapter = 0;
        int beginVerse = 0;
        int endVerse = 0;
        string[] partReference;
        if (divider.Length == 3)
        {
            book = $"{divider[0]} {divider[1]}";
            partReference = divider[2].Split(":");

        }
        else
        {
            book = divider[0];
            partReference = divider[1].Split(":");
        }

        chapter = int.Parse(partReference[0]);
        string[] verses = partReference[1].Split("-");
        Console.WriteLine(verses.Length);
        if (verses.Length > 1)
        {
            beginVerse = int.Parse(verses[0]);
            endVerse = int.Parse(verses[1]);
            return new Reference(book, chapter, beginVerse, endVerse);
        }
        beginVerse = int.Parse(verses[0]);
        return new Reference(book, chapter, beginVerse);


    }
    public bool IsCompletlyHidden()
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
    public string GetDisplayText()
    {
        string resultText = $"{_reference.GetDisplayText()}";
        foreach (Word word in _words)
        {
            resultText = $"{resultText} {word.GetDisplayText()}";
        }
        return resultText.Trim();
    }
    public void HideWords()
    {
        Random random = new Random();
        int howManyWordsToHide = random.Next(_words.Count);
        _words.ForEach(delegate (Word word)
        {
            if (random.Next(2) == 1 && howManyWordsToHide > 0)
            {
                word.Hide();
                howManyWordsToHide--;
            }
        });
    }

}