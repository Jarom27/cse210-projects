public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        int option = 0;
        do
        {
            Console.WriteLine("Menu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.Write("Select a option from the menu: ");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    DisplayPlayerInfo();
                    break;
                case 3:
                    SaveGoals();
                    DisplayPlayerInfo();
                    break;
                case 4:
                    LoadGoals();
                    DisplayPlayerInfo();
                    break;
                case 5:
                    RecordEvent();
                    DisplayPlayerInfo();
                    break;
            }

        } while (option != 6);
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }
    public void ListGoalNames()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetShortName()}");
            index++;
        }
    }
    public void ListGoalDetails()
    {
        int index = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetStringDetails()}");
            index++;
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal\n 2. Eternal Goal\n 3. CheckList Goal\n 4. Bad Habit Goal");
        Console.Write("Which type of goal would you like to create? ");
        int answer = int.Parse(Console.ReadLine());
        Goal newGoal = null;
        string title = "";
        string description;
        int score;
        switch (answer)
        {
            case 1:
                Console.Write("What is the name of your goal? ");
                title = Console.ReadLine();

                Console.Write("What is a short description? ");
                description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                score = int.Parse(Console.ReadLine());

                newGoal = new SimpleGoal(title, description, score);
                break;
            case 2:
                Console.Write("What is the name of your goal? ");
                title = Console.ReadLine();

                Console.Write("What is a short description? ");
                description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                score = int.Parse(Console.ReadLine());

                newGoal = new EternalGoal(title, description, score);
                break;
            case 3:
                Console.Write("What is the name of your goal? ");
                title = Console.ReadLine();

                Console.Write("What is a short description? ");
                description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                score = int.Parse(Console.ReadLine());

                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplish it many times? ");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new CheckListGoal(title, description, score, target, bonus);
                break;
            case 4:
                Console.Write("What is the name of your goal? ");
                title = Console.ReadLine();

                Console.Write("What is a short description? ");
                description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                score = int.Parse(Console.ReadLine());

                newGoal = new BadHabitGoal(title, description, score);
                break;

        }
        _goals.Add(newGoal);
        Console.WriteLine("");
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        ListGoalNames();
        Console.Write("Which goald did you accomplish? ");
        int answer = int.Parse(Console.ReadLine());
        try
        {
            int pointsEarned = _goals[answer - 1].RecordEvent();
            _score += pointsEarned;
            if (pointsEarned > 0)
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
            else
                Console.WriteLine($"Sorry! you lost {(pointsEarned * -1)} points");
            Console.WriteLine($"You now have {_score} points.");

        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Please type a number that is inside of the ranges");
        }

    }
    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {

                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }


        }

    }
    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        bool firstLine = true;
        foreach (string line in lines)
        {
            Goal goal = null;
            if (firstLine)
            {
                _score = int.Parse(line);
                firstLine = false;
                continue;
            }
            string[] firstDivision = line.Split(":");
            string[] infoLine = firstDivision[1].Split(",");
            switch (firstDivision[0])
            {
                case "SimpleGoal":
                    goal = new SimpleGoal(infoLine[0], infoLine[1], int.Parse(infoLine[2]));
                    if (infoLine[3] == "True")
                    {
                        SimpleGoal simpleGoal = (SimpleGoal)goal;
                        simpleGoal.Complete();
                        goal = simpleGoal;
                    }
                    break;
                case "EternalGoal":
                    goal = new EternalGoal(infoLine[0], infoLine[1], int.Parse(infoLine[2]));
                    break;
                case "CheckListGoal":
                    goal = new CheckListGoal(infoLine[0], infoLine[1], int.Parse(infoLine[2]), int.Parse(infoLine[4]), int.Parse(infoLine[3]));
                    int amountCompleted = int.Parse(infoLine[5]);
                    if (amountCompleted > 0)
                    {
                        CheckListGoal checkListGoal = (CheckListGoal)goal;
                        checkListGoal.SetAmountCompleted(amountCompleted);
                    }
                    break;
            }
            _goals.Add(goal);

        }
    }
}