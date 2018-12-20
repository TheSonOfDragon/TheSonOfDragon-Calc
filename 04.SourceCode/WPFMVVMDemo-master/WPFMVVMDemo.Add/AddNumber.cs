using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;

namespace WPFMVVMDemo.Add
{
    public class AddNumber: NotifyObject
    {
        private String _disPlayText;

        public string DisPlayText
        {
            get
            {
                return _disPlayText;
            }
            set
            {
                SetPropertyNotify(ref _disPlayText, value, nameof(DisPlayText));
            }
        }
        private void ZeroHander()
        {
            DisPlayText = "0";
        }
        public void AddHandler()
        {
            DisPlayText = "+";
        }
    }
}
