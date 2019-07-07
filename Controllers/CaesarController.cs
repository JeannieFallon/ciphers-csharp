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
            foreach (char plnChar in cText.PlainText)
            {
                cText.StrBuild.Append(CipherService.GetCipherLetter(plnChar));
            }

            cText.CipherText = cText.StrBuild.ToString();
            return cText;
        }
    }
}
