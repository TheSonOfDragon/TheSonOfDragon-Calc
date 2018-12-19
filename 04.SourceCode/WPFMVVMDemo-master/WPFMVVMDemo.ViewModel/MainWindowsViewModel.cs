
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Runtime.InteropServices;
using WPFMVVMDemo.ViewModel;
using Infrastructure;
using Memory;
using System.Collections.ObjectModel;


namespace WPFMVVMDemo.ViewModel
{
    public class MainWindowsViewModel : NotifyObject
    {
        //指当前输出屏幕的所有内容 
        public static string _disPlayTextUnder="0";
        public static string _disPlayTextTop = "";     
        

        AddNumber.NumberOneToNine addNum = new AddNumber.NumberOneToNine();
        AddNumber.NumberZero addNum0 = new AddNumber.NumberZero();
        AddNumber.Dot addDot = new AddNumber.Dot();
        Symbol.AddOperator addOperator = new Symbol.AddOperator();
        Symbol.AddSymbol addSymbol = new Symbol.AddSymbol();
        Symbol.AddSingle addSingle = new Symbol.AddSingle();
        Memory.Memory mem = new Memory.Memory();
        Memory.History his = new Memory.History();
        Equals eq = new Equals();

        public string DisPlayTextUnder
        {
            get
            {
                return _disPlayTextUnder;
            }
            set
            {
                SetPropertyNotify(ref _disPlayTextUnder, value, nameof(DisPlayTextUnder));
            }
        }
        public string DisPlayTextTop
        {
            get
            {
                return _disPlayTextTop;
            }
            set
            {
                SetPropertyNotify(ref _disPlayTextTop, value, nameof(DisPlayTextTop));
            }
        }

        private readonly NVCommand _addCommand;
        public NVCommand AddCommand
        {
            get => _addCommand;
        }

        private readonly NVCommand _subtractCommand;
        public NVCommand SubtractCommand
        {
            get => _subtractCommand;
        }

        private readonly NVCommand _multiplyCommand;
        public NVCommand MultiplyCommand
        {
            get => _multiplyCommand;
        }

        private readonly NVCommand _divideCommand;
        public NVCommand DivideCommand
        {
            get => _divideCommand;
        }
        //创建添加数字addNum的委托
        private readonly NVCommand _num1Command;
        public NVCommand Num1Command
        {
            get => _num1Command;
        }

        private readonly NVCommand _num2Command;
        public NVCommand Num2Command
        {
            get => _num2Command;
        }

        private readonly NVCommand _num3Command;
        public NVCommand Num3Command
        {
            get => _num3Command;
        }

        private readonly NVCommand _num4Command;
        public NVCommand Num4Command
        {
            get => _num4Command;
        }

        private readonly NVCommand _num5Command;
        public NVCommand Num5Command
        {
            get => _num5Command;
        }

        private readonly NVCommand _num6Command;
        public NVCommand Num6Command
        {
            get => _num6Command;
        }

        private readonly NVCommand _num7Command;
        public NVCommand Num7Command
        {
            get => _num7Command;
        }

        private readonly NVCommand _num8Command;
        public NVCommand Num8Command
        {
            get => _num8Command;
        }

        private readonly NVCommand _num9Command;
        public NVCommand Num9Command
        {
            get => _num9Command;
        }

        private readonly NVCommand _num0Command;
        public NVCommand Num0Command
        {
            get => _num0Command;
        }

        private readonly NVCommand _percentOneCommand;
        public NVCommand PercentOneCommand
        {
            get => _percentOneCommand;
        }

        private readonly NVCommand _squareCommand;
        public NVCommand SquareCommand
        {
            get => _squareCommand;
        }

        private readonly NVCommand _inverseCommand;
        public NVCommand InverseCommand
        {
            get => _inverseCommand;
        }

        private readonly NVCommand _radicalCommand;
        public NVCommand RadicalCommand
        {
            get => _radicalCommand;
        }
        private readonly NVCommand _reciprocalCommand;
        public NVCommand ReciprocalCommand
        {
            get => _reciprocalCommand;
        }

        private readonly NVCommand _clearAllCommand;
        public NVCommand ClearAllCommand
        {
            
            get => _clearAllCommand;
        }

        private readonly NVCommand _clearPreCommand;
        public NVCommand ClearPreCommand
        {
            get => _clearPreCommand;
        }

        private readonly NVCommand _delCommand;
        public NVCommand DelCommand
        {
            get => _delCommand;
        }

        private readonly NVCommand _dotCommand;
        public NVCommand DotCommand
        {
            get => _dotCommand;
        }

        private readonly NVCommand _equalsCommand;
        public NVCommand EqualsCommand
        {
            get => _equalsCommand;
        }
        private readonly NVCommand btn_ms;
        public NVCommand Btn_ms
        {
            get => btn_ms;
        }
        private readonly NVCommand btn_mc;
        public NVCommand Btn_mc
        {
            get => btn_mc;
        }
        private readonly NVCommand btn_mr;
        public NVCommand Btn_mr
        {
            get => btn_mr;
        }
        private readonly NVCommand btn_minus;
        public NVCommand Btn_minus
        {
            get => btn_minus;
        }
        private readonly NVCommand btn_plus;
        public NVCommand Btn_plus
        {
            get => btn_plus;
        }
        public MainWindowsViewModel()
        {
            _addCommand = new NVCommand(AddHandler);
            _subtractCommand = new NVCommand(SubtractHandler);
            _multiplyCommand = new NVCommand(MultiplyHandler);
            _divideCommand = new NVCommand(DivideHandler);
            //实现委托
            _num1Command = new NVCommand(Num1Handler);
            _num2Command = new NVCommand(Num2Handler);
            _num3Command = new NVCommand(Num3Handler);
            _num4Command = new NVCommand(Num4Handler);
            _num5Command = new NVCommand(Num5Handler);
            _num6Command = new NVCommand(Num6Handler);
            _num7Command = new NVCommand(Num7Handler);
            _num8Command = new NVCommand(Num8Handler);
            _num9Command = new NVCommand(Num9Handler);
            _num0Command = new NVCommand(Num0Handler);
            _percentOneCommand = new NVCommand(PercentOneHandler);
            _squareCommand = new NVCommand(SquareHandler);
            _inverseCommand = new NVCommand(InverseHandler);
            _reciprocalCommand = new NVCommand(ReciprocalHandler);
            _radicalCommand = new NVCommand(RadicalHandler);
            _clearAllCommand = new NVCommand(ClearAllHandler);
            _clearPreCommand = new NVCommand(ClearPreHandler);
            _delCommand = new NVCommand(DelHandler);
            _equalsCommand = new NVCommand(EqualsHandler);
            _dotCommand = new NVCommand(DotHandler);
            btn_ms = new NVCommand(MS);
            btn_mc = new NVCommand(MC);
            btn_mr = new NVCommand(MR);
            btn_minus = new NVCommand(MMinus);
            btn_plus = new NVCommand(MPlus);
        }

        private void AddHandler()
        {
            DisPlayTextTop = addOperator.JudgeOperator("＋");
            DisPlayTextUnder =AddFormat.Addformat(AddComma.Addcomma(Cache.underCache))   ;
        }
        
        private void SubtractHandler()
        {
            DisPlayTextTop = addOperator.JudgeOperator("－");
            DisPlayTextUnder = AddFormat.Addformat(AddComma.Addcomma(Cache.underCache));
        }
        
        private void MultiplyHandler()
        {
            DisPlayTextTop = addOperator.JudgeOperator("×");
            DisPlayTextUnder =AddFormat.Addformat(AddComma.Addcomma(Cache.underCache))   ;
        }

        private void DivideHandler()
        {
            DisPlayTextTop = addOperator.JudgeOperator("÷");
            DisPlayTextUnder = AddFormat.Addformat(AddComma.Addcomma(Cache.underCache));
        }

        //添加添加0-9数字的方法
        private void Num1Handler()
        {
            DisPlayTextUnder = AddComma.Addcomma(addNum.Judgefornumber("1"))  ;
            DisPlayTextTop = Cache.topCache;
            //Console.WriteLine(_disPlayTextUnder);

        }
        private void Num2Handler()
        {
            DisPlayTextUnder = AddComma.Addcomma(addNum.Judgefornumber("2"))  ;
            DisPlayTextTop = Cache.topCache;
        }
        private void Num3Handler()
        {

            DisPlayTextUnder = AddComma.Addcomma(addNum.Judgefornumber("3"))  ;
            DisPlayTextTop = Cache.topCache;

        }
        private void Num4Handler()
        {
            DisPlayTextUnder = AddComma.Addcomma(addNum.Judgefornumber("4"))  ;
            DisPlayTextTop = Cache.topCache;

        }
        private void Num5Handler()
        {
            DisPlayTextUnder = AddComma.Addcomma(addNum.Judgefornumber("5"))  ;
            DisPlayTextTop = Cache.topCache;
        }
        private void Num6Handler()
        {
            DisPlayTextUnder = AddComma.Addcomma(addNum.Judgefornumber("6"))  ;
            DisPlayTextTop = Cache.topCache;

        }
        private void Num7Handler()
        {
            DisPlayTextUnder = AddComma.Addcomma(addNum.Judgefornumber("7"))  ;
            DisPlayTextTop = Cache.topCache;

        }
        private void Num8Handler()
        {
            DisPlayTextUnder = AddComma.Addcomma(addNum.Judgefornumber("8"))  ;
            DisPlayTextTop = Cache.topCache;
        }
        private void Num9Handler()
        {
            DisPlayTextUnder = AddComma.Addcomma(addNum.Judgefornumber("9"))  ;
            DisPlayTextTop = Cache.topCache;
        }
        private void Num0Handler()
        {
            DisPlayTextUnder = AddComma.Addcomma(addNum0.JudgeZero())  ;
            DisPlayTextTop = Cache.topCache;
        }
        private void PercentOneHandler()//%
        {
            DisPlayTextTop = addSingle.JudgeForSinge("%");
            DisPlayTextUnder = AddComma.Addcomma(Cache.underCache);
        }
        private void SquareHandler()//平方
        {
            DisPlayTextTop = addSingle.JudgeForSinge("x²");
            DisPlayTextUnder =AddComma.Addcomma(Cache.underCache) ;
        }
        private void InverseHandler()//相反数
        {
            DisPlayTextTop = addSingle.JudgeForSinge("±");
            DisPlayTextUnder = AddComma.Addcomma(Cache.underCache);
        }
        private void ReciprocalHandler()//倒数
        {
            DisPlayTextTop = addSingle.JudgeForSinge("1/x");
            DisPlayTextUnder = AddComma.Addcomma(Cache.underCache);
        }
        private void RadicalHandler()//根号
        {
            DisPlayTextTop = addSingle.JudgeForSinge("√");
            DisPlayTextUnder = AddComma.Addcomma(Cache.underCache);
        }

        private void ClearAllHandler()//C键清空所有
        {
            Cache.topCache = "";
            Cache.underCache = "";
            DisPlayTextTop = "";
            DisPlayTextUnder = "0";
            Cache.operatorCacheOld = "";
            Cache.operatorCacheNew = "";
            Cache.resultCache = "";
            Cache.judgeNewInp = false;
            Cache.judgeTurn = true;
            Cache.judgeSinge = false;
            Cache.judgeEqual = false;
            Cache.judgeMinus = true;

        }
            #region CE
        private void ClearPreHandler()//CE键退一步操作
        {
            if (Cache.judgeSinge)
            {
                Cache.topCache = Cache.topCache.Substring(0, Cache.topCache.LastIndexOf(Cache.operatorCacheNew)+1);
                DisPlayTextTop = Cache.topCache;
                Cache.judgeSinge = false;
            }
            DisPlayTextUnder = "0";
            Cache.underCache = "0";
            #endregion
        }
        private void DelHandler() //退格键 
        {
            if(Cache.judgeNewInp)
            {
            }
            else if(!Cache.judgeTurn)
            {

            }
            else
            {


            if (Cache.underCache.Length > 1)
            {
            Cache.underCache = Cache.underCache.Substring(0, Cache.underCache.Length - 1);
                DisPlayTextUnder =AddComma.Addcomma(Cache.underCache) ;
            }
            else
            {
                Cache.underCache = "0";
                DisPlayTextUnder = Cache.underCache;
            }
            }

        }
        private void DotHandler()
        {
            DisPlayTextUnder = AddComma.Addcomma(addDot.Judgefordot()) ;
        }
        private void EqualsHandler()//等于
        {
            DisPlayTextUnder =AddFormat.Addformat(eq.getResult()) ;
            Cache.judgeEqual = true;
            Cache.judgeTurn = true;
            Cache.judgeNewInp = true;
            if (MainWindowsViewModel._disPlayTextTop == "" && Cache.operatorCacheNew == "")//直接等于
            {
                his.AddHistory(Cache.resultCache + "=" + Cache.resultCache);
            }
            else if ("".Equals(Cache.operatorCacheNew))
            {//单目后等于

            }
            else if (Cache.judgeNewInp && !Cache.judgeTurn)//混合等于
            {

            }
            else//最后一位运算符
            {
                if (_disPlayTextTop != "")
                {
                his.AddHistory(_disPlayTextTop+ Cache.underCache + "=" + Cache.resultCache);

                }else
                {
                his.AddHistory(_disPlayTextUnder + Cache.operatorCacheNew + Cache.underCache + "=" + Cache.resultCache);
                }
            }
            History.Clear();
            foreach (var item in his.GetHistory())

            {
                History.Insert(0, item);

            }
            DisPlayTextTop = "";
            Cache.topCache = "";

        }
        private ObservableCollection<string> _memory = new ObservableCollection<string> { "内存中没有内容" };
        public ObservableCollection<string> Memory
        {
            get { return _memory; }

        }
        private ObservableCollection<string> _history = new ObservableCollection<string> { "尚无历史记录" };
        public ObservableCollection<string> History
        {
            get { return _history; }

        }
        private void MS()
        {
            //his.AddStorage();
            mem.MSChange(DisPlayTextUnder);

            Memory.Clear();
            foreach (var item in mem.GetMemory())

            {
                Memory.Insert(0, item);

            }
        }
        private void MC()
        {
            mem.MSClear();
            Memory.Clear();
            foreach (var item in mem.GetMemory())

            {

                Memory.Insert(0, item);

            }
        }
        private void MR()
        {
            DisPlayTextUnder = mem.GetMemory().Last();
        }
        private void MMinus()
        {
            mem.MSMinus(DisPlayTextUnder);
            Memory.Clear();
            foreach (var item in mem.GetMemory())

            {
                Memory.Insert(0, item);

            }

        }
        private void MPlus()
        {
            mem.MSPlus(DisPlayTextUnder);
            Memory.Clear();
            foreach (var item in mem.GetMemory())

            {
                Memory.Insert(0, item);

            }
        }

    }
}
