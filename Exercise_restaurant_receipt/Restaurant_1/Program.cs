using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");
            Console.WriteLine("-----------------------------------------------");
            string number;
            double total = 0;
            while (true)
            {
                Console.Write("Enter price of food item [-1 to quit]: ");
                number = Console.ReadLine();
                double price = double.Parse(number);

                if (price == -1)
                    break;

                total = total + price;
            }
           
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Subtotal: €{0}", Math.Round(total, 2));
            Console.WriteLine("15.00 % Gratuity: €{0}", Math.Round(total *0.15, 2));
            Console.WriteLine("Total: €{0}", Math.Round(total *0.85, 2));
            Console.WriteLine("Press any key to continue");

            Console.ReadLine();
        }
    }
}
