public class PromptGenerator
{
    private List<String> _prompts;
    public PromptGenerator()
    {
        _prompts = new List<String>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?" ,
            "What miracle could you see today?",
            "How do you feel today?",
            "What was the new thing you happened today?",
            "How is it going?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

    }
    public String GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
}