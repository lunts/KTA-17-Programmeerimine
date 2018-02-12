using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_roll
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("> /Dice_roll 3d6 2d8");
            Console.WriteLine();
            Console.WriteLine();

            //Dice object 
            //[type] [nimi] = new [class nimi]()
            Dice dice = new Dice();
            int summa = 0;
            for (var i = 0; i < 3; i++)
            {
                var
                Console.WriteLine($"{dice.Roll(6)}");
            }

            for (var j = 0; j < 2; j++)
            {
                int d8 = random.Next(1, 9);
                Console.WriteLine($"1d8: {d8}");
                summa = summa + d8;
            }

            //esialgne...
            var random = new Random();
            int summa = 0;
            for (var i = 0; i < 3 ; i++)
            {
                int d6 = random.Next(1, 7);
                Console.WriteLine($"1d6: {d6}");
                summa = summa + d6;
            }

            for (var j = 0; j < 2; j++)
            {
                int d8 = random.Next(1, 9);
                Console.WriteLine($"1d8: {d8}");
                summa = summa + d8;
            }


            Console.WriteLine();
            Console.WriteLine($"Roll total: {summa}");
            Console.WriteLine();
            Console.WriteLine("> ");

            Console.ReadLine();

        }
    }
    
}
