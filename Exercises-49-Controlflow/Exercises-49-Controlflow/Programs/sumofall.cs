using System;
namespace Exercises49Controlflow.Programs
{
    public class Sumofall
    {
        public int Sum(string num)
        {
            int total = 0;

            while (num != "ok")
            {
                // num = string, parse to int.
                var input = int.Parse(num);
                total += input;
                Console.WriteLine(total);
                num = Console.ReadLine();

            }
            Console.WriteLine("closed loop.");
            return 0;
        }
    }
}
