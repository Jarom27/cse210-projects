class Log
{
    private string filename;
    public Log()
    {
        filename = "log.txt";
    }
    public void SeeLog()
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            if (lines.Length == 0)
            {
                Console.WriteLine("No exists records");
            }
            Console.WriteLine($"{"Activity Name",-25}{"Date"}");
            foreach (string line in lines)
            {
                string[] data = line.Split(",");
                Console.WriteLine($"{data[0],-24}{data[1]}");
            }
            Console.Write("Press enter to continue ");
            Console.ReadLine();
            Console.Clear();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
    public void KeepRecord(string activityName, string date)
    {
        using (StreamWriter stream = new StreamWriter(filename))
        {
            stream.WriteLine($"{activityName}, {date}");
        }
    }

}