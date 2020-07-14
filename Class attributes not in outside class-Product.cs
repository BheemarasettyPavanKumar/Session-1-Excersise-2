using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_attributes_not_in_outside_class
{
    class Product
    {
        internal string Productname, colour;
        internal int Productnumber;
        internal double price;

        internal void Display()
        {
            Console.WriteLine("Name:" + Productname +" "+"colour:"+ colour +" "+ "Number:" + Productnumber +" "
                 + "Rs:" + price);
        }

        internal void Attributes(string Productname,string colour,int Productnumber,double price)
        {
            this.Productname = Productname;
            this.colour = colour;
            this.Productnumber = Productnumber;
            this.price = price;

        }
    }
}
