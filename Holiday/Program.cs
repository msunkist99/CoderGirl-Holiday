using System;

namespace Holiday
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter your departure date as mm/dd/yyyy");
            DateTime departureDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("How many days will you be gone?");

            int daysGone = Convert.ToInt16(Console.ReadLine());

            string returnDay = DayReturning(departureDate, daysGone);

            Console.WriteLine($"You will return on {returnDay}.");

            Console.ReadLine();
        }

        // TODO: Create a method that takes the day you are leaving on vacation and how many days you will be gone and return the name of the day of the week you will return.

        public static string DayReturning(DateTime departureDate, int daysGone)
        {
            Console.WriteLine($"You are leaving on {departureDate.DayOfWeek}.");
            Console.WriteLine($"You will be away for {daysGone} days.");

            string returnDay = departureDate.AddDays(daysGone).DayOfWeek.ToString();

            return returnDay;
        }
    }
}
