using System;
namespace Exercises49Controlflow.Programs
{
    public class Factorial
    {
        public string Facto(string str)
        {
            int i, number, fact;

            number = int.Parse(str);
            fact = number;

            for (i = number - 1; i >= 1; i--)
            {
                fact *= i;
            }

            Console.WriteLine(str + "! = " + fact);
            return str;
        }
    }
}
