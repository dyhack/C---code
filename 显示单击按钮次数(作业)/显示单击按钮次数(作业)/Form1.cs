using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 显示单击按钮次数_作业_
{
    public partial class Form1 : Form
    {
        public string str = "当前点击次数为";
        public static int  num=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = str + num + "次";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num++;
            this.textBox1.Text = str + num + "次";
        }

    }
}
