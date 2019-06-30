using System;
using System.Collections.Generic;
using System.Text;

namespace Ciphers.Models
{
    public class Rot13Text : Text
    {
        private static int key;
        public Rot13Text(string plainTxt) : base(plainTxt)
        { }

        static Rot13Text()
        {
            key = 13;
        }
    }
}
