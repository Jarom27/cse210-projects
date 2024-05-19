class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _userItems;
    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>(){
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _userItems = new List<string>();
    }
    private void KeepItems(string item)
    {
        _userItems.Add(item);
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int selectPrompt = random.Next(_prompts.Count);
        return _prompts[selectPrompt];
    }
    private void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
    }
    private void DisplayNumberItems()
    {
        Console.WriteLine($"You have listed {_userItems.Count}");
    }
    public override void Run()
    {
        base.Run();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        Console.WriteLine("List as many responses you can to the following prompt: \n");
        DisplayPrompt();
        Console.Write("You may begin in:  ");
        StartCountDown(4);
        Console.WriteLine();
        while (currentTime < endTime)
        {

            Console.Write("> ");
            string item = Console.ReadLine();
            if (item != " " && item != "")
                KeepItems(item);
            currentTime = DateTime.Now;

        }
        DisplayNumberItems();
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        StartSpinner();
        DisplayEndingMessage();
        StartSpinner();
        Console.Clear();

    }
}