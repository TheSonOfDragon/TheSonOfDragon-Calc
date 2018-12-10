using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;
using Operation;

namespace WPFMVVMDemo.ViewModel.Symbol
{
  public  class AddSingle :  IJudge.JudgeForSingle
    {
        public string JudgeForSinge(string single)
        {
            Complex_Operation CO = new Complex_Operation();
            switch (single)
            {
                case "√":
                    if (Cache.underCache == ""&&Cache.topCache=="")
                    {
                        Cache.underCache = (CO.Sqrt("0"));
                        Cache.topCache += ("√(" + "0" + ")");
                    }else if (Cache.topCache != "" && Cache.judgeSinge)
                    {
                        int a = Cache.topCache.LastIndexOf(Cache.operatorCacheNow);
                        Cache.topCache = Cache.topCache.Substring(0, a+1) + "√" + "(" + Cache.underCache + ")";
                        Cache.underCache = (CO.Sqrt(Cache.underCache));
                    }
                    else
                    {
                        Cache.topCache = "√"+"(" + Cache.underCache + ")";
                        Cache.underCache = (CO.Sqrt(Cache.underCache));
                    }
                    break;
                case "²":
                    {
                        if (Cache.underCache == "" && Cache.topCache == "")
                        {
                            Cache.underCache = (CO.Squ("0"));
                            Cache.topCache += ("√(" + "0" + ")");
                        }
                        else if (Cache.topCache != "" && Cache.judgeSinge)
                        {
                            int a = Cache.topCache.LastIndexOf(Cache.operatorCacheNow);
                            Cache.topCache = Cache.topCache.Substring(0, a + 1) + "√" + "(" + Cache.underCache + ")";
                            Cache.underCache = (CO.Squ(Cache.underCache));
                        }
                        else
                        {
                            Cache.topCache = "√" + "(" + Cache.underCache + ")";
                            Cache.underCache = (CO.Squ(Cache.underCache));
                        }
                        break;
                    }
                case "1/x":
                    {
                        if (Cache.underCache == "" && Cache.topCache == "")
                        {
                            Cache.underCache = (CO.Minus("0"));
                            Cache.topCache += ("√(" + "0" + ")");
                        }
                        else if (Cache.topCache != "" && Cache.judgeSinge)
                        {
                            int a = Cache.topCache.LastIndexOf(Cache.operatorCacheNow);
                            Cache.topCache = Cache.topCache.Substring(0, a + 1) + "√" + "(" + Cache.underCache + ")";
                            Cache.underCache = (CO.Minus(Cache.underCache));
                        }
                        else
                        {
                            Cache.topCache = "√" + "(" + Cache.underCache + ")";
                            Cache.underCache = (CO.Minus(Cache.underCache));
                        }
                        break;
                    }
               
            }
            return Cache.underCache;
        }
    }
    }

