class BreathingActivity : Activity
{
    private int _breatheIn;
    private int _breatheOut;
    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _breatheIn = 2;
        _breatheOut = 4;
    }
    public override void Run()
    {
        base.Run();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            currentTime = DateTime.Now;
            Console.Write("Breathe in... ");
            StartCountDown(_breatheIn);
            Console.WriteLine();
            Console.Write("Now breathe out... ");
            StartCountDown(_breatheOut);
            Console.WriteLine("\n");
            UpdateBreathe();

        }
        Console.WriteLine("Well Done!");
        StartSpinner();
        DisplayEndingMessage();
        StartSpinner();
        Console.Clear();

    }
    private void UpdateBreathe()
    {
        _breatheIn = 4;
        _breatheOut = 6;
    }

}