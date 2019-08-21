using System;
using System.Configuration;
using System.Security.Cryptography;

namespace libraries
{
    public class Encryptor
    {
        private static int saltLengthLimit = int.Parse(ConfigurationManager.AppSettings["PasswordSaltLenght"]);
        private readonly int _numberOfIterations = 10000;



        public string GenerateEncryptedPassword(string userPassword)
        {
            string encryptedPassword = "";

            encryptedPassword = Convert.ToBase64String(GeneratePasswordEncryptedBytes(userPassword));
            return encryptedPassword;
        }

        private byte[] GeneratePasswordEncryptedBytes(string userPassword)
        {
            byte[] salt = GetSalt();
            Rfc2898DeriveBytes encrypter = new Rfc2898DeriveBytes(userPassword, salt, _numberOfIterations);
            byte[] hash = encrypter.GetBytes(20);
            byte[] hashBytes = new byte[52];
            Array.Copy(salt, 0, hashBytes, 0, 32);
            Array.Copy(hash, 0, hashBytes, 32, 20);
            return hashBytes;
        }

        private byte[] GetSalt()
        {
            return GetSalt(saltLengthLimit);
        }

        private byte[] GetSalt(int maximumSaltLength)
        {
            byte[] salt = new byte[maximumSaltLength];
            using (RNGCryptoServiceProvider random = new RNGCryptoServiceProvider())
            {
                random.GetNonZeroBytes(salt);
            }

            return salt;
        }

        public bool CompareUserPasswords(string passwordToCompare, string currentPassword)
        {
            bool result = true;
            byte[] currentPasswordBytes = Convert.FromBase64String(currentPassword);
            byte[] passwordToCompareBytes = GeneratePasswordEncryptedBytes(passwordToCompare);
            result = ComparePasswordBytes(passwordToCompareBytes, currentPasswordBytes);
            return result;
        }

        private bool ComparePasswordBytes(byte[] passwordToCompare, byte[] currentPassword)
        {
            bool result = true;
            for (int i = 0; i < 20; i++)
            {
                if (currentPassword[i + 32] != passwordToCompare[i + 32])
                    result = false;
            }
            return result;
        }
    }
}