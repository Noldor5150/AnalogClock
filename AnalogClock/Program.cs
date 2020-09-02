using System;

namespace AnalogClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Hours number from 1-12");
            var hoursAsString = Console.ReadLine();
            int hours;

            while(!int.TryParse(hoursAsString, out hours) || (hours > 12 || hours < 1))
            {
                Console.WriteLine("this is not/or bad number");
                hoursAsString = Console.ReadLine();
            }

            Console.WriteLine("Please enter Minutes number from 0-59");
            var minutesAsString = Console.ReadLine();
            int minutes;

            while (!int.TryParse(minutesAsString, out minutes) || (minutes > 59 || minutes < 0))
            {
                Console.WriteLine("this is not/or bad number");
                minutesAsString = Console.ReadLine();
            }
            Console.WriteLine(CalculateAngle(hours, minutes));
        }

        static string CalculateAngle(int hours, int minutes)
        {
            double hoursAngle = hours * 30.0 + minutes / 60.0 * 30.0;
            double minutesAngle = minutes * 6.0;
            double differenceAngle = Math.Abs(hoursAngle - minutesAngle);
            if (differenceAngle > 180)
            {
                differenceAngle = 360 - differenceAngle  ;
            }
            return $"Smallest angle between the arrows is {differenceAngle}°";
        }
    }
}
