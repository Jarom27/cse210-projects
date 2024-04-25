using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        List<int> numbersEntered = [];
        Console.WriteLine("Enter a list of number, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
                numbersEntered.Add(number);
        }
        while (number != 0);
        int sum = 0;
        int largestNumber = 0;
        int smallestNumber = int.MaxValue;
        foreach (int operand in numbersEntered)
        {
            if (operand > largestNumber)
            {
                largestNumber = operand;
            }
            smallestNumber = (operand > 0 && operand < smallestNumber) ? operand : smallestNumber;
            sum += operand;
        }
        double average = (double)sum / numbersEntered.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
        Console.WriteLine("The sorted list is: ");
        numbersEntered.Sort();
        foreach (int item in numbersEntered)
        {
            Console.WriteLine(item);
        }
    }
}