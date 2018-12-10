using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;
namespace WPFMVVMDemo.ViewModel.AddNumber
{
    
    class NumberZero : IJudge.JudgeZero
    {
        public string JudgeZero()
        {
            if (Cache.operatorCacheNow != "0")
            {
                Cache.operatorCacheOld = Cache.operatorCacheNow;
            }
            Cache.operatorCacheNow = "0";
            if (Cache.judgeNewInp)
            {
                Cache.underCache = "";
                Cache.judgeNewInp = false;
            }
            if ("".Equals(Cache.underCache) || "0".Equals(Cache.underCache))
            {
                Cache.underCache = "";
                return "0";
            }
            else
            {
                Cache.underCache += "0";
                return Cache.underCache;
            }
        }
    }
    
}