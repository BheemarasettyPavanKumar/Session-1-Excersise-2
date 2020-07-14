using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Instances
{
    class Product
    {
        internal string Productname, colour;
        internal int Productnumber;
        internal double price;

        internal void Display()
        {
            Console.WriteLine("Name:" + Productname + " " + "colour:" + colour + " " + "Number:" + Productnumber + " "
                 + "Rs:" + price);
        }

        internal Product()
        {
            Console.WriteLine("Empty Objects Initialization");
        }

        internal Product(string Productname, string colour, int Productnumber, double price)
        {
            Console.WriteLine("Objects Initialized");
            this.Productname = Productname;
            this.colour = colour;
            this.Productnumber = Productnumber;
            this.price = price;

        }
    }
}
