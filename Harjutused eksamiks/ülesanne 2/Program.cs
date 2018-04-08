using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ülesanne_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nimed suurte algustähtedega.");
             Console.WriteLine();
             Console.WriteLine("Sisesta lauseid, kus on kasutatud järgmisi nimesi:");

             // testimiseks kasuta: 
             // kaur mattias, Kristel: HELERI TrEvOr kristJAN KELLi; . jou kevin. jou maarika; jou .laura 

             string[] nimed = new string[10] { "kaur", "mattias", "kristel", "heleri", "trevor",
                                               "kristjan", "kelli", "kevin", "maarika", "laura" };

             {
                                 int indeks = 0;
                                 while (indeks < nimed.Length)
                {
                     string nimi = nimed[indeks];
                     string nimi_suure_algustähega = char.ToUpper(nimi[0]) + nimi.Substring(1).ToLower();
                     Console.Write(nimi_suure_algustähega);
                     indeks += 1;
                     if (indeks < nimed.Length)
                    {
                         Console.Write(", ");
                                             }
                                     }
                                 Console.WriteLine(".");
                             }
             Console.WriteLine();
             Console.Write(":");
             string input = Console.ReadLine();
             if (String.IsNullOrWhiteSpace(input))
            {
                 Console.WriteLine("Viga sisestamisel");
                             }
            
             // siia hakkame sõnu kopeerima 
             StringBuilder output = new StringBuilder("", input.Length);
             string[] sõnad = input.Split(' ');
            
             for (int sõna_indeks = 0; sõna_indeks < sõnad.Length; sõna_indeks += 1)
            {
                 string sõna = sõnad[sõna_indeks];
                 if (sõna.Length > 0)
                {
                     StringBuilder sõna_võibolla_nimi = new StringBuilder(sõna);
                     StringBuilder sõnalõpumärgid = new StringBuilder();
                     int tähe_indeks = sõna.Length - 1;
                     char viimane_täht = sõna[tähe_indeks];

                     // kui sõna lõpus on punktid või komad, jätame need meelde 
                     // ning ei otsi nimede seast 

                     while (char.IsPunctuation(viimane_täht) && tähe_indeks >= 0)
                    {
                         sõnalõpumärgid.Append(viimane_täht);
                         sõna_võibolla_nimi.Remove(tähe_indeks, 1);
                         tähe_indeks -= 1;
                         if (tähe_indeks >= 0)
                        {
                             viimane_täht = sõna[tähe_indeks];
                                                     }
                                             }
                    


                     if (nimed.Contains(sõna_võibolla_nimi.ToString().ToLower()))
                    {
                        


                         sõna_võibolla_nimi[0] = char.ToUpper(sõna_võibolla_nimi[0]);
                        


                         for (int i = 1; i < sõna_võibolla_nimi.Length; i += 1)
                        {
                            


                             sõna_võibolla_nimi[i] = char.ToLower(sõna_võibolla_nimi[i]);
                                                     }
                                             }
                    


                     output.Append(sõna_võibolla_nimi);
                    


                     output.Append(sõnalõpumärgid);
                    


                     output.Append(' ');
                                     }
                             }
            


             Console.WriteLine();
                         Console.WriteLine(output.ToString());
                         Console.WriteLine();
                         Console.WriteLine("Press any key");
                         Console.ReadLine();
        } 
     } 
 }
