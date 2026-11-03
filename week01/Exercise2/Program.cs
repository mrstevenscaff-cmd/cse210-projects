using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percentage?");
        string scoreText = Console.ReadLine();
        int scoreInt = int.Parse(scoreText);
        string letter = ("");

        if (scoreInt >=90)
        {
            letter = ("A");
        }
        else if (scoreInt >=80)
        {
            letter = ("B");
        }
        else if (scoreInt >=70)
        {
            letter = ("C");
        }
        else if (scoreInt >=60)
        {
            letter = ("D");
        }
        else
        {
            letter = ("F");
        }

        Console.WriteLine($"Your grade was an {letter}");
        if (scoreInt >=70 )
        {
            Console.WriteLine("Congrats! With your score you passed the class");
        }
        else
        {
            int scoreNeed = 70 - scoreInt ;
            Console.WriteLine($"You did not pass the class. Your grade was {scoreNeed} point(s) away from a passing score. ");

        }

    }
}