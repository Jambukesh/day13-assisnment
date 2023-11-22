using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone s = new Smartphone("redme",2500);
            Laptop pc = new Laptop("linux",11);
            Console.WriteLine($"Smartphone connect{s.Connect()}");
            Console.WriteLine($"Laptop connect{pc.Connect()}");
            s.Charge(70);
            pc.Charge(40);
            Console.WriteLine($"Smartphone info:{s.Display()}");
            Console.WriteLine($"Laptop info:{pc.Display()}");
        }
    }
}
