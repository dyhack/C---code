using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 第一个WPF程序
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string name="全局变量测试";
        public MainWindow()
        {
            InitializeComponent();
            this.label1.Content = name;
 
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("测试WPF的button按钮");
        }

    }
}
