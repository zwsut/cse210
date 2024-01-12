using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int idk = 101;

        do
        {
            Console.Write("Guess the secret number between 1 and 100: ");
            string i = Console.ReadLine();
            int guess = int.Parse(i);

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == number)
            {
                Console.WriteLine("You guessed it!");
                idk = 102;
            }            
        } while (idk == 101);
    }
}