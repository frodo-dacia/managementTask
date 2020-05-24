//Autor: Stefan Andrei
//Functionalitate: In aceasta clasa am implementat o functie care cripteaza parola user-ului folosint un hash pentru a o salva in baza de date. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace managementTask
{
    public class Crypto
    {
        public static string HashString(string str)
        {
            HashAlgorithm sha = new SHA1CryptoServiceProvider();
            byte[] buf = new byte[str.Length];
            for (int i = 0; i < str.Length; i++)
                buf[i] = (byte)str[i];
            byte[] result = sha.ComputeHash(buf);
            return Convert.ToBase64String(result);
        }

    }
}
