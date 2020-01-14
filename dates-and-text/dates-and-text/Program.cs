using System;
using System.Collections.Generic;

namespace datesandtext
{
  class MainClass
  {
    public static void Main(string[] args)
    {
        var sentence = "this is going to be a really really really really really really really really really really really long text";
        var summary = SymmerizeText(sentence, 25);
            Console.WriteLine(summary);
    }
    public static string SymmerizeText(string text, int maxLength = 20)
    {

      if (text.Length < maxLength)
      {
        Console.WriteLine(text);
      }

      var words = text.Split(' ');
      var totalCharacters = 0;
      var summaryWords = new List<string>();

      foreach (var word in words)
      {
        summaryWords.Add(word);

        totalCharacters += word.Length + 1;
        if (totalCharacters > maxLength)
        {
          break;
        }
      }
      return String.Join(" ", summaryWords) + "....";

    }
  }
}
