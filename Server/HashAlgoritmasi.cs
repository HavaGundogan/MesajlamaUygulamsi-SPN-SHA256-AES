using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Server
{
    class HashAlgoritmasi
    {
        public string Sha256Enc(string Data)
        {
            using(var sha256provider = new SHA256CryptoServiceProvider()) // SHA256 sha256Hash = SHA256.Create()
            {
                byte[] bytes = sha256provider.ComputeHash(Encoding.UTF8.GetBytes(Data));
                StringBuilder builder = new StringBuilder();
                for(int i=0; i<bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}
/*SHA256 algoritmasının uygulanabilmesi için SHA256CryptoServiceProvider sınıfından yeni bir nesne üretmek ve bu sınıfın ComputeHash metodunu kullanmak gerekiyor.*/
