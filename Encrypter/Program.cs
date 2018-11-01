using System;

namespace Encrypter
{
    class TextEncriptDecript
    {
        static void Main(string[] args)
        {
            string text = "Hola";

            string newEncription = Encrypter.Encrypt(text);
            Console.WriteLine("Text encripted: {0}", newEncription);

            string newDecription = Decrypter.Decrypt(newEncription);
            Console.WriteLine("Text decripted: {0}", newDecription);

            Console.Read();
        }
    }

    class Encrypter
    {
        public static string Encrypt(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string textEncypted = "";

            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] + 1;
                letter = (char)letterInt;
                textEncypted += letter.ToString();
            }
            return textEncypted;
        }
    }

    class Decrypter
    {
        public static string Decrypt(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string textDecrypt = "";

            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] - 1;
                letter = (char)letterInt;
                textDecrypt += letter.ToString();
            }
            return textDecrypt;
        }
    }
}
