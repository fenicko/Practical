using LibraryWork;
using System;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = ReadNumberFromConsole("Введите число: ");
            var numberLine = StringN.GetSequence(inputNumber);
            Console.WriteLine(numberLine);

            inputNumber = ReadNumberFromConsole("Введите размер стороны: ");
            var numberSideSize = StringN.GetSquary(inputNumber);
            Console.WriteLine(numberSideSize);

            Console.ReadKey();
        }


        /// <summary>
        /// Считывает число из консоли
        /// </summary>
        /// <param name="message">Собщение для пользователя</param>
        /// <returns>Заданное количство последоваительности</returns>
        private static int ReadNumberFromConsole(string message)
        {
            Console.Write(message);
            string inputLine = Console.ReadLine();

            bool isInt = !int.TryParse(inputLine, out int number);
            return number;
        }
    }
}
