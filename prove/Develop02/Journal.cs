////www.plantuml.com/plantuml/png/TP3FIWCn48VlUOevhig-G11feROWFOXTlCfWHWaacIMPLOlqtKrsc_vPy1A6Zvdylfb54emoUAVU7QO4Zq7Y_bUryDP7zhrqz2CQTX9j-2pKe926LNuxwwaGAXDNRUeELZRr3lVDZOPNjaOfTJW6FF4G0xgBY0q5YYWSDJnVW_gzfQHXQvFSZteFEM1fp5WtWRx7Ga_gDV2ai7IkESCTVb77Q-ke-SXFLJutR1dDEblyrrBtcAjUx5DTfxaYko5vmM3OJqF5fvxge8u7WTksdLOu4SvaVf451JDuzmS0
public class Journal
{
    private PromptGenerator _promptGenerator;
    private List<Entry> _entries;

    public Journal()
    {
        _promptGenerator = new PromptGenerator();
        _entries = new List<Entry>();
    }
    public void AddEntry()
    {
        string promt = _promptGenerator.GetRandomPrompt();
        Entry newEntry = new Entry();
        newEntry.SetPromptText(promt);
        Console.WriteLine(promt);
        newEntry.SetEntryText(Console.ReadLine());
        Console.Write("Write a PD or only type an enter to continue: ");
        newEntry.SetPostData(Console.ReadLine());
        newEntry.SetDate(DateTime.Now.ToShortDateString());
        _entries.Add(newEntry);
    }
    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
    public void LoadFromFile(String filename)
    {
        try
        {
            String[] lines = System.IO.File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                String[] splitLine = line.Split(",");
                Entry newEntry = new Entry(splitLine[1], splitLine[2], splitLine[0], splitLine[3]);
                _entries.Add(newEntry);
            }
            Console.WriteLine("Document was loaded successfully\n");
        }
        catch (FileNotFoundException fex)
        {
            Console.WriteLine($"Cannot access to the file {filename}, please ensure that it exists\n");
        }


    }
    public void SaveToFile(String filename)
    {
        using StreamWriter streamWriter = new StreamWriter(filename);
        foreach (var entry in _entries)
        {
            streamWriter.WriteLine($"{entry.GetDate()},{entry.GetPromptText()},{entry.GetEntryText()},{entry.GetPostData()}");
        }
        Console.WriteLine("Document was saved successfully\n");
    }
}