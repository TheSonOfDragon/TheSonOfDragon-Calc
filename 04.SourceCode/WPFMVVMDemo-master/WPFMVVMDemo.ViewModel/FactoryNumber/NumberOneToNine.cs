using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMDemo.ViewModel.IJudge;
using Memory;

namespace WPFMVVMDemo.ViewModel.AddNumber
{
    public class NumberOneToNine : IJudge.JudgeForNumber
    {
        public string Judgefornumber(string number)
        {
            if (Cache.underCache == "0")
            {
                Cache.underCache = "";
            }
            Cache.underCache += number;
            return Cache.underCache;
        }
    }

}