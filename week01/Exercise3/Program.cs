using System;

class Program
{
    static void Main(string[] args)
 {
        Random randomGenerator = new Random();
        int Numberguess = randomGenerator.Next(1, 101);
        int guess = -1;
        while (guess != Numberguess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (Numberguess > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (Numberguess < guess)
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