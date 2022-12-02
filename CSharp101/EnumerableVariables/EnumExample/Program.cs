using System;

namespace EnumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int instantTemperature = 22;

            Console.WriteLine(Days.Sunday + " / Temperature: " + instantTemperature + " degrees Celsius");

            if (instantTemperature < (int)Temperature.Normal)
                Console.WriteLine("Let's wait until the weather warms up before we go outside.");
            else if (instantTemperature >= (int)Temperature.TooHot)
                Console.WriteLine("Stay home because it's very hot.");
            else
                Console.WriteLine("Let's go outside because the weather is so nice.");

            Console.ReadLine();
        }

        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Temperature
        {
            Cold    = 16,
            Normal  = 20,
            Hot     = 25,
            TooHot  = 30
        }
    }
}
