using System;

namespace PasswordGenerator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hallo, welkom bij uw persoonlijke password generator.");

            var random = new Random();

            const int passwordLength = 13;
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));
            var password = new string(buffer);

            Console.WriteLine(password);

        }
    }
}
