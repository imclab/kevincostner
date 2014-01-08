using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinCostnerNameGenerator
{
    class Program
    {

        static string getName()
        {
            Console.Write("Enter your name: >");
            return Console.ReadLine();
        }

        static string generateName(string original)
        {
            return original + " Costner";
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Kevin Costner Name Generator v0.1");
            Console.WriteLine("© 2014 CO-SKY Project, University of Jyväskylä");

            var name = getName();
            var newname = generateName(name);

            Console.WriteLine("Generated name: " + newname);

            Console.ReadKey();
        }
    }
}
