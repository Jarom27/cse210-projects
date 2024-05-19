using System.Globalization;

class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}\n\n{_description}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName}");
    }
    public void StartSpinner(int number = 3)
    {
        int cycles = 0;
        while (cycles < number)
        {
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
            Console.Write("\b \b");
            cycles++;
        }
        PauseSpinner();
    }
    public void PauseSpinner()
    {
        Console.Write("\b\b");
        Console.WriteLine();
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public void StartCountDown(int endCount)
    {
        int count = endCount;
        while (count > 0)
        {

            Console.Write("\b \b");
            Console.Write(count);
            count--;
            Thread.Sleep(1000);
        }
        PauseCountDown();

    }
    public void PauseCountDown()
    {
        Console.Write("\b \b");
    }
    public virtual void Run()
    {
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        SetDuration(int.Parse(Console.ReadLine()));
        Console.Clear();
        Console.WriteLine("Get Ready");
        StartSpinner();
    }
}