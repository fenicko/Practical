using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWork
{
    public class StringN
    {
        private string errorString = "Error: Введено неправильное значение!";
        private string errorNumber = "Error: Введите число больше 0!";

        public string GetIntLine(string getN)
        {
            try
            {
                int n = Convert.ToInt32(getN);

                if (n <= 0)
                {
                    return errorNumber;
                }

                string returnLine = $"N={n}: ";
                for (int i = 1; i <= n; i++)
                {
                    if (i < n)
                    {
                        returnLine += $"{i}, ";
                    }
                    if (i == n)
                    {
                        returnLine += $"{i}.";
                    }
                }
                return returnLine;

            }
            catch
            {
                return errorString;
            }

        }

        public string GetIntLattices(string getN)
        {
            try
            {
                int n = Convert.ToInt32(getN);

                if (n <= 0)
                {
                    return errorNumber;
                }

                string returnLine = "";
                string[,] array = new string[n, n];

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        //array[0, 0]          array[0, n]                array[n, 0]               array[n, n]                    array[center]
                        array[i, j] = ((i == 0 && j == 0) || (i == 0 && j == n - 1) || (i == n - 1 && j == 0) || (i == n - 1 && j == n - 1) || (i == (n - 1) / 2 && j == (n - 1) / 2)) ? " " : "#";
                        returnLine += array[i, j];
                    }
                    returnLine += "\n";
                }

                return returnLine;
            }
            catch
            {
                return errorString;
            }
        }

    }
}
