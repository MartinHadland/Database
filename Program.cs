using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserEntry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your Surname?");
            string surname = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Age: " + age);

            Console.Read();
        }
    }
}
