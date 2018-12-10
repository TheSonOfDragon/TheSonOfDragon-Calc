using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMDemo.ViewModel.IJudge
{
    //判断输入的数字是1-9还是0，,1-9则覆盖，0则还是初始值0
    interface JudgeForNumber
    {
        string Judgefornumber(string number);
    }
}
