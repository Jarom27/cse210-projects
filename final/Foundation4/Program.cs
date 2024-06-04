using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new RunningActivity("04 Jun 2024", 30, 3.0));
        activities.Add(new CyclingActivity("05 Jun 2024", 45, 10.0));
        activities.Add(new SwimmingActivity("06 Jun 2024", 60, 10));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}