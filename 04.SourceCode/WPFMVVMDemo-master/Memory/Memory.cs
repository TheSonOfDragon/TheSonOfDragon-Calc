using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVMDemo.ViewModel;

namespace Memory
{
    //内存
   public class Memory : IMS.MSChange,IMS.MSClear,IMS.MSUse
    {
      public List<string> mymemory = new List<string>();

        public void MsChange()
        {
            throw new NotImplementedException();
        }

        public void MSClear()
        {
            throw new NotImplementedException();
        }

        public void MSUse()
        {
            throw new NotImplementedException();
        }
    }
}
