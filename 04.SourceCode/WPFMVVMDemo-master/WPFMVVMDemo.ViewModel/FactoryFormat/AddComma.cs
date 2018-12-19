using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;

namespace WPFMVVMDemo.ViewModel
{

    //111
    static class AddComma
    {
        //为整数部分添加逗号
        public static string Addcomma(string underCache)
        {
            string integer;
            if (Cache.underCache.Contains("-") && Cache.underCache.Contains(".") && Cache.underCache.Length >= 19)
            {
                Cache.underCache = Cache.underCache.Substring(0, 19);
            }
            else if (!Cache.underCache.Contains("-") && Cache.underCache.Contains(".") && Cache.underCache.Length >= 18)
            {
                Cache.underCache = Cache.underCache.Substring(0, 18);
            }
            else if (Cache.underCache.Contains("-") && !Cache.underCache.Contains(".") && Cache.underCache.Length >= 17)
            {
                Cache.underCache = Cache.underCache.Substring(0, 17);
            }
            else if (!Cache.underCache.Contains("-") && !Cache.underCache.Contains(".") && Cache.underCache.Length >= 16)
            {
                Cache.underCache = Cache.underCache.Substring(0, 16);
            }

            if (Cache.underCache.Contains("."))
            {
                //判断是否有小数点，只取整数部分
                integer = Cache.underCache.Substring(0, Cache.underCache.IndexOf("."));
                CommaIndex(ref integer);
                return integer + Cache.underCache.Substring(Cache.underCache.IndexOf("."));
            }
            else
            {
                integer = Cache.underCache;
                CommaIndex(ref integer);
                return integer;
            }




        }
        //AddComma方法的子部分，负责计算
        private static void CommaIndex(ref string integer)
        {
            //整数部分3个以下不需要加逗号
            if (integer.Length <= 3)
                return;

            char[] strs = integer.ToCharArray();
            List<char> list = new List<char>();
            int len = strs.Length;
            for (int i = 0; i < len; i++)
            {
                list.Add(strs[i]);
            }
            int index = len / 3 - 1;
            for (int i = 0; i <= index; i++)
            {
                if ((len % 3 == 0) && i == 0)
                    continue;
                if ((len % 3 == 0) && i != 0)
                {
                    list.Insert(i * 3 + i - 1, ',');
                    continue;
                }
                list.Insert(len % 3 + i * 3 + i, ',');
            }
            integer = string.Join("", list.ToArray());
        }
    }
}
