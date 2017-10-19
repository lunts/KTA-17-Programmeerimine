using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Parse_Input_to_int
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen kalkulaatori programm. Ütle mulle 2 numbrit ja ma ütlen Sulle nende summa");
            Console.WriteLine();

            Console.Write("Esimene number: ");

            string input1 = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Teine number: ");
            string input2 = Console.ReadLine();
            Console.WriteLine();

            int number1 = int.Parse(input1);
            int number2 = int.Parse(input2);
          

            Console.Write("Tulemuseks on: " + (number1 + number2));
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");

            Console.ReadLine();
        }
    }
}
