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
    //添加加减乘除符号，并附带运算
    class AddOperator : IJudge.JudgeOperator
    {
        Basic_Opreation bo = new Basic_Opreation();
        public string JudgeOperator(string opt)
        {
            Cache.underCache = "";
            if (MainWindowsViewModel._disPlayTextTop == "")
            {
                if (Cache.operatorCacheOld == "")
                {
                    Cache.operatorCacheOld = opt;
                    Cache.topCache = 0 + Cache.operatorCacheOld;
                }
                else
                {
                    Cache.operatorCacheOld = opt;
                    Cache.topCache = "";
                    Cache.topCache = 0 + Cache.operatorCacheOld;
                }
                return Cache.topCache;
            }
            else
            {
                string x = MainWindowsViewModel._disPlayTextTop;
                Cache.operatorCacheOld = opt;
                if(x.Last().ToString()=="+"|| x.Last().ToString() == "-"|| x.Last().ToString() == "×"|| x.Last().ToString() == "÷")
                {
                    //最后一位是运算符，即不是第一次输入
                    Cache.topCache = Cache.topCache.Substring(0, Cache.topCache.Length - 2) + Cache.operatorCacheOld;
                    if (Cache.resultCache == "")
                    {
                        Cache.resultCache = 0 + Cache.underCache;
                    }
                    else
                    {
                    switch (x.Last().ToString())
                    {
                        case "+":
                            Cache.underCache = bo.Add(Cache.resultCache, Cache.underCache).ToString();
                                Cache.resultCache = Cache.underCache;
                            break;
                        case "-":
                            Cache.underCache = bo.Sub(Cache.resultCache, Cache.underCache).ToString();
                                Cache.resultCache = Cache.underCache;
                                break;
                        case "×":
                            Cache.underCache = bo.Mul(Cache.resultCache, Cache.underCache).ToString();
                                Cache.resultCache = Cache.underCache;
                                break;
                        case "÷":
                            Cache.underCache = bo.Div(Cache.resultCache, Cache.underCache).ToString();
                                Cache.resultCache = Cache.underCache;
                                break;
                    }
                    }
                }
                else
                {
                    Cache.topCache += Cache.underCache + opt;
                }
                return Cache.underCache;
            }
        }
    }
}