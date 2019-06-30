using Ciphers.Models;
using System;

namespace Ciphers
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainTxt, keyWord;
            int key;

            Console.WriteLine("Enter plaintext:");
            plainTxt = Console.ReadLine();

            Console.WriteLine("Enter a key value for the Caesar cipher:");
            key = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a key word for the Vigenere cipher:");
            keyWord = Console.ReadLine();

            Rot13Text rot13Text = new Rot13Text(plainTxt);
            CaesarText caesarText = new CaesarText(plainTxt, key);
            VigenereText vigenere = new VigenereText(plainTxt, keyWord);

            Console.WriteLine(string.Format("\nROT13:\n" + "test"));

            Console.WriteLine(string.Format("\nCaesar:\n" + "test"));

            Console.WriteLine(string.Format("\nVigenere:\n" + "test"));
        }
    }
}
