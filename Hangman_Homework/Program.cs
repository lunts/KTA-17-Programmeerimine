using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("See on sõna arvamise mäng. Arva ära sõna pakkudes tähti. Sul on 5 võimalust eksimiseks.");

            string[] words = { "SIGA", "LAMMAS", "PÄIKE", "KOOL", "JÄÄÄÄR", "KUUUURIJA", "KUULILENNUTEETUNNELILUUK", "MAFFIA", "PUNANE", "ORAV", "NINASARVIK", "KULLAKALLIS", "EIDEKE", "PÖÖRIÖÖ", "MAIKRAHV", "KESKUS", "FOOR", "KARAMELL" };
            var random = new Random().Next(0, words.Length);
            var gameWord = words[random];
           

            StringBuilder displayToPlayer = new StringBuilder(gameWord.Length);
            for (int h = 0; h < gameWord.Length; h++)
                displayToPlayer.Append('_');


            Console.Write("Arvuti valis sõna: ");
            Console.Write(displayToPlayer.ToString());
            Console.WriteLine();

           
            string input;
            char letter;
            int displayedLetters = 0;
            int j = 0;

            while (true)
            {
                Console.Write("Paku tähte: ");
                input = Console.ReadLine().ToUpper();
                letter = input[0];

                if (gameWord.Contains(letter))
                {
                    for (int h=0; h<gameWord.Length; h++)
                    {
                        if (gameWord[h] == letter)
                        {
                            displayToPlayer[h] = gameWord[h];
                            displayedLetters++;
                        }
                    }

                    if (displayedLetters == gameWord.Length)
                    {
                        Console.Write("Võitsid!!! Sõnaks oli "+ displayToPlayer.ToString() +".");
                        Console.WriteLine();
                        break;
                    }
                    
                    Console.WriteLine(displayToPlayer.ToString());
                    Console.WriteLine();
                 }

                else
                {
                    j++;
                    if (j < 5)
                    {
                        Console.WriteLine("Vale! See oli " + j + ". kord. " + displayToPlayer.ToString());
                        
                        Console.WriteLine();
                    }

                    if (j==5)
                    {
                        Console.WriteLine("Võimalused otsas. Kaotasid! Õige sõna oli " + gameWord + ".");
                        break;
                    }
                }
             }

            Console.ReadKey();

        }
    }
}