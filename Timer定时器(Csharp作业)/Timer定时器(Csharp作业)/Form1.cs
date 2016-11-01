using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer定时器_Csharp作业_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }



        private void button1_Click(object sender, EventArgs e)
        {
    
                timer1.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt =dateTimePicker1.Value.Date;
            DateTime dt2 = new DateTime(dateTimePicker1.Value.Year,dateTimePicker1.Value.Month,dateTimePicker1.Value.Day,0,0,0);
            label1.Text = string.Format("{0:yyyy-mm-dd hh:mm:ss}",DateTime.Now);
            TimeSpan ts = DateTime.Now - dt2;
            label3.Text = ((int)(ts.TotalSeconds)).ToString()+"秒"; 
            //label3.Text = Math.Abs((DateTime.Now - dt2).TotalSeconds).ToString()+"秒";
               
        }


    }
}
