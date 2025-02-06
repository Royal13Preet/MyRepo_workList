using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main()
            {
                using (var rng = new RNGCryptoServiceProvider())
                {
                    byte[] secretKey = new byte[32]; // 256 bits
                    rng.GetBytes(secretKey);
                    string secretKeyBase64 = Convert.ToBase64String(secretKey);
                    Console.WriteLine("Generated Secret Key: " + secretKeyBase64);
                }
            }
        }

    }
