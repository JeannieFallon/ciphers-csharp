﻿using System;
using System.Collections.Generic;
using System.Text;
using Ciphers.Util;

namespace Ciphers.Services
{
    public class CipherService
    {
        public char GetCipherLetter(char letter, int shiftVal)
        {
            int ascVal = letter;

            // only shift upper- and lowercase letters
            if (ascVal >= CipherConstants.ENG_UPPER_FLOOR 
                && ascVal <= CipherConstants.ENG_UPPER_CEILING)
            {
                ascVal = GetCipherASCII(CipherConstants.ENG_UPPER_FLOOR,
                                            ascVal, shiftVal);
            }
            else if (ascVal >= CipherConstants.ENG_LOWER_FLOOR
                && ascVal <= CipherConstants.ENG_LOWER_CEILING)
            {
                ascVal = GetCipherASCII(CipherConstants.ENG_LOWER_FLOOR,
                                            ascVal, shiftVal);
            }

            return (char)ascVal;
        }

        public int GetCipherASCII(int alphaMapVal, int ascVal, int shiftVal)
        {
            // map ASCII value onto index of letter in alphabet
            int alphaIdx = ascVal - alphaMapVal;
            // wrap shift rotation around alphabet indices
            alphaIdx = GetAlphaIndex(alphaIdx, shiftVal);
            // map alphabet index back onto original ASCII range
            return alphaIdx + alphaMapVal;
        }

        public int GetAlphaIndex(int alphaIdx, int shiftVal)
        {
            return (alphaIdx + shiftVal) % CipherConstants.ENG_ALPHA_LEN;
        }

        public List<int> GetShiftVals(string keyWord)
        {
            List<int> shiftVals = new List<int>();

            keyWord = keyWord.ToLower();

            foreach (char c in keyWord)
            {
                shiftVals.Add(c - CipherConstants.ENG_LOWER_FLOOR + 1);
            }

            return shiftVals;
        }
    }
}
