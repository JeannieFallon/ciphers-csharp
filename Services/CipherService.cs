using System;
using System.Collections.Generic;
using System.Text;
using Ciphers.Util;

namespace Ciphers.Services
{
    public class CipherService
    {
        public char GetCipherLetter(char letter, int shiftVal)
        {
            return 'Z';
        }

        public int GetCipherASCII(int alphaMapVal, int ascVal, int shiftVal)
        {
            return ascVal;
        }

        public int GetAlphaIndex(int alphaIdx, int shiftVal)
        {
            return alphaIdx;
        }

        public List<int> GetShiftVals(string keyWord, int keyLen)
        {
            List<int> shiftVals = new List<int>();
            return shiftVals;
        }
    }
}
