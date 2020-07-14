using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instantiable_with_or_without_values
{
    class Program
    {
        static void Main(string[] args)
        {
            Product P3;
            P3 = new Product();
            P3.Productname = "Pavankumar";
            P3.colour = "White";
            P3.Productnumber = 456876;
            P3.price = 50999;


            Product P4 = new Product("PavanLucky", "lightgreen", 987678, 30999);

            P3.Display();
            P4.Display();
        }
    }
}
