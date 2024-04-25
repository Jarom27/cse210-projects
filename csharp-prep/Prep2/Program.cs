using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letter = String.Empty;
        string sign = String.Empty;

        int lastDigit = 0;
        lastDigit = grade % 10;
        if (grade >= 90)
        {

            letter = "A";

        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (lastDigit < 3 && grade >= 60)
        {
            sign = "-";
        }
        else if (lastDigit >= 7 && grade < 90 && grade >= 60)
        {
            sign = "+";
        }
        Console.WriteLine($"Your grade is: {letter}{sign}");
        if (grade >= 70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("You failed");
        }
    }
}