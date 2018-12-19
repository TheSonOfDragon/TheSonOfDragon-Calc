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
            //单目后直接输入数字
            if (MainWindowsViewModel._disPlayTextTop != "")
            {

                if (MainWindowsViewModel._disPlayTextTop.Last().ToString() == ")")
                {
                    if (Cache.operatorCacheNew == "")
                    {
                        Cache.topCache = "";
                    }
                    else
                    {
                        Cache.topCache = Cache.topCache.Substring(0, Cache.topCache.LastIndexOf(Cache.operatorCacheNew) + 1);
                    }
                    Cache.underCache = "0";
                }
            }
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
                return AddFormat.Addformat(Cache.underCache);
            }
            if (Cache.underCache != "0")
            {

                Cache.underCache += 0;
                return Cache.underCache;
            }
            return "";

        }
    }

}