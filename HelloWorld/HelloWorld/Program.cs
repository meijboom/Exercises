using System;
using HelloWorld.Math;
namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var methodName = "Express";
            ShippingMethod shippingmethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingmethod);

            Console.WriteLine("Wat is je voornaam?");
            Console.WriteLine("Wat is je achternaam?");

            var john = new Person
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine()
            };
            var date = DateTime.Now;
            john.Introduce();
            Calculator calculator = new Calculator();

            Console.WriteLine($"Hallo daar, {john.FirstName}, het is {date:t}, op {date:d} ");

        }

    }


}

