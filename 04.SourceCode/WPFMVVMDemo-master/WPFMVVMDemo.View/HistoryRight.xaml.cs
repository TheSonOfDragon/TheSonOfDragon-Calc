﻿using System;
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

namespace WPFMVVMDemo.View
{
    /// <summary>
    /// HistoryRight.xaml 的交互逻辑
    /// </summary>
    public partial class HistoryRight : UserControl
    {
        public HistoryRight()
        {
            InitializeComponent();
        }

        public static implicit operator ColumnDefinition(HistoryRight v)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.MemoryC.Visibility = Visibility.Hidden;
            this.HistoryC.Visibility = Visibility.Visible;
            this.label2.Visibility = Visibility.Hidden;
            this.label1.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.HistoryC.Visibility = Visibility.Hidden;
            this.MemoryC.Visibility = Visibility.Visible;
            this.label1.Visibility = Visibility.Hidden;
            this.label2.Visibility = Visibility.Visible;
        }
    }
}
