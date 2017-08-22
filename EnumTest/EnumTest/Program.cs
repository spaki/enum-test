using System;

namespace EnumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToString() of an Enum will return the description
            // in this case "Friday"
            Console.WriteLine(DayOfWeek.Friday.ToString());

            // this will return the Enum number
            Console.WriteLine((int)DayOfWeek.Friday);
            var numberOfTheDayOfWeek = 5;

            Console.WriteLine(numberOfTheDayOfWeek.ToEnum<DayOfWeek>());
            var stringOfTheDayOfWeek = "Friday";

            Console.WriteLine(stringOfTheDayOfWeek.ToEnum<DayOfWeek>());

            Console.ReadLine();
        }
    }

    public static class EnumConversion
    {
        public static T ToEnum<T>(this string value) => (T)Enum.Parse(typeof(T), value);

        public static T ToEnum<T>(this int value) => (T)Enum.ToObject(typeof(T), value);
    }
}
