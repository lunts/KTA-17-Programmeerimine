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
            //Ülesanne 4
            //Programmis on defineeritud masiiv mis sisaldab umbes 30 erinevat timestamp’i mis illustreerivad inimeste sünniaega, 
            //näiteks vahemikus alates 1940 – 2010.Programmi ülesanne on leida nende timestamp’ide põhjal:
            //maksimaalne vanus
            //keskmine vanus aastates
            //minimaalne vanus
            //millisel kuul on kõige rohkem sünnipäevi
            //kõik timestamp’id sorteerituna kasvavalt

            DateTime[] dateTimes = new DateTime[30]
            {
                new DateTime(1970, 1, 5),
                new DateTime(1980, 12, 12),
                new DateTime(1990, 3, 14),
                new DateTime(2000, 12, 1),
                new DateTime(2010, 12, 2),
                new DateTime(1971, 12, 5),
                new DateTime(1981, 12, 12),
                new DateTime(1991, 3, 14),
                new DateTime(2001, 4, 1),
                new DateTime(2011, 5, 2),
                new DateTime(1972, 12, 5),
                new DateTime(1982, 2, 12),
                new DateTime(1992, 3, 14),
                new DateTime(2002, 4, 1),
                new DateTime(2012, 5, 2),
                new DateTime(1973, 12, 5),
                new DateTime(1983, 12, 12),
                new DateTime(1993, 3, 14),
                new DateTime(2003, 4, 1),
                new DateTime(2013, 5, 2),
                new DateTime(1974, 1, 5),
                new DateTime(1984, 2, 12),
                new DateTime(1994, 3, 14),
                new DateTime(2004, 4, 1),
                new DateTime(2014, 5, 2),
                new DateTime(1975, 1, 5),
                new DateTime(1985, 2, 12),
                new DateTime(1995, 3, 14),
                new DateTime(2006, 4, 1),
                new DateTime(2016, 5, 2)
            };

            //Min ja Max
            Array.Sort(dateTimes);
            DateTime maxValue = dateTimes[dateTimes.Length -1];
            DateTime minValue = dateTimes[0];
            var today = DateTime.Today;
            if (minValue.Month > today.Month && minValue.Day > today.Day)
            {
                var maAge = today.Year - minValue.Year -1;
                var miAge = today.Year - maxValue.Year - 1;
                Console.WriteLine("Maksimaalne vanus: " + maAge);
                Console.WriteLine("Minimaalne vanus: " + miAge);
            }
            else
            {
                var mxAge = today.Year - minValue.Year;
                var mnAge = today.Year - maxValue.Year;
                Console.WriteLine("Maksimaalne vanus: " + mxAge);
                Console.WriteLine("Minimaalne vanus: " + mnAge);
            }


            //Keskmine vanus
            List<int> ages = new List<int> { };
            for (int i = 0; i < dateTimes.Length; i++)
            {
                int age = today.Year - dateTimes[i].Year;
                ages.Add(age);
            }
            double average = ages.Average();

            Console.WriteLine("Keskmine vanus aastates: " + Math.Round(average, 0));

            //Kuu mood
            Console.WriteLine();
            List<int> months = new List<int> { };
            for (int i = 0; i < dateTimes.Length; i++)
            {
                int month = dateTimes[i].Month;
                months.Add(month);
            }
            int mode =  months.GroupBy(n => n).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
            
            Console.WriteLine("Kuu, milles on kõige rohkem sünnipäevi: " + mode);


            //Kõik sorteerituna
            Console.WriteLine();
            Console.WriteLine("Kõik timestampid sorteerituna kasvavalt: " );
            foreach (var item in dateTimes)
            { 
                Console.WriteLine(item.ToString());
            }

            


                Console.ReadKey();
        }
    }
}
