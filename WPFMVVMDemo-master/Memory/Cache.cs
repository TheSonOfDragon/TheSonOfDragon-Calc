using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Memory
{
   public static class Cache
    {
        //缓存顶部栏内容
        public static string topCache = "";
        //缓存底部栏内容
        public static string underCache = "";
        //缓存上一个符号 
        public static string operatorCacheOld = "";
        //缓存上一次结果
        public static string resultCache = "0";
        //缓存最新符号
        public static string operatorCacheNew = "";
        //判断是否为新输入
        public static bool judgeNewInp = false;
        //四则运算符点击次数是否超过1
        public static bool judgeTurn = true;
        //是否是对结果单目运算
        public static bool judgeSinge = false;
        
    }
}
