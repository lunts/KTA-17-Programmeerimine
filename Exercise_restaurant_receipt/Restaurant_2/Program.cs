using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//objektorienteeritud
namespace Restaurant_2
{
    public class Restaurant
    {
        private string _name;
        private string _address;

        public Restaurant(string name, string address)
        {
            this._name = name;
            this._address = address;
            //this. - mõeldakse classi tasemel addressi, mitte stringi address
        }

        public Receipt GetReceipt(Tab tab)
        {
            return new Receipt(_name, _address);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Restaurant restaurant = new Restaurant("Taco Palenque", "1200 Main ST");

            Tab tab = new Tab();

            tab.Add(7.99);
            tab.Add(6,55);
            tab.Add(2,345);

            Receipt receipt = restaurant.GetReceipt(tab);

            Console.Write(receipt);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
