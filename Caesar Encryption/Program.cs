using System;
using System.Text;

namespace Caesar_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string text = "абвя";

            string crypt = Caesar.Encryption(text);
            string decrypt = Caesar.Decryption(crypt);

            Console.WriteLine("Текст: {0}, Криптограмма: {1}, Дешифрофанный текст: {2}", text, crypt, decrypt);
        }
    }
}
