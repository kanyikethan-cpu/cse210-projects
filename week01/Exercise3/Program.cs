using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator=new Random();
        int magicNumber= randomGenerator.Next(1,100);
        int guess=-2;

        while (guess!=magicNumber)
        {
            Console.Write("What is your guess? ");
            string response=Console.ReadLine();
            guess=int.Parse(response);

            if (guess<magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if(guess>magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}