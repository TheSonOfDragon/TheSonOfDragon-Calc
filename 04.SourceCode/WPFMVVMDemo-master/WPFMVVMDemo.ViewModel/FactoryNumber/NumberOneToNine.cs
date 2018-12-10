using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMDemo.ViewModel.IJudge;
using Memory;

namespace WPFMVVMDemo.ViewModel.AddNumber
{
    public class NumberOneToNine : IJudge.JudgeForNumber
    {
        public string Judgefornumber(string number)
        {
            if (Cache.operatorCacheNow != "0")
            {
                Cache.resultCache = Cache.underCache;
            }
            //把之前的值传给resultCache
            if (Cache.operatorCacheNow != "0")
            {
                Cache.operatorCacheOld = Cache.operatorCacheNow;
            }
            if (Cache.judgeNewInp)
            {
                Cache.underCache = "";
                Cache.judgeNewInp = false;
            }

            Cache.underCache += number;
            return Cache.underCache;
        }
    }

}