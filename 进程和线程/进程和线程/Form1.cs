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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//启动记事本进程
        {
            start_notepad();
        }

        private void button2_Click(object sender, EventArgs e)//停止进程
        {
            Process[] process;
            process = Process.GetProcessesByName("notepad");
            foreach(Process pr in process)
            {
                pr.WaitForExit(1000);
                pr.CloseMainWindow();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            Process[] process;
            process = Process.GetProcesses();
            try
            {
                foreach (Process pr in process)
                {
                    this.listBox1.Items.Add(pr.ProcessName + " " + pr.StartTime.ToString() + " " + pr.Id);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            start_notepad();
        }
        private void start_notepad()
        {
            Process myprocess = new Process();
            myprocess.StartInfo.FileName = "notepad";
            myprocess.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            

        }
  


    }
}
