using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutused_eksamiks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta inimeste eesnimed ükshaaval andmebaasi. Kui oled lõpetanud sisesta -1.");

            string[] names = new string[] { };
            while (true)
            { 
            Console.Write("Eesnimi: ");
            string firstName = Console.ReadLine();

                if (firstName != "-1")
                {
                    var nameList = new List<string>();
                    nameList.Add(firstName);
                    names = nameList.ToArray();


                }
                else
                {
                    
                    for (int i = 0; i < names.Length; i++)
                    {
                        Console.Write(names[i]);
                        if (i != names.Length - 1)
                            Console.Write(", ");
                    }
                    break;
                }
                
            }


            Console.WriteLine();
           // Console.WriteLine("[{ 0}]", string.Join(", ", names));

            Console.ReadKey();
        }
    }
}
