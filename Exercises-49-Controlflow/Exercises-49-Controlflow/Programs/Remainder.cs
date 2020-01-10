using System;
namespace Exercises49Controlflow.Programs
{
    public class Remainder
    {
        public int Remains(int number)
        {
            var modulo3 = 0;
            for (var i = number; i > 0; i--)
   
                if (i % 3 == 0)
                {
                    modulo3++;
                    Console.WriteLine(modulo3);
                    
                }
          return 1;
        }
    }
}
