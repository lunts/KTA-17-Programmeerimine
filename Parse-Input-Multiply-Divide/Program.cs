using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_Input_Multiply_Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen kalkulaatori programm.");
            Console.WriteLine("Ütle mulle 2 numbrit ja ma ütlen Sulle nende korrutise ja jagatise");
            Console.WriteLine();

            Console.Write("Esimene number: ");
            string input1 = Console.ReadLine();
            
            Console.Write("Teine number: ");
            string input2 = Console.ReadLine();
            Console.WriteLine();

            //teeb sisestatud teksti number formaati
            int number1 = int.Parse(input1);
            int number2 = int.Parse(input2);

            int korrutis = number1 * number2;
            int jagatis = number1 / number2;

            Console.WriteLine($"Korrutades {input1} ja {input2} on tulemuseks: {korrutis}");
            Console.WriteLine("Jagades " + input1 + " ja " + input2 + " on tulemuseks: " + jagatis);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
    }
}
