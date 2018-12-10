using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMDemo.ViewModel.IJudge;
using Memory;
using Operation;


namespace WPFMVVMDemo.ViewModel.Symbol
{
    class AddOperator : IJudge.JudgeOperator
    {
        Basic_Opreation bo = new Basic_Opreation();
        public string JudgeOperator(string opt)
        {
            if ("0".Equals(Cache.operatorCacheNow))
            {
                
                Cache.operatorCacheNow = opt;
                if(Cache.operatorCacheOld!="")
                {
                    if (Cache.underCache == "")
                    {
                        Cache.topCache += MainWindowsViewModel._disPlayTextUnder + Cache.operatorCacheNow;
                        Cache.resultCache = Cache.underCache;
                    }
                    else
                    {
                    Cache.topCache += Cache.underCache + Cache.operatorCacheNow;

                    }
                }
                else
                {
                    if (Cache.underCache == "")
                    {
                        Cache.topCache = "0" + Cache.operatorCacheNow;
                    }
                    else
                    {

                Cache.topCache = Cache.underCache + Cache.operatorCacheNow;
                    }
                }
                switch (Cache.operatorCacheOld)
                {
                    case "+":
                        Cache.underCache = bo.Add(Cache.resultCache, Cache.underCache).ToString();
                        break;
                    case "-":
                        Cache.underCache = bo.Sub(Cache.resultCache, Cache.underCache).ToString();
                        break;
                    case "×":
                        Cache.underCache = bo.Mul(Cache.resultCache, Cache.underCache).ToString();
                        break;
                    case "÷":
                        Cache.underCache = bo.Div(Cache.resultCache, Cache.underCache);
                        break;
                }
                Cache.judgeNewInp = true;
                Cache.judgeSinge = true;
                return Cache.topCache;
            }
            else
            {

                Cache.operatorCacheNow = opt;
                Cache.judgeSinge = true;
                Cache.topCache = Cache.topCache.Substring(0,Cache.topCache.Length-1) + Cache.operatorCacheNow;
            return Cache.topCache;
            }
            }
        }
    
}