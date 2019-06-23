using System;
using System.Security.Cryptography;
using System.Text;

namespace C3.Reporting.CMT.Core.Cryptography
{
    public class CryptoUtils
    {
        /// <summary>
        /// Generates the key.
        /// </summary>
        /// <param name="keySize">Size of the key.</param>
        /// <returns></returns>
        public static string GenerateKey(int keySize)
        {
            var aesEncryption = new RijndaelManaged {KeySize = keySize, BlockSize = 128, Mode = CipherMode.CBC, Padding = PaddingMode.PKCS7};

            aesEncryption.GenerateIV();
            string ivStr = Convert.ToBase64String(aesEncryption.IV);

            aesEncryption.GenerateKey();
            string keyStr = Convert.ToBase64String(aesEncryption.Key);

            string completeKey = ivStr + "," + keyStr;
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(completeKey));
        }

        /// <summary>
        /// Encrypts the specified plain STR.
        /// </summary>
        /// <param name="plainStr">The plain STR.</param>
        /// <param name="completeEncodedKey">The complete encoded key.</param>
        /// <param name="keySize">Size of the key.</param>
        /// <returns></returns>
        public static string Encrypt(string plainStr, string completeEncodedKey, int keySize)
        {
            var aesEncryption = new RijndaelManaged
                                    {
                                        KeySize = keySize,
                                        BlockSize = 128,
                                        Mode = CipherMode.CBC,
                                        Padding = PaddingMode.PKCS7,
                                        IV = Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(completeEncodedKey)).Split(',')[0]),
                                        Key = Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(completeEncodedKey)).Split(',')[1])
                                    };

            byte[] plainText = Encoding.UTF8.GetBytes(plainStr);

            ICryptoTransform crypto = aesEncryption.CreateEncryptor();

            // The result of the encryption and decryption
            byte[] cipherText = crypto.TransformFinalBlock(plainText, 0, plainText.Length);

            return Convert.ToBase64String(cipherText);
        }

        /// <summary>
        /// Decrypts the specified encrypted text.
        /// </summary>
        /// <param name="encryptedText">The encrypted text.</param>
        /// <param name="completeEncodedKey">The complete encoded key.</param>
        /// <param name="keySize">Size of the key.</param>
        /// <returns></returns>
        public static string Decrypt(string encryptedText, string completeEncodedKey, int keySize)
        {
            var aesEncryption = new RijndaelManaged
                                    {
                                        KeySize = keySize,
                                        BlockSize = 128,
                                        Mode = CipherMode.CBC,
                                        Padding = PaddingMode.PKCS7,
                                        IV = Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(completeEncodedKey)).Split(',')[0]),
                                        Key = Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(completeEncodedKey)).Split(',')[1])
                                    };

            ICryptoTransform decrypto = aesEncryption.CreateDecryptor();
            byte[] encryptedBytes = Convert.FromBase64CharArray(encryptedText.ToCharArray(), 0, encryptedText.Length);

            return Encoding.UTF8.GetString(decrypto.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length));
        }
    }
}