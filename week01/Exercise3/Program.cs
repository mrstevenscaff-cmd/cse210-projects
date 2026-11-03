using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 11);

        int match = 0;
        int countUp = 0;

        do 
        {
            Console.WriteLine("What is your guess?");
            countUp ++;
            string guess = Console.ReadLine();
            int guessNum = int.Parse(guess);

            if (magicNum > guessNum)
            {
                Console.WriteLine("Higher");
            }
            
            else if (magicNum < guessNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You got it in {countUp} guess(es)");
                match = 1;
            }
        } while (match !=1);



      
    }
}