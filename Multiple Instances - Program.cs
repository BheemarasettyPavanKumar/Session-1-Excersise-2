using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Instances
{
    class Program
    {
        static void Main(string[] args)
        {
            Product P5;
            P5 = new Product();
            P5.Productname = "Kowshil";
            P5.colour = "White";
            P5.Productnumber = 456876;
            P5.price = 49999;
            
            P5.Display();


            Product P6 = new Product("KowshilKumar", "lightgreen", 987678, 29999);

            P6.Display();

            Product P7 = new Product("Pavankumar","lightblue",98765,59999);
            
            P7.Display();
        }
    }
}
