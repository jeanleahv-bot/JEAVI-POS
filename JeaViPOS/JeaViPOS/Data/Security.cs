using System;
using System.Security.Cryptography;
using System.Text;

namespace JeaViPOS
{
    public static class Security
    {
        // SHA-256 of (salt + password), uppercase hex. Matches the SQL seed data.
        public static string Hash(string salt, string password)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(salt + password));
                var sb = new StringBuilder();
                foreach (var b in bytes) sb.Append(b.ToString("X2"));
                return sb.ToString();
            }
        }

        public static string NewSalt()
        {
            var bytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create()) rng.GetBytes(bytes);
            var sb = new StringBuilder();
            foreach (var b in bytes) sb.Append(b.ToString("X2"));
            return sb.ToString(); // 32 characters
        }
    }
}