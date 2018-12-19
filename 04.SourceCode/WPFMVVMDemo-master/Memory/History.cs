using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Memory
{
    //历史记录
    public class History

    {

        List<string> myhistory = new List<string>();

        public void AddHistory(string num)
        {
            myhistory.Add(num);
        }
        public List<string> GetHistory()
        {
            return myhistory;
        }
        public void Remove() { }
        public void clear() { }
    }
}
