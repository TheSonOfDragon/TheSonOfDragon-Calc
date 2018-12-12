using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    //一元运算
    public class Complex_Operation
    {

        public string Sqrt(string num1)
        {
            return Math.Sqrt(Convert.ToDouble(num1)).ToString();
        }
        public string Squ(string num1)
        {
            return Math.Pow(Convert.ToDouble(num1), 2).ToString();
        }
        public string OneCent(string num1)
        {
            return Math.Pow(Convert.ToDouble(num1), 0.1).ToString();
        }
        public string Minus(string num1)
        {
            return (-Convert.ToDouble(num1)).ToString();
        }
    }
}
