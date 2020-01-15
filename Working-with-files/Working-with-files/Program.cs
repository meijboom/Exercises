using System;
using System.IO;
using System.Collections.Generic;

namespace Workingwithfiles
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Directory.CreateDirectory(@"/Users/dennismeijboom/Projects/Exercises/Working-with-files/Working-with-files/texttest/");
            string[] input = { "1a", "2b", "3asda", "4aasdaw", "5ahadfgsg", "6aasdasdcnuytre", "7sdfghjka", "8hgjfdsaa", "9Dennis Meijboom uit Vlaardingen", "10dfgtrwegwrwewra", "11adsadasa" };

            var path = @"/Users/dennismeijboom/Projects/Exercises/Working-with-files/Working-with-files/texttest/";
            var file = path + "test.txt";

            if (!Directory.Exists(@"/Users/dennismeijboom/Projects/Exercises/Working-with-files/Working-with-files/texttest/"))
            {
                Directory.CreateDirectory(@"/Users/dennismeijboom/Projects/Exercises/Working-with-files/Working-with-files/texttest/");
            }

            if (!File.Exists(path + "test.txt"))
            {
                File.Create(path + "test.txt");
            }
            
            Writefile(file, input);
            var red = Readfile(file);
            Console.WriteLine(red);

        }
        public static string Readfile(string filePath)
        {
            if (File.Exists(filePath))
            {

                var text = File.ReadAllText(filePath);

                Console.WriteLine("Read file.");
                Console.WriteLine("content in the file: \n{0}", text);

                List<string> arr = new List<string>(text.Split());
                //var arr = text.Split();

                int longNum = 0;
                string longStr = "placeholder";

                // check longest word and save in longStr.
                foreach (var word in arr)
                {
                    if (word.Length > longNum)
                    {
                        longNum = word.Length;
                        longStr = word;
                    }

                }

                // if arr is not empty, print how many words the file contain.
                // plus the longest word in the file.
                if (arr.Count > 0)
                    {
                    var totalwords = arr.Count.ToString();
                    
                    return string.Format("file contains {0} words, of which the longest is {1}", totalwords, longStr);
                    }
            }
            return "File does not exist.";
        }
        public static string Writefile(string filePath, string[] content)
        {
            if (File.Exists(filePath))
            {
                File.WriteAllLines(filePath, content);
            }
            return "File does not exist";
        }
    }
}
