using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _6KyuFridayThe13ths
{
    internal class Program
    {
        static void Main(string[] args)
        {
             DateTimeFormatInfo dtfi = CultureInfo.GetCultureInfo("en-US").DateTimeFormat;
      Type typ = dtfi.GetType();
            PropertyInfo[] props = typ.GetProperties();

            Console.WriteLine(Kata.FridayTheThirteenths(1999, 2000));
        }
    }
    public static class Kata
    {
        public static string FridayTheThirteenths(int Start, int End)
        {
            List<string> answer = new List<string>();
            if (Start > End)
            {
                End = Start;
            }

            for (int i = 0; i < End - Start + 1; i++)
            {
                answer.Add(All13thFriInYear(Start + i));
            }
            return string.Join(" ",answer); 
        }
        public static string All13thFriInYear(int year)
        {

            List<string> all13thFriInYear = new List<string>();

            for (int i = 1; i < 13; i++)
            {

                DateTime dateTime = new DateTime(year, i, 13);
                if (dateTime.DayOfWeek == DayOfWeek.Friday)
                {
                    all13thFriInYear.Add(dateTime.ToString("M'/'d'/'yyyy", CultureInfo.InvariantCulture));
                    
                }
            }

            return string.Join(" ", all13thFriInYear);

        }
    }
}
