using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Threading;
namespace 第一个WPF程序
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        //程序退出是执行
        private void Application_Exit(object sender, ExitEventArgs e)
        {


        }
        //程序开始时执行
        private void Application_Startup(object sender, StartupEventArgs e)
        {
        
        }
        //重写的方法实现能够调用显示启动界面（没有0.5s的限制）
        protected override void OnStartup(StartupEventArgs e)
        {
            SplashScreen startup = new SplashScreen("suse.jpg");
            //关闭自动显示启动画面
            startup.Show(false);
            //设置2秒后加载界面自动关闭
            startup.Close(new TimeSpan(0, 0, 1));
            Thread.Sleep(2000);
            base.OnStartup(e);
        }

    }
}
