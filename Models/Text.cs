using System;
using System.Collections.Generic;
using System.Text;

namespace Ciphers.Models
{
    public abstract class Text
    {
        public string PlainText { get; set; }
        public string CipherText { get; set; }

        public Text(string plainText)
        {
            PlainText = plainText;
        }
    }
}
