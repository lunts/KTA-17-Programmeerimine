using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm, mis lubab sisestada N+1 hulga erinevaid sõnu, kuni sisestatakse -1");
            Console.WriteLine();

            List<string> words = new List<string>();

            while (true)
            {
                Console.Write("Sisesta sõna: ");
                string input = Console.ReadLine();
                
                if (input == "-1")
                    break;

                words.Add(input);
            }

            Console.WriteLine();
            Console.WriteLine($"Sisestasid sõnad: {string.Join(", ", words)}" );
            Console.WriteLine();

            var randomIndex = new Random().Next(0, words.Count - 1);
            Console.WriteLine($"Valin nendest välja suvalise: {words[randomIndex]} ");
            Console.ReadKey();
        }
    }
}
