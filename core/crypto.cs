using System;
using System.IO;
using System.Security.Cryptography;

namespace BUM
{
    internal class crypto
    {
    }
    public partial class frmBUM
    {
        string encrypt(string toCrypt)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(toCrypt);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        string decrypt(string toDecrypt)
        {
            string result = string.Empty;
            byte[] decryted;
            try
            {
                decryted = Convert.FromBase64String(toDecrypt);

            }
            catch (FormatException)
            {
                decryted = System.Text.Encoding.Unicode.GetBytes(toDecrypt); //<<<== bypass for old versions
            }
                result = System.Text.Encoding.Unicode.GetString(decryted);
                return result;
        }
    }
}
