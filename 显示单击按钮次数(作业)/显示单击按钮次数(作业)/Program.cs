using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 显示单击按钮次数_作业_
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
