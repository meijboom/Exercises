using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises
{
  class MainClass
  {
    public static void Main(string[] args)
    {
            //Consecutive("1-2-3-4-5-6-7-8");
            //Consecutive("5-4-3-2-1");
            //Consecutive("1-4-2-3-8-6-7-9");
            //Duplicate("1-2-3-4-5-6");
            //Duplicate("1-2-3-4-5-3");
            //Duplicate("");
            //TimeValidator("22:00");
            //TimeValidator("25:00");
            //TimeValidator("2:00");
            ToCamelCase("hello hello hello hello");
            ToCamelCase("HELLO HELLO HELLO HELLO");
            ToCamelCase("Hello heLLo hEllo hellO");

        }

       // 1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. 
       // For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

        // flow used:
        // input str -> split to str[] -> str[] to list<int> -> sort -> compare -> output correct phrase.
        public static void Consecutive(string input)
        {

            List<int> arr = new List<int>();
            List<int> sortedArr = new List<int>();

            string[] splittedStr = input.Split('-');
            foreach (var i in splittedStr)
            {
                arr.Add(Convert.ToInt32(i));
                sortedArr.Add(Convert.ToInt32(i));
            }

            sortedArr.Sort();

            if (sortedArr.SequenceEqual(arr))
            {
                Console.WriteLine(input);
                Console.WriteLine("ascending");
                return;
            }

            sortedArr.Reverse();
            if (sortedArr.SequenceEqual(arr))
            {
                Console.WriteLine(input);
                Console.WriteLine("descending");
                return;
            }
            Console.WriteLine(input);
            Console.WriteLine("non consecutive");
            return;
        }



        // 2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
        //     If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.
        //     If so, display "Duplicate" on the console. 
        
        public static void Duplicate(string input)
        {
            if (input != "")
            {
                var strArr = input.Split('-');
                var nodupe = strArr.Distinct().ToList();
                strArr.ToList();
                if (strArr.SequenceEqual(nodupe))
                {
                    Console.WriteLine("No dupes found in: " + input);
                    return;
                }
                Console.WriteLine("dupes found in: " + input);
                return;

            }
            Console.WriteLine("Quit app.");
            return;
        }

       // 3 -  Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00). A valid time should be between 00:00 and 23:59.
       //      If the time is valid, display "Ok"; otherwise, display "Invalid Time".
       //      If the user doesn't provide any values, consider it as invalid time.
        public static void TimeValidator(string input)
        {
            _ = new DateTime();
            if (DateTime.TryParse(input, out DateTime date))
            {
                Console.WriteLine(date.ToString("HH:mm"));
                Console.WriteLine("parsed correctly, and valid.");
                return;
            }
            Console.WriteLine(input + " <- is an invalid time.");
            return;
        }

        // 4 - Write a program and ask the user to enter a few words separated by a space.
        //     Use the words to create a variable name with PascalCase.
        //     For example, if the user types: "number of students", display "NumberOfStudents".
        //     Make sure that the program is not dependent on the input.
        //     So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
        public static void ToCamelCase(string input)
        {
            // uppercase the first letter of word
            var lower = input.ToLower();
            var lowerArr = lower.Split(' ');
            List<string> Camelcased = new List<string>();
            foreach (var word in lowerArr)
            {
                var upperfirst = char.ToUpper(word[0]) + word.Substring(1);
                Camelcased.Add(upperfirst);
            }   
            var CamelcasedArr = Camelcased.ToArray();
            var stringbuild = new StringBuilder();
            
            foreach ( var word in CamelcasedArr)
            {
                stringbuild.Append(word);
            }
                Console.WriteLine(stringbuild);
        }

        
        //  5 - Write a program and ask the user to enter an English word.
        //      Count the number of vowels (a, e, o, u, i) in the word.
        //      So, if the user enters "inadequate", the program should display 6 on the console.
        public static void VowelCounter(string input)
        {

        }
    }
}
