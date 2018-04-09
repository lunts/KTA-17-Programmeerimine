using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksam
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ülesanne 1 
            //Luua programm mis küsib inimeste nimesi niikaua kuni sisestatakse erimärk „-1“. 
            //Iga sisestatud nimi lisatakse massiivi mis kuvatakse kasutajale programmi lõpus välja.Kindlasti tuleb veenduda, 
            //et esimene täht oleks suur.Selle võid lahendada nii, et palud kasutajal sisestada sisendi õigel kujul 
            //või siis vaikimisi teed programmis esimese tähe alati suureks.

            Console.WriteLine("Sisesta inimeste eesnimed ükshaaval andmebaasi. Kui oled lõpetanud sisesta -1.");

            //string[] names = new string[] { };
            var nameList = new List<string>();

            while (true)
            {
                Console.Write("Eesnimi: ");
                string firstName = Console.ReadLine();
                

                if (firstName != "-1")
                {
                    nameList.Add(firstName);
                }

                //names = nameList.ToArray();  

                else
                {
                    Console.Write("Sisestatud nimed: ");
                    for (int i = 0; i < nameList.Count; i++)
                    {
                        var s = nameList[i];
                        var  upper = char.ToUpper(s[0])+ s.Substring(1).ToLower();
                        Console.Write(upper + ", ");
                    }
                    break;
                }
                
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
