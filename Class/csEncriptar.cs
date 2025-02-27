using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TorneosFut
{
    class csEncriptar
    {
        public string Encriptar(string clave, string frase)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(clave);
            MD5 md5 = MD5.Create();
            TripleDES tripldes = TripleDES.Create();
            tripldes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(frase));
            tripldes.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripldes.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            return Convert.ToBase64String(result);
        }

        public string Desencriptar(string claveEn, string frase)
        {
            byte[] data = Convert.FromBase64String(claveEn);
            MD5 md5 = MD5.Create();
            TripleDES tripldes = TripleDES.Create();
            tripldes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(frase));
            tripldes.Mode = CipherMode.ECB;
            ICryptoTransform transform = tripldes.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            return UTF8Encoding.UTF8.GetString(result);
        }
    }
}