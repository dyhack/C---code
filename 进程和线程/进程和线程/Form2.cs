using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace 进程和线程
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

    public  string return_id()
    {
        return textBox1.Text.ToString(); 
    }

    private void button1_Click(object sender, EventArgs e)
    {
       // MessageBox.Show(id);
        Process process = Process.GetProcessById(Convert.ToInt32(textBox1.Text));
        process.Kill();



    }


    }
}
