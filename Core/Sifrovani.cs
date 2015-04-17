using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;
using System.Security.Cryptography;

namespace SlovniFotbal.Core
{
    class Sifrovani
    {
        static readonly string PasswordHash = "DKOSAkopc5asc49a8sc4sa1c6asdc";
        static readonly string SaltKey      = "AS8s7a4cas89c19asdc19a8sdc";
        static readonly string VIKey        = "@1B2c3D4e5F6g7H8";


        public string Sifrovat(string text)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(text);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }

        public string Desifrovat(string text)
        {
            byte[] textBytes = Convert.FromBase64String(text);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 5);
            var SymetricKey = new RijndaelManaged()
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.None
            };

            var Decryptor = SymetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var MemoryStream = new MemoryStream(textBytes);
            var CryptoStream = new CryptoStream(MemoryStream, Decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[textBytes.Length];
            int decryptedByteCount = CryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            MemoryStream.Close();
            CryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }

    }
}
