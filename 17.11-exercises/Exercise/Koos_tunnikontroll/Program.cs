using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koos_tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");

            Console.WriteLine("------------------------------------------");

            double total = 0;

            while (true)
            {
                Console.Write("Enter price of food item [-1 to quit]: ");
                string input = Console.ReadLine();
                                
                double value = double.Parse(input);
                
                if (value == -1)
                    break;

                total = total + value;

            }
            double gratuity = total * 0.15;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Subtotal: € {total:F2}"); //String.Format
            
            Console.WriteLine($"15% Gratuity: € {gratuity:F2}");//Math.Round(gratuity, 2)
            Console.WriteLine($"Total: € {(total-gratuity):F2}");
            Console.WriteLine("Press Any key to continue");

            Console.ReadLine();
            }
        }
    }

