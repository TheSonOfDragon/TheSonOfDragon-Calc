using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;
using Operation;

namespace WPFMVVMDemo.ViewModel.Symbol
{
    public class AddSingle : IJudge.JudgeForSingle
    {
        Complex_Operation CO = new Complex_Operation();
        //添加单目符号，并进行运算
        public string JudgeForSinge(string single)
        {
            switch (single)
            {
                case "√":
                    if ("".Equals(Cache.underCache))
                    {
                        Cache.topCache += ("√(" + "0" + ")");
                        Cache.underCache = CO.Sqrt("0");
                        Cache.judgeSinge = true;
                    }
                    else if (!Cache.judgeSinge)
                    {
                        Cache.topCache += ("√(" + Cache.underCache + ")");
                        Cache.underCache = CO.Sqrt(Cache.underCache);
                        Cache.judgeSinge = true;
                    }
                    else
                    {
                        int index = Cache.topCache.LastIndexOf(Cache.operatorCacheNew);
                        string str = Cache.topCache.Substring(index, Cache.topCache.Length - index);
                        Cache.topCache = Cache.topCache.Substring(0, index) + ("√(" + str + ")");
                        Cache.underCache = CO.Sqrt(Cache.underCache);
                    }
                    break;
                case "x²":
                    if ("".Equals(Cache.underCache))
                    {
                        Cache.topCache += ("sqr(" + "0" + ")");
                        Cache.underCache = (CO.Squ("0"));
                        Cache.judgeSinge = true;
                    }
                    else if (!Cache.judgeSinge)
                    {
                        Cache.topCache += ("sqr(" + Cache.underCache + ")");
                        Cache.underCache = CO.Squ(Cache.underCache);
                        Cache.judgeSinge = true;
                    }
                    else
                    {
                        int index = Cache.topCache.LastIndexOf(Cache.operatorCacheNew);
                        string str = Cache.topCache.Substring(index, Cache.topCache.Length - index);
                        Cache.topCache = Cache.topCache.Substring(0, index) + ("sqr(" + str + ")");
                        Cache.underCache = CO.Squ(Cache.underCache);
                    }
                    break;
                case "1/x":
                    if ("".Equals(Cache.underCache))
                    {
                        Cache.topCache += ("1/(" + "0" + ")");
                        Cache.underCache = "除数不能为零";
                        break;
                    }
                    else if (!Cache.judgeSinge)
                    {
                        Cache.topCache += ("1/(" + Cache.underCache + ")");
                        Cache.underCache = CO.OneCent(Cache.underCache);
                        Cache.judgeSinge = true;
                    }
                    else
                    {
                        int index = Cache.topCache.LastIndexOf(Cache.operatorCacheNew);
                        string str = Cache.topCache.Substring(index, Cache.topCache.Length - index);
                        Cache.topCache = Cache.topCache.Substring(0, index) + ("1/(" + str + ")");
                        Cache.underCache = CO.OneCent(Cache.underCache);
                    }
                    break;
            }
            return Cache.topCache;

        }
    }
}

