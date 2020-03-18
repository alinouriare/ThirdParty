using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkExtention.Extentions
{
  public static  class StringExtention
    {
        public const char ArabicKeChar = 'ك';
        public const char ArabicYeChar = 'ي';
       

        public const char PersianKeChar = 'ک';
        public const char PersianYeChar = 'ی';
     

        public static string SetPersianYeKe(this string input)
        {

            Dictionary<string, string> keyValues = new Dictionary<string, string> { 
            ["ك"] ="ک",
                ["ي"] = "ی"
            };

            foreach (var item in keyValues)
            {
                input = input.Replace(item.Key, item.Value);
            }
            return input;
        }
    }
}
