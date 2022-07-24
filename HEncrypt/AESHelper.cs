using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace HEncrypt
{
    /// <summary>
    /// 加密模式 ECB,填充PKCS7,数据块128位,输出base64,utf8编码
    /// </summary>
    public class AESHelper
    {
        /// <summary>
        /// 密钥-密钥的长度必须是32
        /// </summary>
        public static string PublicKey = "";

        /// <summary>
        /// 向量16位
        /// </summary>
        private const string Iv = "j5k27debwasu01i9";
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String Encrypt(string str)
        {
            return Encrypt(str, PublicKey);
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String Decrypt(string str)
        {
            return Decrypt(str, PublicKey);
        }
        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="str">需要加密的字符串</param>
        /// <param name="key">32位密钥</param>
        /// <returns>加密后的字符串</returns>
        public static string Encrypt(string str, string key)
        {
            Byte[] keyArray = System.Text.Encoding.UTF8.GetBytes(key);
            Byte[] toEncryptArray = System.Text.Encoding.UTF8.GetBytes(str);
            var rijndael = new System.Security.Cryptography.RijndaelManaged();
            rijndael.Key = keyArray;
            rijndael.Mode = System.Security.Cryptography.CipherMode.ECB;
            rijndael.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
            rijndael.IV = System.Text.Encoding.UTF8.GetBytes(Iv);
            System.Security.Cryptography.ICryptoTransform cTransform = rijndael.CreateEncryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="str">需要解密的字符串</param>
        /// <param name="key">32位密钥</param>
        /// <returns>解密后的字符串</returns>
        public static string Decrypt(string str, string key)
        {
            Byte[] keyArray = System.Text.Encoding.UTF8.GetBytes(key);
            Byte[] toEncryptArray = Convert.FromBase64String(str);
            var rijndael = new System.Security.Cryptography.RijndaelManaged();
            rijndael.Key = keyArray;
            rijndael.Mode = System.Security.Cryptography.CipherMode.ECB;
            rijndael.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
            rijndael.IV = System.Text.Encoding.UTF8.GetBytes(Iv);
            System.Security.Cryptography.ICryptoTransform cTransform = rijndael.CreateDecryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return System.Text.Encoding.UTF8.GetString(resultArray);
        }
        #region 字节加密
        /// <summary>
        /// 字节加密
        /// </summary>
        /// <param name="key"></param>
        /// <param name="toEncryptArray"></param>
        /// <returns></returns>
        public static byte[] EncryptCore(string key, Byte[] toEncryptArray)
        {
            Byte[] keyArray = System.Text.Encoding.UTF8.GetBytes(key);
            var rijndael = new System.Security.Cryptography.RijndaelManaged();
            rijndael.Key = keyArray;
            rijndael.Mode = System.Security.Cryptography.CipherMode.ECB;
            rijndael.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
            rijndael.IV = System.Text.Encoding.UTF8.GetBytes(Iv);
            System.Security.Cryptography.ICryptoTransform cTransform = rijndael.CreateEncryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return resultArray;
        }
        public static byte[] DecryptCore(string key, Byte[] toEncryptArray)
        {
            Byte[] keyArray = System.Text.Encoding.UTF8.GetBytes(key); 
            var rijndael = new System.Security.Cryptography.RijndaelManaged();
            rijndael.Key = keyArray;
            rijndael.Mode = System.Security.Cryptography.CipherMode.ECB;
            rijndael.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
            rijndael.IV = System.Text.Encoding.UTF8.GetBytes(Iv);
            System.Security.Cryptography.ICryptoTransform cTransform = rijndael.CreateDecryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return resultArray;
        }
        #endregion
    }
}
