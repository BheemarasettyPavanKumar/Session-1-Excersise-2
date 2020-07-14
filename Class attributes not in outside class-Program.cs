using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_attributes_not_in_outside_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Product P2;
            P2 = new Product();
            P2.Attributes("Pavan", "Skyblue", 987678, 24999);
            P2.Display();
        }
    }
}
