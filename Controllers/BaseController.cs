﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Ciphers.Models;
using Ciphers.Services;

namespace Ciphers.Controllers
{
    public class BaseController
    {
        public static CipherService CipherService;
        public static Rot13Controller Rot13Controller;
        public static CaesarController CaesarController;
        public static VigenereController VigenereController;

        public static void Index()
        {
            Initialize();

            string plainTxt, keyWord;
            int key;
            bool isValid;

            Console.WriteLine("Enter plaintext:");
            plainTxt = Console.ReadLine();

            isValid = false;
            key = 0;
            while (!isValid)
            {
                Console.WriteLine("Enter a positive integer as the key for the Caesar cipher:");
                var input = Console.ReadLine();
                isValid = int.TryParse(input, out key) && key > 0;
            }

            isValid = false;
            keyWord = "";
            while (!isValid)
            {
                Console.WriteLine("Enter a key word for the Vigenere cipher:");
                keyWord = Console.ReadLine();
                isValid = Regex.IsMatch(keyWord, @"^[a-zA-Z]+$"); ;
            }

            Rot13Text rot13Text = new Rot13Text(plainTxt);
            CaesarText caesarText = new CaesarText(plainTxt, key);
            VigenereText vigenereText = new VigenereText(plainTxt, keyWord);

            rot13Text = Rot13Controller.GetRot13Text(rot13Text);
            caesarText = CaesarController.GetCaesarText(caesarText);
            vigenereText = VigenereController.GetVigenereText(vigenereText);

            Console.WriteLine(string.Format("\nROT13:\n" + rot13Text.CipherText));
            Console.WriteLine(string.Format("\nCaesar:\n" + caesarText.CipherText));
            Console.WriteLine(string.Format("\nVigenere:\n" + vigenereText.CipherText));
        }

        public static void Initialize()
        {
            CipherService = new CipherService();
            Rot13Controller = new Rot13Controller();
            CaesarController = new CaesarController();
            VigenereController = new VigenereController();
        }
    }
}
