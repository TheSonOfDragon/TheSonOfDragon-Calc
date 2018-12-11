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
            if (Cache.operatorCacheOld == ""&&Cache.underCache=="")
            {
                
                    Cache.operatorCacheNew = opt;
                    Cache.topCache = 0 + opt;
                    Cache.underCache = "0";
                Cache.judgeNewInp = true;
                return Cache.topCache;
            }
            else
            {
                if (Cache.judgeTurn)//四则运算符是否是新输入
                {
                Cache.topCache += Cache.underCache;
                    if (Cache.resultCache == "")
                    {
                        Cache.resultCache = 0 + Cache.underCache;
                    }
                        //新输入一个符号
                            switch (Cache.operatorCacheOld)
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
                Cache.operatorCacheNew = opt;
                string x = Cache.topCache;
                if (x != "")
                {
                if("+".Equals(x.Last().ToString())|| "-".Equals(x.Last().ToString()) || "×".Equals(x.Last().ToString()) || "÷".Equals(x.Last().ToString()))
                {
                    //最后一位是运算符，即不是第一次输入
                    Cache.topCache = Cache.topCache.Substring(0, Cache.topCache.Length -1) + opt;
                    
                }

                else
                {
                    Cache.topCache +=opt;
                }
                }
            }
                    Cache.judgeTurn = false;
                Cache.judgeNewInp = true;
                return Cache.topCache;
        }
    }
}