using System;

namespace HelloWorld
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public byte Age;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}

