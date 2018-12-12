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
        string num;
        Basic_Opreation bo = new Basic_Opreation();
        public string getResult()
        {
            if (Cache.judgeNewInp && !Cache.judgeTurn)
            {
                Cache.resultCache = MainWindowsViewModel._disPlayTextUnder;
            switch (Cache.operatorCacheNew)
            {
                case "+":
                    num = bo.Add(Cache.resultCache, Cache.underCache).ToString();
                    break;
                case "-":
                    num = bo.Sub(Cache.resultCache, Cache.underCache).ToString();
                    break;
                case "×":
                    num = bo.Mul(Cache.resultCache, Cache.underCache).ToString();
                    break;
                case "÷":
                    num = bo.Div(Cache.resultCache, Cache.underCache).ToString();
                    break;
            }
            }
            else
            {
                switch (Cache.operatorCacheNew)
                {
                    case "+":
                        num = bo.Add(Cache.resultCache, Cache.underCache).ToString();
                        Cache.resultCache = num;
                        break;
                    case "-":
                        num = bo.Sub(Cache.resultCache, Cache.underCache).ToString();
                        Cache.resultCache = num;
                        break;
                    case "×":
                        num = bo.Mul(Cache.resultCache, Cache.underCache).ToString();
                        Cache.resultCache = num;
                        break;
                    case "÷":
                        num = bo.Div(Cache.resultCache, Cache.underCache).ToString();
                        Cache.resultCache = num;
                        break;
                }

            }

                    return num;
        }
    }
}
