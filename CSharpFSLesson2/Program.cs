using System;
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
            Console.Write("Say your name:");
            string username = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(username + " what movie ganre you prefer?");
            Console.WriteLine("- Comedy");
            Console.WriteLine("- Drama");
            Console.WriteLine("- Triller");
            Console.WriteLine("- Western");
            Console.WriteLine();

            Console.Write("Type: ");
            string ganre = Console.ReadLine();

            Console.ReadLine();
        }
    }
}
