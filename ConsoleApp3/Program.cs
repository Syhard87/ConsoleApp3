using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.Write("Entrez votre age :");
            age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.Write("Vous etes majeur ");
            }
            else
            {
                Console.Write($"Vous etes majeur dans " + (18 - age) + " ans ");

            }
            Console.ReadLine();
        }
    }
}
