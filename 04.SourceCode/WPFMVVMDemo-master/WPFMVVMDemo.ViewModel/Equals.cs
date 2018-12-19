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
        Memory.History his = new Memory.History();
        public string getResult()
        {
            //Cache.judgeEqual = true;
            //Cache.judgeTurn = true;
            //Cache.judgeNewInp = true;
            
            if (MainWindowsViewModel._disPlayTextTop == "" && Cache.operatorCacheNew =="")//直接等于
            {
                Cache.resultCache =Cache.underCache;
               his.AddHistory(Cache.resultCache+"="+Cache.resultCache);
                his.AddHistory("111");

            }else if("".Equals(Cache.operatorCacheNew)){//单目后等于
                Cache.resultCache = Cache.underCache;
            }
            else if (Cache.judgeNewInp && !Cache.judgeTurn)//混合等于
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
            else//最后一位运算符
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
            Cache.resultCache = AddComma.Addcomma(Cache.resultCache);
                    return  Cache.resultCache;
        }
    }
}
