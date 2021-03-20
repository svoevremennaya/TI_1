using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Turning_grille_cipher
    {
        private static int number_squares = 5;

        public string CheckSource(string src)
        {
            if (src.Length < number_squares * number_squares)
            {
                for (int i = src.Length; i < number_squares * number_squares; i++)
                    src = src + 'k';
            }
            if (src.Length > number_squares * number_squares)
            {
                src = src.Substring(0, number_squares * number_squares);
            }
            return src;
        }

        public bool CheckKey(string key)
        {
            bool[,] mask = new bool[number_squares, number_squares];
            bool[,] grid = new bool[number_squares, number_squares];
            int ind = 0;
            if (key.Length != number_squares * number_squares)
                return false;

            for (int i = 0; i < number_squares; i++)
                for (int j = 0; j < number_squares; j++, ind++)
                {
                    if (key[ind] == '1')
                    {
                        mask[i, j] = true;
                        grid[i, j] = true;
                    }
                    else
                    {
                        mask[i, j] = false;
                        grid[i, j] = false;
                    }
                }
            //The first rotate
            ind = 0;
            if (number_squares % 2 != 0)
                mask[number_squares / 2, number_squares / 2] = false;
            for (int i = 0; i < number_squares; i++)
                for (int j = number_squares - 1; j >= 0; j--, ind++)
                {
                    if (key[ind] == '1')
                    {
                        if (!mask[j, i])
                            mask[j, i] = true;
                        else
                            return false;
                    }
                }
            //The second rotate
            ind = 0;
            if (number_squares % 2 != 0)
                mask[number_squares / 2, number_squares / 2] = false;
            for (int i = number_squares - 1; i >= 0; i--)
                for (int j = number_squares - 1; j >= 0; j--, ind++)
                {
                    if (key[ind] == '1')
                    {
                        if (!mask[i, j])
                            mask[i, j] = true;
                        else
                            return false;
                    }
                }
            //The third rotate
            ind = 0;
            if (number_squares % 2 != 0)
                mask[number_squares / 2, number_squares / 2] = false;
            for (int i = number_squares - 1; i >= 0; i--)
                for (int j = 0; j < number_squares; j++, ind++)
                {
                    if (key[ind] == '1')
                    {
                        if (!mask[j, i])
                            mask[j, i] = true;
                        else
                            return false;
                    }
                }
            return true;
        }

        public string Encrypt(string src, string key)
        {
            bool[,] grid = new bool[number_squares, number_squares];
            int ind = 0;
            //Initializing mask matrix
            for (int i = 0; i < number_squares; i++)
                for (int j = 0; j < number_squares; j++, ind++)
                {
                    if (key[ind] == '1')
                        grid[i, j] = true;
                    else
                        grid[i, j] = false;
                }

            char[,] cipher_matrix = new char[number_squares, number_squares];
            ind = 0;
            //The first round
            for (int i = 0; i < number_squares; i++)
                for (int j = 0; j < number_squares; j++)
                {
                    if (grid[i, j])
                    {
                        cipher_matrix[i, j] = src[ind];
                        ind++;
                    }
                }

            grid[2, 2] = false;

            //The second round
            for (int i = 0; i < number_squares; i++)
                for (int j = number_squares - 1; j >= 0; j--)
                {
                    if (grid[j, i])
                    {
                        cipher_matrix[i, number_squares - 1 - j] = src[ind];
                        ind++;
                    }
                }

            //The third round
            for (int i = number_squares - 1; i >= 0; i--)
                for (int j = number_squares - 1; j >= 0; j--)
                {
                    if (grid[i, j])
                    {
                        cipher_matrix[number_squares - 1 - i, number_squares - 1 - j] = src[ind];
                        ind++;
                    }
                }

            //The fourth round
            for (int i = number_squares - 1; i >= 0; i--)
                for (int j = 0; j < number_squares; j++)
                {
                    if (grid[j, i])
                    {
                        cipher_matrix[number_squares - 1 - i, j] = src[ind];
                        ind++;
                    }
                }

            string result = "";
            for (int i = 0; i < number_squares; i++)
                for (int j = 0; j < number_squares; j++)
                    result = result + cipher_matrix[i, j];

            return result;
        }

        public string Decrypt(string src, string key)
        {
            char[,] cipher_matrix = new char[number_squares, number_squares];
            bool[,] grid = new bool[number_squares, number_squares];
            int ind = 0;
            string res = "";
            //Initializing mask matrix
            for (int i = 0; i < number_squares; i++)
                for (int j = 0; j < number_squares; j++, ind++)
                {
                    if (key[ind] == '1')
                        grid[i, j] = true;
                    else
                        grid[i, j] = false;
                }

            //Filling cipher_matrix with source string
            ind = 0;
            for (int i = 0; i < number_squares; i++)
                for (int j = 0; j < number_squares; j++, ind++)
                    cipher_matrix[i, j] = src[ind];

            //The first round
            for (int i = 0; i < number_squares; i++)
                for (int j = 0; j < number_squares; j++)
                {
                    if (grid[i, j])
                        res = res + cipher_matrix[i, j];
                }

            grid[2, 2] = false;

            //The second round
            for (int i = 0; i < number_squares; i++)
                for (int j = number_squares - 1; j >= 0; j--)
                {
                    if (grid[j, i])
                        res = res + cipher_matrix[i, number_squares - 1 - j];
                }

            //The third round
            for (int i = number_squares - 1; i >= 0; i--)
                for (int j = number_squares - 1; j >= 0; j--)
                {
                    if (grid[i, j])
                        res = res + cipher_matrix[number_squares - 1 - i, number_squares - 1 - j];
                }

            //The fourth round
            for (int i = number_squares - 1; i >= 0; i--)
                for (int j = 0; j < number_squares; j++)
                {
                    if (grid[j, i])
                        res = res + cipher_matrix[number_squares - 1 - i, j];
                }

            return res;
        }
    }
}
