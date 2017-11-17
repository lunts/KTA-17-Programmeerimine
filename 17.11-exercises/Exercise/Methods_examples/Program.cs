using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_examples
{
    class Program
    {
        static void Main(string[] args) //käivitub alati esimesena 
        {
            string name = "Anneli";
            //parameetrid siin, static voidis PrintGreetings() argumendid.
            //annan kaasa nuutuja name
            PrintGreeting(name);

            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();//jääb ootama kasutaja sisendit, nt üks täht või tühik, readline on mingi tekst ja enter.
        }
        //Meetod on jupp koodi, millel on nimi ja mida saab käivitada, hetkel reas 13 kutsutakse seda meetodit. 
        //Static - Kõik meetodid peavad olema staatilised
        //Void - tähendab, et meetod ei anna midagi tagasi. Ehk return'i ei ole.
        //ootab muutujat name
        static void PrintGreeting(string name) //1. Kui siin on 2 stringi PrintGreeting(string a1, string a2), siis peav üleval olema ka kaks stringi PrintGreeting("Kalle", "Malle") ja vastupidi; võib ka int'e jne olla
        {
            Console.WriteLine("Hallo world!");
            Console.WriteLine($"Hey, {name}!");
        }

        static void DoSomething()
        { }
    }
}
