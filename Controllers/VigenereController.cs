using System;
using System.Collections.Generic;
using System.Text;
using Ciphers.Models;

namespace Ciphers.Controllers
{
    public class VigenereController : BaseController
    {
        public VigenereText GetVigenereText(VigenereText vText)
        {
            char testChar = 'A';
            vText.CipherText = "";
            vText.CipherText += CipherService.GetCipherLetter(testChar);
            return vText;
        }
    }
}
