using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMDemo.ViewModel
{
    static class AddFormat
        //用于结果去零，去余的格式化操作  同步到dev123111111111111111111111111111111111111111111
    {
        public static string Addformat(string temp)
        {
            if (temp.Contains("."))
            {
                temp = temp.TrimEnd('0');
                if (temp.EndsWith(".")) temp = temp.Substring(0, temp.Length - 1);
            }
            return temp;
        }
    }
}
