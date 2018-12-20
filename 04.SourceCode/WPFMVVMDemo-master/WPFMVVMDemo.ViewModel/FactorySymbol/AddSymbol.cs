using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;
using Operation;

namespace WPFMVVMDemo.ViewModel.Symbol
{
    public class AddSymbol
    {
        //正负号，对Cache.underCache的值无变化，只改变大小
       
        public string GetSymbol()
        {
            if (Cache.judgeMinus)
            {
                Cache.underCache = "-" + Cache.underCache;
                Cache.judgeMinus = false;
                return Cache.underCache;
            }
            else
            {
                Cache.underCache = Cache.underCache.Substring(1, Cache.underCache.Length - 1);
                Cache.judgeMinus = true;
                return Cache.underCache;
            }
        }
    }
}

