using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;
using Operation;

namespace WPFMVVMDemo.ViewModel.Symbol
{
    public class AddSymbol
    {
      private  bool flag = true;
        public string GetSymbol()
        {
            
                if (flag)
                {
                    flag = false;
                    Cache.underCache = "-" + Cache.underCache;
                    return Cache.underCache;

                }
                else
                {
                    flag = true;
                double value = Convert.ToDouble(Cache.underCache);
                    Cache.underCache = System.Math.Abs(value).ToString();
                    return Cache.underCache;
                }
            }
            }
        
    }
