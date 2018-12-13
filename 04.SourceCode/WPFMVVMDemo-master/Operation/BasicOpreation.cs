using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;
using WPFMVVMDemo.ViewModel;

namespace Operation
{
    //二元运算
    public class Basic_Opreation
    {
        public Double Add(string num1, string num2)
        {
            return Convert.ToDouble(num1) + Convert.ToDouble(num2);

        }
        public Double Sub(string num1, string num2)
        {
            
            return Convert.ToDouble(num1) - Convert.ToDouble(num2);
        }
        public Double Mul(string num1, string num2)
        {
            return Convert.ToDouble(num1) * Convert.ToDouble(num2);
        }
        public Double Div(string num1, string num2)
        {
            

            if (num2 == "0")
            {
                Cache.topCache = "除数不能为零";

            }
                return Convert.ToDouble(num1) / Convert.ToDouble(num2);

            
        }
    }
}
