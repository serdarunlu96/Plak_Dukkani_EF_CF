using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Plak_Dukkani.Data
{
    public class Admin
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public virtual ICollection<AdminAlbum> AdminAlbums { get; set; }



        public static bool ValidatePassword(string password, string passwordHash)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                string computedHash = Convert.ToBase64String(hashBytes);
                return passwordHash.Equals(computedHash);
            }
        }

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes);
            }
        }

    }

}