using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace MD5加密
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="")
            {
                MessageBox.Show("请输入字符串");
            }
            else
            {
                JiaMD5(textBox1.Text);
 
            }
        }
        private void JiaMD5(string MD5)
        {
            
            string  temp="";
            MD5 md5 = new MD5CryptoServiceProvider();//创建MD5对象
            byte[] data = System.Text.Encoding.Default.GetBytes(MD5);//将需要加密的MD5字符串先转换成为字节
            byte[] result = md5.ComputeHash(data);
            textBox2.Text = System.Text.Encoding.Default.GetString(result);
            foreach (byte b in result)
            {
                temp+= b.ToString("x").PadLeft(2,'0');
            }
            textBox2.Text = temp.Substring(8, 16);
           textBox3.Text=temp;s
        
            /*
            //欲进行md5加密的字符串
            string test = "123";
           
            //获取加密服务
        
            System.Security.Cryptography.MD5CryptoServiceProvider md5CSP = new System.Security.Cryptography.MD5CryptoServiceProvider();
       
            //获取要加密的字段，并转化为Byte[]数组
            byte[] testEncrypt = System.Text.Encoding.Default.GetBytes(test);

            //加密Byte[]数组
            byte[] resultEncrypt = md5CSP.ComputeHash(testEncrypt);
            string enPWD = "";
            //将加密后的数组转化为字段(普通加密)
            foreach (byte b in resultEncrypt)
            {
                enPWD += b.ToString("x");
            }
          
            textBox3.Text = enPWD;
            */
        }
            
    }
}
