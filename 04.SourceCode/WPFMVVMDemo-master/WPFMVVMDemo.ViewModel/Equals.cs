using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;
using Operation;

namespace WPFMVVMDemo.ViewModel
{
    public class Equals
    {
        Basic_Opreation bo = new Basic_Opreation();
        public string getResult()
        {
            Cache.judgeEqual = true;
            Cache.judgeTurn = true;
            Cache.judgeNewInp = true;
            if (MainWindowsViewModel._disPlayTextTop == "" && Cache.operatorCacheNew == "")
            {
                Cache.resultCache = Cache.underCache;
            }
            else if ("".Equals(Cache.operatorCacheNew))
            {
                Cache.resultCache = Cache.underCache;
            }
            else if (Cache.judgeNewInp && !Cache.judgeTurn)
            {
                Cache.resultCache = MainWindowsViewModel._disPlayTextUnder;
                switch (Cache.operatorCacheNew)
                {
                    case "＋":
                        Cache.resultCache = bo.Add(Cache.resultCache, Cache.underCache).ToString();
                        break;
                    case "－":
                        Cache.resultCache = bo.Sub(Cache.resultCache, Cache.underCache).ToString();
                        break;
                    case "×":
                        Cache.resultCache = bo.Mul(Cache.resultCache, Cache.underCache).ToString();
                        break;
                    case "÷":
                        Cache.resultCache = bo.Div(Cache.resultCache, Cache.underCache).ToString();
                        break;
                }
            }
            else
            {
                switch (Cache.operatorCacheNew)
                {
                    case "＋":
                        Cache.resultCache = bo.Add(Cache.resultCache, Cache.underCache).ToString();

                        break;
                    case "－":
                        Cache.resultCache = bo.Sub(Cache.resultCache, Cache.underCache).ToString();

                        break;
                    case "×":
                        Cache.resultCache = bo.Mul(Cache.resultCache, Cache.underCache).ToString();

                        break;
                    case "÷":
                        Cache.resultCache = bo.Div(Cache.resultCache, Cache.underCache).ToString();

                        break;
                }

            }

            return Cache.resultCache;
        }
    }
}
