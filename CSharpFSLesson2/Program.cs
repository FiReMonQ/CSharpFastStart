﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFSLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose move for evening!");
            Console.Write("Say your name: ");
            string username = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(username + " what movie ganre you prefer?");
            Console.WriteLine("- Comedy");
            Console.WriteLine("- Drama");
            Console.WriteLine("- Western");
            Console.WriteLine();

            Console.Write("Type: ");
            string ganre = Console.ReadLine();
                        
            if (ganre == "Comedy") 
            {
                Console.WriteLine("Movies in Comedy ganre:");
                Console.WriteLine("Home Alone");
                Console.WriteLine("Home Alone 2");
                Console.WriteLine("Faith Irony");
                Console.WriteLine("Gentelmens of Laky");
                Console.WriteLine();
            }

            if (ganre == "Drama")
            {
                Console.WriteLine("Movies in Drama ganre:");
                Console.WriteLine("Shoshenk redemption");
                Console.WriteLine("Forrest Gump");
                Console.WriteLine("Platoon");
                Console.WriteLine("Shindlers List");
                Console.WriteLine();
            }

            if (ganre == "Western")
            {
                Console.WriteLine("Movies in Western ganre:");
                Console.WriteLine("Wild Wild West");
                Console.WriteLine("Luky 7");
                Console.WriteLine("Good. Bad. Dead");
                Console.WriteLine("Gun speak");
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
