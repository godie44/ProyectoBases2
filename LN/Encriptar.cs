﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LN
{
    public class Encriptar
    {

        public static string MD5Hash(string _text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(_text));

            
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

    }
}
