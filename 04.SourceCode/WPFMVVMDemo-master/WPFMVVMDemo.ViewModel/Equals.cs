using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;
using Operation;

namespace WPFMVVMDemo.ViewModel
{
  public  class Equals
    {
        Basic_Opreation bo = new Basic_Opreation();
        public string getResult()
        {
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
                    return Cache.underCache;
        }
    }
}
