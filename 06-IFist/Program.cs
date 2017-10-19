using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IFist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta arv [1-100] ning ma ütlen, kas arv on väiksem või suurem?");
            Console.WriteLine();
            Console.Write("Sisesta arv: ");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            Console.WriteLine();

            int magicNumber = 16;

            if (number > magicNumber)
            {
                Console.WriteLine($"Arv {number} on suurem.");
            }
            if (number < magicNumber)
            {
                Console.WriteLine($"Arv {number} on väiksem.");
            }



            Console.ReadLine();
        }
    }
}
