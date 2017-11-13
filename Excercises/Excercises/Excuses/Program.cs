using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excuses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vabanduste genereerimise programm
            //Sisesta komadega eraldatud vabandused
            //>koer sõi ära, ema ei lubanud arvutis olla, ei viitsinud
            //Tänane vabandus on: ei viitsinud
            //Split


            Console.WriteLine("Sisesta komadega eraldatud vabandused.");
            Console.WriteLine();
            string input = Console.ReadLine();

            string[] massiiv = input.Split(',');

            int random = new Random().Next(0, massiiv.Length);

            Console.WriteLine($"Tänane vabandus on: {massiiv[random]}");

            Console.ReadLine();

            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.ReadLine();

            //int[] scores = new int[] { 97, 92, 81, 60 };

            // Define the query expression.
            //    IEnumerable<int> scoreQuery =
            //        from score in scores
            //        where score > 80
            //        select score;

            //// Execute the query.
            //foreach (int i in scoreQuery)
            //{
            //    Console.Write(i + " ");
            //}
        }
    }
}
