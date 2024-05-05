using System;

class Program
{
    private static Journal _journal;
    static void Main(string[] args)
    {
        _journal = new Journal();
        int option = 0;
        do
        {
            DisplayMenu();            
            option = int.Parse(Console.ReadLine());
            string filename = "";
            switch (option)
            {
                case 1:
                    _journal.AddEntry();
                    break;

                case 2:
                    _journal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("What is the filename? ");
                    filename = Console.ReadLine();
                    _journal.LoadFromFile(filename);
                    break;
                case 4:
                    Console.Write("Please give a name (.csv,.txt): ");
                    filename = Console.ReadLine();
                    _journal.SaveToFile(filename);
                    break;
                default:
                    break;
            }
        } while (option != 5);
       
    }
    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        Console.Write("What would you like to do? ");
    }

}