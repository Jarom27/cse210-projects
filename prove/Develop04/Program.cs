using System;

class Program
{
    static void Main(string[] args)
    {
        string option;
        Log log = new Log();
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n1.Start breathing activity\n2.Start reflecting activity\n3.Start listing Activity\n4.See log file\n5.Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();
            Activity activity = null;

            if (option == "1")
            {
                activity = new BreathingActivity();
            }

            else if (option == "2")
            {
                activity = new ReflectionActivity();
            }
            else if (option == "3")
            {
                activity = new ListingActivity();
            }

            else if (option == "4")
            {
                log.SeeLog();
            }
            if (activity != null)
            {
                log.KeepRecord(activity.GetActivityName(), DateTime.Now.ToString());
                activity.Run();

            }



        } while (option != "5");
    }
}