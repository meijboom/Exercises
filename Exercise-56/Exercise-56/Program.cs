using System;
using System.Collections.Generic;
namespace Exercise56
{
  class MainClass
  {
    public static void Main()
    {
            Listvalidator();
            var now = new DateTime(today);

            
    }


        // 1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
        //
        //     If no one likes your post, it doesn't display anything.
        //     If only one person likes your post, it displays: [Friend's Name] likes your post.
        //     If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        //     If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        //
        // Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
        // Depending on the number of names provided, display a message based on the above pattern.

        public static void LikeTracker()
        {
            Console.WriteLine("write a name who liked the picture. press enter to exit.");
            List<String> names = new List<String>();
            var likes = names.Count - 2;
            var name = Console.ReadLine();
             
            while (name != "")
            { 
                names.Add(name);
                likes++;
                name = Console.ReadLine();
            }

            if (names.Count == 0)
            {
                Console.WriteLine("stopped");
                return;
            }

            if (names.Count == 1)
            {
                Console.WriteLine(names[0] + " likes your post.");
                return;
            }

            if (names.Count == 2)
            {
                Console.WriteLine(names[0] + " and " +names[1] + " like your post");
                return;
            }

            if (names.Count > 2)
            {
                Console.WriteLine(names[0] + " " + names[1] + " and " + (likes) + " others like your post.");
                return;
            }
        }

        // 2 - Write a program and ask the user to enter their name.
        //     Use an array to reverse the name and then store the result in a new string.
        //     Display the reversed name on the console.
        public static void Reverso()
        {
            Console.WriteLine("Enter your name and I will reverse it.");
            var name = Console.ReadLine();
            var arr = name.ToCharArray();
            Array.Reverse(arr);
            arr.ToString();
            Console.WriteLine(arr);

        }

        // 3 - Write a program and ask the user to enter 5 numbers.
        //     If a number has been previously entered, display an error message and ask the user to re-try.
        //     Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        public static void ListSort()
        {
            List<string> numbers = new List<string>();
            var Max = 5;
            Console.WriteLine("Enter " + Max + " numbers.");
            while (numbers.Count < Max)
            {
                var number = Console.ReadLine();

                if (numbers.Contains(number))
                {
                    Console.WriteLine("Error, try a number that is not already in the list.");
                }
                else
                {
                    numbers.Add(number);
                    Console.WriteLine("Enter " + (Max - numbers.Count) + " more numbers");
                }
                if (numbers.Count == 5)
                {
                    Console.WriteLine("List is sorting. \nBefore:");
                    foreach(string num in numbers)
                    {
                        Console.WriteLine("'" + num + "'");
                    }
                    Console.WriteLine("after:");
                    List<int> numbersInt = numbers.ConvertAll(num => int.Parse(num));
                    Console.WriteLine("Converted from String to Int.");
                    numbersInt.Sort();
                    Console.WriteLine("Sorted the list");
                    foreach (int num in numbersInt)
                    {
                        Console.WriteLine(num);
                    }
                }
            }
            Console.WriteLine("End of loop");
        }
        // 4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit.
        //     The list of numbers may include duplicates.
        //     Display the unique numbers that the user has entered.
        public static void Unique()
        {
            Console.WriteLine("Enter a number.. \nType 'Quit' to stop.");
            List<string> total = new List<string>();
            List<string> uniqueNr = new List<string>();
            var input = Console.ReadLine();
            while (input != "Quit")
            {
                // ask for a number
                input = Console.ReadLine();

                // if quit or Quit
                if (input == "quit" || input == "Quit")
                {
                    break;
                }
                // check if input = unique.
                if (!total.Contains(input))
                {
                    uniqueNr.Add(input);
                }
                // add to total list
                total.Add(input);
            }
            Console.WriteLine("You entered " + total.Count + " numbers \nOf which " + uniqueNr.Count + " were Unique.");
            Console.WriteLine("Your unique numbers:");
            foreach(string str in uniqueNr)
            {
                Console.WriteLine(str);
            }
        }


        // 5 -  Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).
        //      If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
        //      otherwise, display the 3 smallest numbers in the list.

        public static void Listvalidator()
        {
            Console.WriteLine("Enter a list, with numbers separated by comma.");
            while (true)
            {
                List<int> IntList = new List<int>();
                var input = Console.ReadLine().Split(',');
                if (input.Length < 5)
                {
                    Console.WriteLine("Invalid list! \nPlease retry.");
                    continue;
                }

                // sort the list
                // add items to the list from array
                foreach (var i in input)
                {
                    IntList.Add(Convert.ToInt32(i));
                    IntList.Sort();
                }
                Console.WriteLine(IntList[0] + " " + IntList[1] + " " + IntList[2]);
                Console.WriteLine("Array sorted.");
            }
        }
  }
}
 