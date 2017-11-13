using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6by6MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //kood, mis prindib välja 6*6 korrutustabelit. Kasuta kahte FOR-i.

            Console.WriteLine("See on 6 x 6 korrutustabel.");


            Console.Write("-------------------------------------------------");
            for (int i = 1; i < 7 ; i++)
            {
                Console.WriteLine();
                Console.Write(" " + i +" |");

                for (int n = 1; n < 7 ; n++)
                {
                    Console.Write($" {i * n} \t| ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");

            //Õpetajaga koos
            //for (int i = 0; i <= 6; i++)
            //{
            //    Console.Write(i + "\t");

            //    for (int n = 1; n <= 6; n++)
            //    {
            //        if (i > 0)
            //            Console.Write(i * n + "\t");
            //        else
            //            Console.Write(n + "\t");
            //    }
            //    Console.Write("\n"");
            //}
            //Console.WriteLine();

            Console.ReadLine();

        }
    }
}
