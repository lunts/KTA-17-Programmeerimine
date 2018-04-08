using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] birthYears = new int[30] {1940, 1941, 1942, 1950, 1951, 1952, 1960, 1961, 1962, 1963, 1970, 1971, 1972, 1980, 1981, 1982, 1983, 1984, 1985, 1986, 1987, 1988, 1989, 1990, 1991, 1992, 1993, 1994, 2000, 2001};
            //https://stackoverflow.com/questions/13755007/c-sharp-find-highest-array-value-and-index
            int maxYear = birthYears.Max();
            int pMax = Array.IndexOf(birthYears, maxYear);
            int minYear = birthYears.Min();
            int maxAge = 2018 - minYear;
            int minAge = 2018 - maxYear;
            //int avg = birthYears.Average;

            Console.WriteLine("Maksimaalne vanus: " + maxAge);
            Console.WriteLine("Minimaalne vanus: " + minAge);

            Int32 timestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            Console.WriteLine("Timestamp: " +timestamp);



            Console.WriteLine("UUS KATSETUS");
            DateTime[] dateTimes = new DateTime[]
            {
               new DateTime(1970, 1, 1),
               new DateTime(19802, 1, ) },

            }
            Console.ReadKey();
        }
    }
}
