using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using LibraryWork;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;

            Console.WriteLine("Введите \"exit\" для выхода");

            while (isOpen == true)
            {
                Console.Write("Введите число: ");
                string n = Console.ReadLine();

                StringN sdStringN = new StringN();

                if (n == "exit")
                {
                    isOpen = false;
                }
                else
                {
                    string numberLine = sdStringN.GetIntLine(n);
                    Console.WriteLine(numberLine);

                    Console.WriteLine();

                    string latticesLine = sdStringN.GetIntLattices(n);
                    Console.WriteLine(latticesLine);

                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
