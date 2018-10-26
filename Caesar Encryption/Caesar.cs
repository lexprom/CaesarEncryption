using System;
using System.Text;

namespace Caesar_Encryption
{
    class Caesar
    {
        static string alph = "абвгдеёжзийклмонпрстуфхцчшщъыьэюя";

        public static string Encryption(string text)
        {
            var res = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
                for (int j = 0; j < alph.Length; j++)
                    if (text[i] == alph[j])
                        res.Append(alph[(j + 3) % alph.Length]);

            return res.ToString();
        }
        public static string Decryption(string crypt)
        {
            var res = new StringBuilder();
            for (int i = 0; i < crypt.Length; i++)
                for (int j = 0; j < alph.Length; j++)
                    if (crypt[i] == alph[j])
                        res.Append(alph[(j - 3 + alph.Length) % alph.Length]);

            return res.ToString();
        }
    }
}
