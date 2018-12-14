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
            decimal x = Convert.ToDecimal(num1) / 3;
            decimal lastX = 0m;
            for (int i = 0; i < 50; i++)
            {
                x = (Convert.ToDecimal(num1) / (x * 2)) + (x / 2);
                if (x == lastX) break;
                lastX = x;
            }
            return x.ToString();

            //return Math.Sqrt(Convert.ToDouble(num1)).ToString();
        }
        public string Squ(string num1)
        {
            return (Convert.ToDecimal(num1) * Convert.ToDecimal(num1)).ToString();
        }
        public string OneCent(string num1)
        {
            
            return (1 / Convert.ToDecimal(num1)).ToString();
   
        }
        public string Minus(string num1)
        {
            return (-Convert.ToDecimal(num1)).ToString();
        }
    }
}
