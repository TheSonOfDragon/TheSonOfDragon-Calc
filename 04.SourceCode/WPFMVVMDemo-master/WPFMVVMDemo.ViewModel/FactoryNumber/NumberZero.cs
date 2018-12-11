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
            Cache.operatorCacheOld = Cache.operatorCacheNew;
            Cache.judgeTurn = true;
            Cache.judgeSinge = false;
            if (Cache.judgeNewInp)
            {
                Cache.underCache = "";
                Cache.judgeNewInp = false;
            }
            if (Cache.underCache == "")
            {
                Cache.underCache = "0";
                return Cache.underCache;
            }
            else
            {
                Cache.underCache += 0;
                return Cache.underCache;
            }
        }
    }
    
}