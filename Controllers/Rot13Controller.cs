using System;
using System.Collections.Generic;
using System.Text;
using Ciphers.Models;

namespace Ciphers.Controllers
{
    public class Rot13Controller : BaseController
    {
        public Rot13Text GetRot13Text(Rot13Text rText)
        {
            char testChar = 'A';
            rText.CipherText = "";
            rText.CipherText += CipherService.GetCipherLetter(testChar);
            return rText;
        }
    }
}
