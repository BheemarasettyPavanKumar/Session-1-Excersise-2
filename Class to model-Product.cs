using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_to_model
{
    class Product
    {
        internal string Productname, colour;
        internal int Productnumber;
        internal double price;

        internal void Display()
        {
            Console.WriteLine("Name: " + Productname +  "colour: " + colour  + "Number: " + Productnumber
                 + "Rs: " + price);
        }
    }
}
