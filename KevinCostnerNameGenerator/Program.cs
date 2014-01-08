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
            
            return Console.ReadLine();
        }


        private static string generateName(string original)
        {
            return original + " Costner";
        }

        static void help()
        {
            Console.WriteLine("#########################");
            Console.WriteLine("HELP:");
            Console.WriteLine("Write your name and press ENTER.");
            Console.WriteLine("Type 'help' to see this help and 'quit' to quit.");
            Console.WriteLine("#########################");
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Kevin Costner Name Generator v0.1");
            Console.WriteLine("© 2014 CO-SKY Project, University of Jyväskylä");

            Console.WriteLine("Generated name: Kevin Costner");
            Console.WriteLine("");
            Console.WriteLine("Write 'help' for help.");

            while (true)
            {
                Console.Write("Enter your name: >");

                var input = Console.ReadLine();

                if ("help".Equals(input))
                {
                    help();
                }
                else if ("quit".Equals(input))
                {
                    return;
                }
                else
                {
                    var newname = generateName(input);
                    Console.WriteLine("Generated name: " + newname);
                }
            }
        }
    }
}
