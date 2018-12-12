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
            Cache.operatorCacheOld = Cache.operatorCacheNew;
            Cache.judgeTurn = true;
            Cache.judgeSinge = false;
            if (Cache.judgeNewInp)
            {

                Cache.underCache = "";
                Cache.judgeNewInp = false;
            }
            if (Cache.underCache == "0")
            {
                Cache.underCache = "";
            }
            Cache.underCache += number;
            return Cache.underCache;
        }
    }

}