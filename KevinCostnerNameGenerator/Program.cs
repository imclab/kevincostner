﻿using System;

namespace KevinCostnerNameGenerator
{
    class Program
    {


        private static string generateName(string original)
        {
            return original + " Costner";
        }


        /// <summary>
        /// Super cool help method.
        /// </summary>
        static void help()
        {
            Console.WriteLine("#########################");
            Console.WriteLine("HELP:");
            Console.WriteLine("Write your name and press ENTER.");
            Console.WriteLine("Type 'help' to see this help and 'quit' to quit.");
            Console.WriteLine("#########################");
        }

        /// <summary>
        /// Application that generates cool Kevin Costner names.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("Kevin Costner Name Generator v1.0.0");
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
