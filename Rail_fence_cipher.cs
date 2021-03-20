using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Rail_fence_cipher
    {
        public string Encrypt(string src, int key)
        {
            string[] dest = new string[key];
            int i, ost, period = 2 * (key - 1), row;
            for (i = 0; i < src.Length; i++)
            {
                ost = i % period;
                row = key - 1 - Math.Abs(key - 1 - ost);
                dest[row] += src[i];
            }

            string result = "";
            for (int j = 0; j < dest.Length; j++)
                result = result + dest[j];

            return result;
        }

        public string Decrypt(string src, int key)
        {
            char[,] cipher_matrix = new char[key, src.Length];
            int ind = 0;
            int row = 0, col = 0;
            bool down_dir = false;

            for (int j = 0; j < src.Length; j++)
            {
                if (row == 0 || row == key - 1)
                    down_dir = !down_dir;

                cipher_matrix[row, col] = '?';
                col++;

                if (down_dir)
                    row++;
                else
                    row--;
            }

            ind = 0;
            for (int i = 0; i < key; i++)
                for (int j = 0; j < src.Length; j++)
                {
                    if (cipher_matrix[i, j] == '?')
                    {
                        cipher_matrix[i, j] = src[ind];
                        ind++;
                    }
                }

            string res = "";
            row = 0;
            col = 0;
            for (int j = 0; j < src.Length; j++)
            {
                if (row == 0 || row == key - 1)
                    down_dir = !down_dir;

                res = res + cipher_matrix[row, col];
                col++;

                if (down_dir)
                    row++;
                else
                    row--;
            }

            return res;
        }
    }
}
