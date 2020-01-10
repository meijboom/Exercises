using System;
namespace Exercises49Controlflow.Programs
{
    public class Guess_game
    {
        public string guess(string str)
        {
            // import random
            Random random = new Random();
            int luckyNr = random.Next(0, 10);
            Console.WriteLine("luckynr: " + luckyNr);
            int tries = 4;

            var ans = int.Parse(str);

            for (int i = 0; i <= tries; i++)
            {
              if (ans == luckyNr)
                {
                    tries = 0;
                    Console.WriteLine("You got it!");
                }
                else
                {
                    tries--;
                    Console.WriteLine("Wrong answer, try again. you still got " + tries + " tries");
                    ans = int.Parse(Console.ReadLine());
                }
            }
            return str;
        }
    }
}
