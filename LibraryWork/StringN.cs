using System;

namespace LibraryWork
{
    public class StringN
    {
        public string GetIntLine(string getN)
        {
            try
            {
                if (int.TryParse(getN, out int x) == false)
                {
                    throw new ArgumentNullException(null, "Error: Введено неправильное значение. Введите число!");
                }
                else
                {
                    if (x <= 0)
                    {
                        throw new ArgumentNullException(null, "Error: Введите число больше нуля!");
                    }
                }

                int n = Convert.ToInt32(getN);

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
            catch (ArgumentNullException error)
            {
                return error.Message;
            }
        }

        public string GetIntLattices(string getN)
        {
            try
            {
                if (int.TryParse(getN, out int x) == false)
                {
                    throw new ArgumentNullException(null, "Error: Введено неправильное значение. Введите число!");
                }
                else
                {
                    if (x <= 0)
                    {
                        throw new ArgumentNullException(null, "Error: Введите число больше нуля!");
                    }
                }

                int n = Convert.ToInt32(getN);

                string returnLine = "";
                string[,] array = new string[n, n];

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                                          //array[0, 0]          array[0, n]                   array[n, 0]               array[n, n]                        array[center]
                        array[i, j] = (i == 0 && j == 0) || (i == 0 && j == n - 1) || (i == n - 1 && j == 0) || (i == n - 1 && j == n - 1) || (i == (n - 1) / 2 && j == (n - 1) / 2) ? " " : "#";
                        returnLine += array[i, j];
                    }
                    returnLine += "\n";
                }

                return returnLine;
            }
            catch (ArgumentNullException error)
            {
                return error.Message;
            }
        }

    }
}
