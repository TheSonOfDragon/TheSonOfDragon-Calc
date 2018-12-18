
using MahApps.Metro.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Calculator
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SizeChanged += new System.Windows.SizeChangedEventHandler(MainWindow_Resize);
            
        }

        #region 标题栏所有事件
        /// <summary>
        /// 关闭窗口
        /// </summary>
        private void Btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 窗口最小化
        /// </summary>
        private void Btn_min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// 窗口最大化
        /// </summary>
        private void Btn_max_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        /// <summary>
        /// 窗口移动事件
        /// </summary>
        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        int i = 0;
        /// <summary>
        /// 鼠标双击事件
        /// </summary>
        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            i += 1;
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 300);
            timer.Tick += (s, e1) => { timer.IsEnabled = false; i = 0; };
            timer.IsEnabled = true;
            if (i % 2 == 0)
            {
                timer.IsEnabled = false;
                i = 0;
                this.WindowState = (this.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized);
            }
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.leftFlyout.Visibility = Visibility.Visible;
            if (!this.leftFlyout.IsOpen)
            {
                this.leftFlyout.IsOpen = true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.bottomFlyout.Visibility==Visibility.Visible)
            {
                this.bottomFlyout.Visibility = Visibility.Hidden;
                this.bottomFlyout.IsOpen = false;
            }
            else
            {
                this.bottomFlyout.Visibility = Visibility.Visible;
                this.bottomFlyout.IsOpen = true;
            }
        }


        #region 设置拉动添加控件
        HistoryRight historyRight = new HistoryRight();
        ColumnDefinition col = new ColumnDefinition();
        bool isSized = false;
        private void MainWindow_Resize(object sender, System.EventArgs e)
        {
            if (this.Width>=700&&(!isSized))
            {
                Grid1.ColumnDefinitions.Add(col);
                historyRight.Name = "historyRight";
                Grid1.Children.Add(historyRight);
                historyRight.SetValue(Grid.RowProperty, 0);
                historyRight.SetValue(Grid.RowSpanProperty, 4);
                historyRight.SetValue(Grid.ColumnProperty, 2);
                col.Width = new GridLength(330);
                isSized = true;
            }
            else if (isSized&&this.Width<700)
            {
                Grid1.ColumnDefinitions.RemoveAt(2);
                Grid1.Children.Remove(historyRight);
                isSized = false;
            }

        }
        #endregion
    }
}
