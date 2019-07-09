using System;
using System.Collections.Generic;
using System.Text;
using Ciphers.Util;

namespace Ciphers.Models
{
    public class Rot13Text : Text
    {
        private static int key;
        public Rot13Text(string plainTxt) : base(plainTxt)
        { }

        static Rot13Text()
        {
            key = CipherConstants.ROT13_SHIFT_VAL;
        }
    }
}
