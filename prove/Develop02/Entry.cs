public class Entry
{
    private String _promptText;
    private String _entryText;
    private String _date;
    private String _postData;
    public Entry()
    {

    }
    public Entry(String promptText, String entryText, String date, String postData)
    {
        _promptText = promptText;
        _entryText = entryText;
        _date = date;
        _postData = postData;
    }
    public void SetPostData(String postData)
    {
        _postData = postData;
    }
    public String GetPostData()
    {
        return _postData;
    }
    public String GetPromptText()
    {
        return _promptText;
    }
    public String GetEntryText()
    {
        return _entryText;
    }
    public String GetDate()
    {
        return _date;
    }
    public void SetPromptText(String promptText)
    {
        _promptText = promptText;
    }
    public void SetDate(String date)
    {
        _date = date;
    }
    public void SetEntryText(String entryText)
    {
        _entryText = entryText;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - {_promptText}\n{_entryText}\nP.D: {_postData}");
    }
}