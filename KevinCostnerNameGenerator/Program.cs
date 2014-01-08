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

        static void Main(string[] args)
        {

            Console.WriteLine("Kevin Costner Name Generator v0.1");
            Console.WriteLine("© 2014 CO-SKY Project, University of Jyväskylä");

            var name = getName();

            Console.WriteLine("Generated name: Kevin Costner");
        }
    }
}
