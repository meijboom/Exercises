using System;
using System.Collections.Generic;

namespace datesandtext
{
  class MainClass
  {
    public static void Main(string[] args)
    {
        var sentence = "this is going to be a really really really really really really really really really really really long text";
        var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);
    }
  }
}
