using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Memory
{
    //历史记录
   public class History_Memory
    {
        
        List<string> history = new List<string>();

        public void AddHistory(string num)
        {
            history.Add(num);
        }
        public List<string> GetHistory()
        {
            return history;
        }
        public void Remove() { }
        public void clear() { }
    }
}
