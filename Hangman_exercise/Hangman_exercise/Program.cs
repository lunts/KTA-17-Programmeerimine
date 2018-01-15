using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_exercise
{
    public enum Words
    {
        SIGA = 1,
        LAMMAS = 2,
        PÄIKE = 3,
        KOOL =4,
        JÄÄÄÄR = 5
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See on sõna arvamise mäng. Arva ära sõna pakkudes tähti. Sul on 5 võimalust eksimiseks.");
            Console.WriteLine("Kasutada on eesti tähestik: A, B, C, .");


            string[] words = new string[5] { "SIGA", "LAMMAS", "PÄIKE", "KOOL", "JÄÄÄÄR" };
            var random = new Random().Next(0, words.Length-1);
            var gameWord = words[random];
            Console.WriteLine("Sõna pikkus: " + gameWord.Length);

            Console.Write("Arvuti valis sõna: ");
            for (int i =0; i <= (gameWord.Length+2); i++)
                {
                    Console.Write("_ ");
                    i++;
                }
            Console.WriteLine();

            
            List<string> letters = new List<string>();
            
            while (true)
            {
                Console.Write("Paku tähte: ");
                string input = Console.ReadLine();

                letters.Add(input);

                if (gameWord.Contains(input))
                {
                    Console.WriteLine("yes!");
                    // mitmes täht on sõnas?
                }
                else
                    Console.WriteLine("Vale! Paku tähte:");
                //lisa  täht array'sse või listi, et võrrelda

                //if (input == "-1")
                //    break;
            }



            Console.WriteLine("Õige! Sõna: S _ _ _");
            Console.WriteLine("Paku tähte: A");
            Console.WriteLine("Vale! Jäänud on veel 4 eksimisvõimalust. Sõna: S _ _ _");
            Console.WriteLine("Paku tähte: I");
            Console.WriteLine("Õige! Sõna: S I _ _");
            Console.WriteLine("Paku tähte: G");
            Console.WriteLine("Õige! Sõna: S I G _");
            Console.WriteLine("Paku tähte: A");

            Console.WriteLine("Tubli, arvasid ära! Sõna on: S I G A");
            Console.ReadKey();
        }
    }
}
// hoitakse meeles õiget sõna
//if-else kas i on arvatud, ei ole, prindi _, 
//hoitakse meeles kõiki kasutaja poolt sisestatud tähti
// iga tähe printimise korral otsustada kas täht või _ (if/else kas on arvatud või mitte