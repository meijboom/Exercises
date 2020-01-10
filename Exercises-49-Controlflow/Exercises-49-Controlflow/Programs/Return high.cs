using System;
namespace Exercises49Controlflow.Programs
{
    public class Return_high
    {
        public string GiveBackHigh(string str)
        {
            var input = str;
            int max = 0;
      
            string[] strSplit = input.Split(',');
            int[] intArr = Array.ConvertAll(strSplit, int.Parse);
            foreach(int item in intArr)
            {
                Console.WriteLine((item) + "<- int item");
                if (item >= max)
                {
                    max = item;
                }

            }
            Console.WriteLine(max + "<- highest in the array");
            return str;
        }
    }
}
