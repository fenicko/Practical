using System;

namespace LibraryWork
{
    /// <summary>
    /// Класс StringN формирующий определенные последовательности символов
    /// </summary>
    public class StringN
    {
        /// <summary>
        /// Нулевой элемент
        /// </summary>
        private const int minValue = 0;

        /// <summary>
        /// Делитель
        /// </summary>
        private const int Divider = 2;

        /// <summary>
        /// Метод формирующий последовательность чисел
        /// </summary>
        /// <param name="getN">Переменная задающая количество символов</param>
        /// <returns>Последовательность чисел</returns>
        public static string GetSequence(int getN)
        {
            try
            {
                if (getN == minValue)
                {
                    throw new ArgumentNullException(null, "Error: Введите целое число больше 0!");
                }

                string returnLine = $"N={getN}: ";

                for (int i = 1; i <= getN; i++)
                {
                    returnLine += (i < getN) ? $"{i}, " : $"{i}.";
                }

                return returnLine;
            }
            catch (ArgumentNullException error)
            {
                return error.Message;
            }
        }

        /// <summary>
        /// Метод рисующий квадрат
        /// </summary>
        /// <param name="getSize">Переменная задающая рамер сторон квадрата</param>
        /// <returns>Квадрат с вырезанными углами и центром</returns>
        public static string GetSquary(int getSize)
        {
            try
            {
                if (getSize == minValue && getSize % Divider == minValue)
                {
                    throw new ArgumentNullException(null, "Error: Введите целое нечетное чиcло больше 0!");
                }

                /* array
                string returnLine = "";

                string[,] array = new string[getN, getN];

                for (int i = minValue; i < array.GetLength(minValue); i++)
                {
                    for (int j = minValue; j < array.GetLength(1); j++)
                    {
                                                 //array[0, 0]                       array[0, n]                         array[n, 0]                        array[n, n]                             array[center]
                        array[i, j] = (i == minValue && j == minValue) || (i == minValue && j == getN - 1) || (i == getN - 1 && j == minValue) || (i == getN - 1 && j == getN - 1) || (i == (getN - 1) / 2 && j == (getN - 1) / 2) ? " " : "#";
                        returnLine += array[i, j];
                    }
                    returnLine += "\n";
                }
                */

                string outputLine = "";
                int lastIndex = getSize - 1;

                for (var i = 0; i < getSize; i++)
                {
                    for (var j = 0; j < getSize; j++)
                    {
                        outputLine += (i == minValue && j == minValue) || (i == minValue && j == lastIndex) || (i == lastIndex && j == minValue) || 
                                      (i == lastIndex && j == lastIndex) || (i == lastIndex / Divider && j == lastIndex / Divider) ? " " : "#";
                    }

                    outputLine += "\n";
                }

                return outputLine;
            }
            catch (ArgumentNullException error)
            {
                return error.Message;
            }
        }
    }
}
