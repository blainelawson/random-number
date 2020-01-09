using System;

namespace random_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int randomNumber = r.Next(1,10);
            bool win = false;

            Console.WriteLine("Guess the computer's number between 1 and 10. You have 3 attempts!");
            for (int i = 1; i < 4; i++)
            {
                Console.Write($"Guess number {i}: ");
                string input = Console.ReadLine();

                int.TryParse(input, out int userResponse);

                if (userResponse == randomNumber)
                {
                    Console.WriteLine("You guessed correctly!");
                    win = true;
                    break;
                }
                else if (userResponse > randomNumber)
                {
                    Console.WriteLine("You guessed too high!");
                }
                else if (userResponse < randomNumber)
                {
                    Console.WriteLine("You guessed too low!");
                }

            }

            if (win == true)
            {
                Console.WriteLine($"You WIN, the number was {randomNumber}");
            }
            else
            {
                Console.WriteLine($"You LOSE, the number was {randomNumber}");
            }
        }
    }
}
