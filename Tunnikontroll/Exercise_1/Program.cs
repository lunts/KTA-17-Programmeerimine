using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See on allahindluse arvutamise programm. Sisesta ostusumma: ");
            string input = Console.ReadLine();
            int summa = int.Parse(input);

            if ((summa >= 50) && (summa < 250))
            {
                Console.WriteLine();
                Console.WriteLine("Tavaklient: \nSumma: " + summa + "\nAllahindlus: 10% \nTasuda: " + summa * 0.9);
                Console.WriteLine();
                Console.WriteLine("Püsiklient: \nSumma: " + summa + "\nAllahindlus: 20% \nTasuda: " + summa * 0.8);
            }

            if ((summa >= 250) && (summa < 350))
            {
                Console.WriteLine();
                Console.WriteLine("Tavaklient: \nSumma: " + summa + "\nAllahindlus: 20% \nTasuda: " + summa * 0.8);
                Console.WriteLine();
                Console.WriteLine("Püsiklient: \nSumma: " + summa + "\nAllahindlus: 30% \nTasuda: " + summa * 0.7);
            }

            if (summa >= 350)
            {
                Console.WriteLine();
                Console.WriteLine("Tavaklient: \nSumma: " + summa + "\nAllahindlus: 30% \nTasuda: " + summa * 0.7);
                Console.WriteLine();
                Console.WriteLine("Püsiklient: \nSumma: " + summa + "\nAllahindlus: 40% \nTasuda: " + summa * 0.6);
            }
            Console.ReadLine();
        }
    }
}
