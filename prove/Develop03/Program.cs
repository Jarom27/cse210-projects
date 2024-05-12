using System;
class Program
{
    static void Main(string[] args)
    {
        string option = "";
        string[] scriptures = System.IO.File.ReadAllLines("scriptures.csv");
        Random selector = new Random();
        int choice = selector.Next(scriptures.Length);
        string[] data = scriptures[choice].Split("|");
        Scripture scripture = new Scripture(data[1], data[0]);
        do
        {
            Console.Clear();
            Console.WriteLine($"{scripture.GetDisplayText()} \n");
            Console.WriteLine("Please enter to continue or 'quit' to finish");
            option = Console.ReadLine();
            if (scripture.IsCompletlyHidden())
            {
                OtherOptions();
                string enter = Console.ReadLine();
                if(enter == "y"){
                    AddScriptureToFile();
                }
                break;
            }
            scripture.HideWords();


        } while (option != "quit");

    }
    static void OtherOptions(){
        Console.WriteLine("Do you want to add a new Scripture?(y/n)");
        Console.WriteLine("Please enter your answer");

    }
    static void AddScriptureToFile(){
        Console.WriteLine("Please type the reference:");
        string reference = Console.ReadLine();
        Console.WriteLine("Please enter the scripture:");
        string text = Console.ReadLine();
        using(System.IO.StreamWriter sw = File.AppendText("scriptures.csv")){
            sw.WriteLine($"{reference}| {text}");
        }
    }
}
