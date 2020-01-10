using System;
namespace Exercises49Controlflow
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // imports
            Programs.Remainder remainder = new Programs.Remainder();
            Programs.Sumofall sumofall = new Programs.Sumofall();
            Programs.Factorial factorial = new Programs.Factorial();
            Programs.Guess_game guess = new Programs.Guess_game();
            Programs.Return_high return_High = new Programs.Return_high();

            //Remainder exercise
            Console.WriteLine("Exercise 1");
            Console.WriteLine("Write a number");

            var remainNr = int.Parse(Console.ReadLine());
            remainder.Remains(remainNr);


            // Sum of all exercise
            Console.WriteLine("Exercise 2");
            Console.WriteLine("Write a number, or enter 'ok' to exit..");

            var input = Console.ReadLine();
            sumofall.Sum(input);

            // Factorial
            Console.WriteLine("Exercise 3");
            Console.WriteLine("Write a number, And I will give back the factorial:");

            var FactoBase = Console.ReadLine();
            factorial.Facto(FactoBase);

            // Guess a random number under 10
            Console.WriteLine("Exercise 4");
            Console.WriteLine("Guess the right number");

            var firstGuess = Console.ReadLine();
            guess.guess(firstGuess);

            // Give back highest number in the string, separated by comma.
            Console.WriteLine("Exercise 5");
            Console.WriteLine("Give me a string with numbers, separated by comma (0,2,3,4)");

            var charString = Console.ReadLine();
            return_High.GiveBackHigh(charString);

        }
    }
}
