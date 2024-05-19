class ReflectionActivity : Activity
{
    private List<string> _promts;
    private List<string> _questions;
    public ReflectionActivity()
    {
        _activityName = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _promts = new List<string>(){
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>(){
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int selectTopic = random.Next(_promts.Count);

        return _promts[selectTopic];
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Consider the following promt:\n\n--- {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    private string GetQuestion()
    {
        Random random = new Random();
        int question = random.Next(_questions.Count);
        return _questions[question];
    }
    public void DisplayQuestion()
    {
        string question = GetQuestion();
        Console.Write($"> {question}  ");
    }
    public override void Run()
    {
        base.Run();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        DisplayPrompt();
        Console.WriteLine("Now ponder on each of the following questions that related to this experience.");
        Console.Write("You may begin in:  ");
        StartCountDown(4);
        Console.WriteLine();
        while (currentTime < endTime)
        {
            DisplayQuestion();
            StartSpinner(5);
            currentTime = DateTime.Now;
        }
        Console.WriteLine("Well Done!");
        StartSpinner();
        DisplayEndingMessage();
        StartSpinner();
        Console.Clear();
    }
}