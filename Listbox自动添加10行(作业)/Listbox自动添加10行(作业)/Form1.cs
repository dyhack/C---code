using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Listbox自动添加10行_作业_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i=1;
            while (i<=10)
            {
                this.listBox1.Items.Add(i+"项");
                i++;
            }
        }
    }
}
