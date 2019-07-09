﻿using System;
using System.Collections.Generic;
using System.Text;
using Ciphers.Util;

namespace Ciphers.Models
{
    public class Rot13Text : Text
    {
        public int Key { get; set; }
        public Rot13Text(string plainTxt) : base(plainTxt)
        {
            Key = CipherConstants.ROT13_SHIFT_VAL;
        }

        //static Rot13Text()
        //{
        //    Key = CipherConstants.ROT13_SHIFT_VAL;
        //}
    }
}
