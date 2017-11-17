using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll_17._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");

            Console.WriteLine("------------------------------------------");
            Console.Write("Enter price of food item [-1 to quit]: ");
            string input = Console.ReadLine();
            decimal number = decimal.Parse(input);

            decimal subtotal = number;
            

            while (true)
            {
                    if( number != (-1))
                Console.Write("Enter price of food item [-1 to quit]: ");
                input = Console.ReadLine();
                number = decimal.Parse(input);
                subtotal = subtotal + number;

                if (number == -1)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Subtotal: " + Math.Round(subtotal, 4));
                    Console.WriteLine($"15% Gratuity: {Math.Round((subtotal), 4)}");//Math.Round(KMI, 2)
                    Console.WriteLine("Total: " + Math.Round(subtotal, 4));
                    Console.WriteLine("Press Any key to continue");
                    break;
                }
            
            }

            
            

            Console.ReadLine();
        }
    }
}
