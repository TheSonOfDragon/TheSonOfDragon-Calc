﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;

namespace Operation
{
    //二元运算
    public class Basic_Opreation
    {
        public string Add(string num1, string num2)
        {
            
            return (Convert.ToDecimal(num1) + Convert.ToDecimal(num2)).ToString();

        }
        public string Sub(string num1, string num2)
        {
            
            return (Convert.ToDecimal(num1) - Convert.ToDecimal(num2)).ToString();
        }
        public string  Mul(string num1, string num2)
        {
            return (Convert.ToDecimal(num1) * Convert.ToDecimal(num2)).ToString();
        }
        public string Div(string num1, string num2)
        {
            

            if (num2 == "0")
            {
                Cache.topCache = "除数不能为零";

            }
                return (Convert.ToDecimal(num1) / Convert.ToDecimal(num2)).ToString();

            
        }
    }
}
