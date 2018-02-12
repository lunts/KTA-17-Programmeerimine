using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMixer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("See programm jätab lauses iga sõna esimese ja viimase tähe paigale, kuid muudab sõna sees olevate tähtede järjekorda");

            Console.WriteLine("Kirjuta lause ilma kirjavahemärkideta: ");

            string input = Console.ReadLine();
            
            List<string> sentenceList = input.Split(new char[] { ' ' }).ToList();
            string[] sentence = sentenceList.ToArray();
            Console.WriteLine(sentence.Length);

            int i=0;
            do
            {
                
                string unsuffled = sentence[i];
                char[] charArr = unsuffled.ToCharArray();


                var rnd = new Random();
                int middleStart = 1;
                int middleLength = unsuffled.Length - 2;


                string middle = unsuffled.Substring(middleStart, middleLength);
                string shuffled = new string(middle.OrderBy(r => rnd.Next()).ToArray());
                Console.Write(charArr[0] + shuffled + charArr[charArr.Length - 1] + " ");
                //https://stackoverflow.com/questions/3226877/character-shuffler

                i++;

            }
            while (i < sentence.Length);

            
            Console.ReadKey();
        }
    }
}
