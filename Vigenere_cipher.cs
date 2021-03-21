using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Vigenere_cipher
    {
        public string StraightKeyword(int length, string key)
        {
            string straight = key;
            int ind = 0;
            for (int i = 0; i < length; i++)
            {
                if (ind >= key.Length)
                    ind = 0;
                if (straight.Length < length)
                {
                    straight = straight + key[ind];
                    ind++;
                }
                else
                    break;
            }
            return straight;
        }

        public string Encrypt(string src, string key)
        {
            char[] dest = src.ToCharArray();
            int shift;
            for (int i = 0; i < src.Length; i++)
            {
                shift = ((int)key[i] - 97) % 26;
                int symbol = src[i];
                symbol = symbol - 97;
                dest[i] = (char)((symbol + shift) % 26 + 97);
            }

            string result = "";
            for (int i = 0; i < dest.Length; i++)
                result = result + dest[i];

            return result;
        }

        public string Decrypt(string src, string key)
        {
            char[] dest = src.ToCharArray();
            int shift;
            for (int i = 0; i < src.Length; i++)
            {
                shift = ((int)key[i] - 97) % 26;
                int symbol = src[i];
                symbol = symbol - 97;
                dest[i] = (char)((symbol + 26 - shift) % 26 + 97);
            }

            string result = "";
            for (int i = 0; i < dest.Length; i++)
                result = result + dest[i];

            return result;
        }

        public bool Check(string src)
        {
            bool result = true;
            for (int i = 0; i < src.Length; i++)
            {
                if ((src[i] < 'a') || (src[i] > 'z'))
                    result = false;
            }
            return result;
        }
    }
}
