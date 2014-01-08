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

        /// <summary>
        /// Super cool help method.
        /// </summary>
        static void help()
        {
            Console.WriteLine("#########################");
            Console.WriteLine("HELP:");
            Console.WriteLine("Write your name and press ENTER.");
            Console.WriteLine("#########################");
        }

        /// <summary>
        /// Application that generates cool Kevin Costner names.
        /// </summary>
        /// <param name="args"></param>
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
            }
            Console.Read();
        }
    }
}
