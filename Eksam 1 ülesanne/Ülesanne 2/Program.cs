using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ülesanne 2
            //Sul on programmis defineeritud massiiv järgnevate nimedega: 
            //Kaur, Mattias, Kristel, Heleri, Trevor, Kristjan, Kelli, Kevin, Maarika, Laura.
            //Programm küsib kasutaja käest sisendit.Sisendiks võib olla üks sõna, lause või miks mitte ka 10 lauset.
            //Ülesanne on kasutajale programmi lõpus kuvada tema sisestatud sisend, aga nii, et kõik nimed oleks kindlasti suure algustähega. 
            //Näiteks kui kasutaja sisestab teksti: „kevin ja heleri mängisid koos liivakastis. trevor vaatas pealt ning kristel kiikus.“ 
            //siis tulemuseks peab olema: „Kevin ja Heleri mängisid koos liivakastis. Trevor vaatas pealt ning Kristel kiikus.“

            Console.WriteLine("Palun sisendit lausetega, kus on järgmised nimed: Kaur, Mattias, Kristel, Heleri, Trevor, Kristjan, Kelli, Kevin, Maarika, Laura");
            Console.WriteLine("Sisestades nime väikse tähega, kuvab arvuti nime õigesti.");
            Console.Write("Sisend: ");
            string[] names = new string[10] { "Kaur", "Mattias", "Kristel", "Heleri", "Trevor", "Kristjan", "Kelli", "Kevin", "Maarika", "Laura" };
            string input = Console.ReadLine();

            List<string> words = input.Split(' ').ToList();

            foreach (var word in words)
            {
                var upper = char.ToUpper(word[0]) + word.Substring(1);
                if (names.Any(upper.Contains))
                {
                    Console.Write(upper + " ");
                }

                else
                {
                    Console.Write(word + " ");
                }

            }
                Console.WriteLine();

                        
            Console.ReadKey();

        }
    }
}
