using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS2
{

    class Program
    {
        static void Main(string[] args)
        {
            Inventory item = new Inventory();
            item.setFlavor("Vanilla");

            Console.WriteLine(item.getFlavor());
        }
    }

}
