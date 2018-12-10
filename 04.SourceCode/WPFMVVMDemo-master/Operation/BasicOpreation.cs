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
        public decimal Add(string num1, string num2)
        {
            
            return Convert.ToDecimal(num1) + Convert.ToDecimal(num2);

        }
        public decimal Sub(string num1, string num2)
        {
            
            return Convert.ToDecimal(num1) - Convert.ToDecimal(num2);
        }
        public decimal Mul(string num1, string num2)
        {
            
            return Convert.ToDecimal(num1) * Convert.ToDecimal(num2);
        }
        public string Div(string num1, string num2)
        {
            

            if (num2 == "0")
            {
                return "除数不能为零";

            }
            else
            {
                return (Convert.ToDecimal(num1) / Convert.ToDecimal(num2)).ToString();

            }
        }
    }
}
