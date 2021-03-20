using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Column_cipher
    {
        public string Encrypt(string src, string key)
        {
            char[] dest = src.ToCharArray();
            char[] key_arr = key.ToCharArray();
            int row = (int)Math.Ceiling((float)(src.Length) / key.Length);
            int column = key.Length;
            char[,] buf = new char[row, column];

            int k = 0;
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                {
                    if (k < src.Length)
                    {
                        buf[i, j] = src[k];
                        k++;
                    }
                    else
                        buf[i, j] = '0';
                }

            int count = 0;
            k = 0;
            do
            {
                int ind_min = 0;
                for (int i = 1; i < column; i++)
                {
                    if ((key_arr[i] < key_arr[ind_min]))
                        ind_min = i;
                }
                for (int i = 0; i < row; i++)
                {
                    if (buf[i, ind_min] == '0')
                        break;
                    else
                    {
                        dest[k] = buf[i, ind_min];
                        k++;
                    }
                }
                key_arr[ind_min] = '{';
                count++;
            } while (count < column);

            string result = "";
            for (int i = 0; i < dest.Length; i++)
                result = result + dest[i];

            return result;
        }

        public string Decrypt(string src, string key)
        {
            char[] dest = src.ToCharArray();
            char[] key_arr = key.ToCharArray();
            int row = (int)Math.Ceiling((float)(src.Length) / key.Length);
            int column = key.Length;
            char[,] buf = new char[row, column];
            int nul_elem = key.Length - src.Length % key.Length;

            for (int i = 0; i < nul_elem; i++)
                buf[row - 1, column - i - 1] = '0';

            int count = 0;
            int k = 0;
            do
            {
                int ind_min = 0;
                for (int j = 1; j < column; j++)
                {
                    if ((key_arr[j] < key_arr[ind_min]))
                        ind_min = j;
                }
                int i = 0;
                while ((i < row) && (buf[i, ind_min] != '0'))
                {
                    buf[i, ind_min] = src[k];
                    i++;
                    k++;
                }
                key_arr[ind_min] = '{';
                count++;
            } while (count < column);

            int ind = 0;
            for (int j = 0; j < row; j++)
                for (int c = 0; c < column; c++)
                {
                    if (buf[j, c] == '0')
                        break;
                    else
                    {
                        dest[ind] = buf[j, c];
                        ind++;
                    }
                }

            string result = "";
            for (int i = 0; i < dest.Length; i++)
                result = result + dest[i];

            return result;
        }
    }
}
