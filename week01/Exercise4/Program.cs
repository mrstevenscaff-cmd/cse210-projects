using System;

class Program
{
    static void Main(string[] args)
    {
        
        int match = 1;
        int countUp = 0;
        int tallyUp = 0;
        int avgNum = 0;
        int largeNum = 0;

        List<int> numbers = new List<int>();

        do 
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished");
            string entry = Console.ReadLine();
            int entryNum = int.Parse(entry);

            if (entryNum != 0)
            {
                numbers.Add(entryNum);
                countUp += entryNum;
                tallyUp += 1;
                if (entryNum > largeNum)
                {
                    largeNum = entryNum;
                }
            }
            else
            {
                match = 0;
            }
        } while (match != 0);
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine($"The sum is: {countUp}");
        avgNum = countUp / tallyUp;
        Console.WriteLine($"The average is: {avgNum}");
        Console.WriteLine($"The largest number is: {largeNum}");


    }
}