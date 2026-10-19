using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsHash
    {
        public static string ComputeHash(string Password , string Salt)
        {
            return ComputeHash(Password + Salt);
        }
        public static string ComputeHash(string SaltedPassowrd)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] HashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(SaltedPassowrd));
                return BitConverter.ToString(HashBytes).Replace("-", "").ToLower();
            }
        }
        public static bool IsPasswordCurrect(string HashedPassowrd , string Password , string Salt)
        {
            return HashedPassowrd == ComputeHash(Password , Salt);
        }


      


        public static string GenerateSalt(int size = 16)
        {
            byte[] salt = new byte[size];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return BitConverter.ToString(salt).Replace("-" , "").ToLower();
        }

        


    }

    public class clsSysmetricEncryption
    {
        private static string Key = "1234567890123456";
        static string Encrypt(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES encryption
                aesAlg.Key = Encoding.UTF8.GetBytes(Key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create an encryptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);


                // Encrypt the data
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }


                    // Return the encrypted data as a Base64-encoded string
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }


        static string Decrypt(string cipherText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES decryption
                aesAlg.Key = Encoding.UTF8.GetBytes(Key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create a decryptor
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);


                // Decrypt the data
                using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                {
                    // Read the decrypted data from the StreamReader
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}
