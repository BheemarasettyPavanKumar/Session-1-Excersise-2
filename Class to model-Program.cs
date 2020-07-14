using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_to_model
{
    class Program
    {
        static void Main(string[] args)
        {
            Product P1;
            P1 = new Product();
            P1.Productname = "Pavan";
            P1.colour = "Blue";
            P1.Productnumber = 123654;
            P1.price = 24999;

            P1.Display();
        }
    }
}
