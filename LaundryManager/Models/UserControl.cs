using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManager.Models
{
    class UserControl
    {
        public static string SHA256(string password)
        {
            try
            {
                SHA256Managed crypt = new SHA256Managed();
                string hash = string.Empty;
                byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));

                foreach (byte bit in crypto)
                {
                    hash += bit.ToString("x2");
                }
                return hash;
            }
            catch
            {
                return null;
            }
        }
    }
}
