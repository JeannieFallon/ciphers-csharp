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
            for (int i = 0; i < vText.PlainText.Length; i++)
            {
                for (int j = 0; j < vText.KeyWord.Length; j++)
                {   
                    if (i >= vText.PlainText.Length)
                    {
                        break;
                    }
                    else
                    {
                        // TODO get shift vals from keyword in service
                        vText.StrBuild.Append(CipherService.GetCipherLetter(
                                                                vText.PlainText[i], 1));
                    }

                    i++;
                }
            }

            vText.CipherText = vText.StrBuild.ToString();
            return vText;
        }
    }
}
