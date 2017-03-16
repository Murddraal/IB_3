using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace IB_3
{
    static class Hash
    {
        static public byte[] encrypt(string alg_name, string msg)
        {
            var b_msg = Encoding.ASCII.GetBytes(msg);

            var hash_alg = HashAlgorithm.Create(alg_name);
            var hash = hash_alg.ComputeHash(b_msg);
            return hash;
        }
    }
}
