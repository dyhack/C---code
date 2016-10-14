using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WeBrowser控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "WebBorwser控件测试";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入要访问的网站的地址");
            }
            else
            {
                webBrowser1.Navigate(textBox1.Text.Trim());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Refresh();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
