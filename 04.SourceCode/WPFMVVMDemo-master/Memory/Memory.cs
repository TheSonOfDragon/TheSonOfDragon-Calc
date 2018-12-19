using System;
using System.Collections.Generic;
using System.Linq;

namespace Memory
{
    //内存
    public class Memory : IMS.MSChange, IMS.MSClear, IMS.MSUse
    {
        public static List<string> mymemory = new List<string>();

        public void MSChange(string num)
        {
            mymemory.Add(num);
        }
        public List<string> GetMemory()
        {
            return mymemory;
        }

        public void MSClear()
        {
            mymemory.Clear();
        }
        public void MSMinus(string num)
        {
            if (mymemory.Count == 0)
            {
                mymemory.Add("0");
            }
            else
            {
                mymemory[mymemory.Count - 1] = (Convert.ToDecimal(mymemory.Last()) - Convert.ToDecimal(num)).ToString();
            }

        }
        public void MSPlus(string num)
        {
            if (mymemory.Count == 0)
            {
                mymemory.Add("0");
            }
            else
            {
                mymemory[mymemory.Count - 1] = (Convert.ToDecimal(mymemory.Last()) + Convert.ToDecimal(num)).ToString();
            }

        }
        public void MSUse()
        {
            throw new NotImplementedException();
        }
    }
}
