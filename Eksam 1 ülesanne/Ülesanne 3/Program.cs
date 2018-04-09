using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ülesanne 3
            //Proramm küsib kasutaja käest kolme sisendit: 
            //a) minimaalne aasta arv, b) maksimaalne aasta arv, c) suvaliselt genereeritavate andmete hulka. 
            //Vastavalt sisestatud andmetele genereeritakse suvalislet etteantud vahemikus ja hulgal timestamp’e.

            Console.WriteLine("Sisesta minimaalne aastaarv");
            string minYear = Console.ReadLine();
            int yearMin = int.Parse(minYear);

            Console.WriteLine("Sisesta maksimaalne aastaarv");
            string maxYear = Console.ReadLine();
            int yearMax = int.Parse(maxYear);

            Console.WriteLine("Sisesta mitu korda");
            string Data = Console.ReadLine();
            int data = int.Parse(Data);


            Random rnd = new Random();
            for (int i = 1; i <= data; i++)
            {
                int output = rnd.Next(yearMin, yearMax);
                Console.WriteLine(new DateTime(output, 1, 2));
                //Console.WriteLine(i + ". " + output);
            }

            
           


            Console.ReadKey();

        }
    }
}
