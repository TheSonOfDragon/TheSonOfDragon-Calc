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
            if (Cache.underCache == "")
            {
                Cache.underCache = "0";
                return Cache.underCache;
            }
            else
            {
                Cache.underCache += 0;
                return Cache.underCache;
            }
        }
    }
    
}