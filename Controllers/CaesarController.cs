using System;
using System.Collections.Generic;
using System.Text;
using Ciphers.Models;

namespace Ciphers.Controllers
{
    public class CaesarController : BaseController
    {
        public CaesarText GetCaesarText(CaesarText cText)
        {
            char testChar = 'A';
            cText.CipherText = "";
            cText.CipherText += CipherService.GetCipherLetter(testChar);
            return cText;
        }
    }
}
