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
            foreach (char plnChar in vText.PlainText)
            {
                int shiftVal = 1;
                vText.StrBuild.Append(CipherService.GetCipherLetter(plnChar, shiftVal));
            }

            vText.CipherText = vText.StrBuild.ToString();
            return vText;
        }
    }
}
