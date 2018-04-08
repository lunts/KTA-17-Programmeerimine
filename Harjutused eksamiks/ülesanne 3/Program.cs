using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ülesanne_3
{
    class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine(i + ". " + output);
            }
            
            Console.ReadKey();

        }
    }
}
