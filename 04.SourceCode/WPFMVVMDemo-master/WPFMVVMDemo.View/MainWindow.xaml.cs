using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using WPFMVVMDemo.ViewModel;
using System.Windows.Interop;
using Memory;



namespace WPFMVVMDemo.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    /// 
    

public partial class MainWindow : Window
    {
        MainWindowsViewModel Mv = new MainWindowsViewModel();

#region 实现删除图标的静态方法
        public static class IconHelper
            {
                [DllImport("user32.dll")]
                static extern int GetWindowLong(IntPtr hwnd, int index);

                [DllImport("user32.dll")]
                static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

                [DllImport("user32.dll")]
                static extern bool SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter,
                           int x, int y, int width, int height, uint flags);

                [DllImport("user32.dll")]
                static extern IntPtr SendMessage(IntPtr hwnd, uint msg,
                           IntPtr wParam, IntPtr lParam);

                const int GWL_EXSTYLE = -20;
                const int WS_EX_DLGMODALFRAME = 0x0001;
                const int SWP_NOSIZE = 0x0001;
                const int SWP_NOMOVE = 0x0002;
                const int SWP_NOZORDER = 0x0004;
                const int SWP_FRAMECHANGED = 0x0020;
                const uint WM_SETICON = 0x0080;

                public static void RemoveIcon(Window window)
                {
                    //获取窗体的句柄
                    IntPtr hwnd = new WindowInteropHelper(window).Handle;

                    //改变窗体的样式
                    int extendedStyle = GetWindowLong(hwnd, GWL_EXSTYLE);
                    SetWindowLong(hwnd, GWL_EXSTYLE, extendedStyle | WS_EX_DLGMODALFRAME);

                    //更新窗口的非客户区，以反映变化
                    SetWindowPos(hwnd, IntPtr.Zero, 0, 0, 0, 0, SWP_NOMOVE |
                          SWP_NOSIZE | SWP_NOZORDER | SWP_FRAMECHANGED);
                }
            }
            protected override void OnSourceInitialized(EventArgs e)
            {
                IconHelper.RemoveIcon(this);
            }
#endregion      

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainWindowsViewModel();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //添加listbox的拉动处理事件，当窗体宽度width<=x时，listbox为hidden,当宽体宽度width>x时，listbox为
            //通过传入用于记录内存的list来在内存的listbox中通过Add()添加记录
            Add();
            //可以选取传入的不同的list通过button进行展现

    }
            //包装一个在listbox中添加记录的add()方法
            public void Add()
            {
            //listhistroy.SelectedItems.ToString();
            //listhistroy.Items.Add("list");
            }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listmemory.Visibility=Visibility.Hidden;
            listhistory.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listhistory.Visibility = Visibility.Hidden;
            listmemory.Visibility = Visibility.Visible;
        }

        private void BtMS(object sender, RoutedEventArgs e)
        {



        }
        
    }
    

}
