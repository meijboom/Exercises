using System;

namespace ExerciseControlFlow
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 10");
            var ans = Console.ReadLine();
            int ConAns = int.Parse(ans);
            if (ConAns < 10 && ConAns > 0)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }

            Calculator calculator = new Calculator();

            // Give back highest number
            Console.WriteLine("Enter a number");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            var num2 = int.Parse(Console.ReadLine());
            var result = calculator.Max(num1, num2);
            Console.WriteLine("The highest number is:");
            Console.WriteLine(result);

            // Portrait or Landscape
            Console.WriteLine("Enter the width");
            var width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Height");
            var height = int.Parse(Console.ReadLine());
            var portland = calculator.Max(width, height);
            Console.WriteLine("Your screen is in:");
            if (portland == width)
            {
                Console.WriteLine("Landscape mode");
            }
            else
            {
                Console.WriteLine("Portrait mode");
            }
        }
    }

}
