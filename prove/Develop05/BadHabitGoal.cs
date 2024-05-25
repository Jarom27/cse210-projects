public class BadHabitGoal : Goal
{

    public BadHabitGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override string GetStringRepresentation()
    {
        return $"BadHabit:{_shortName},{_description},{_points}";
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        return (_points * -1);
    }
}