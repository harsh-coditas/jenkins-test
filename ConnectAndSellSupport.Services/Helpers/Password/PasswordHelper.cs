using System;
using System.Security.Cryptography;

namespace ConnectAndSellSupport.Services.Helpers.Password
{
    public class PasswordHelper : IPasswordHelper
    {
        #region Private constants
        private const int ITERATION_INDEX = 0;
        private const int SALT_INDEX = 1;
        private const int PBKDF2_INDEX = 2;
        #endregion

        #region Private methods
        private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
        {
            return
                new Rfc2898DeriveBytes(password, salt)
                {
                    IterationCount = iterations
                }.GetBytes(outputBytes);
        }

        private static bool SlowEquals(byte[] a, byte[] b)
        {
            var diff = (uint)a.Length ^ (uint)b.Length;

            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }

            return diff == 0;
        }
        #endregion

        #region Interface implementations
        public bool ValidatePassword(string password, string currentPasswordHash)
        {
            //Extract the parameters from the hash
            var split = currentPasswordHash.Split(':');
            var iterations = int.Parse(split[ITERATION_INDEX]);
            var salt = Convert.FromBase64String(split[SALT_INDEX]);
            var hash = Convert.FromBase64String(split[PBKDF2_INDEX]);

            var compareHash = PBKDF2(password, salt, iterations, hash.Length);

            return SlowEquals(hash, compareHash);
        }
        #endregion
    }
}
