using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace 用户数据录入
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.button2.Visible = true;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && (radioButton1.Checked == true || radioButton2.Checked == true))
            {
                try
                {

                    ConnectionDB();
                    IsConnected();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


 
            }
        }
        public void IsConnected()
        {
            string ConnectionString = "server=192.168.72.128;uid=sa;pwd=hackerxiaoke;database=Test_user;Connect Timeout=1";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlcmd = new SqlCommand();
                try
                {

                    conn.Open();
                    if (ConnectionState.Open == conn.State)
                    {
                        label5.Text = "数据库已连接";
                    }
                 

                    conn.Close();
                    
                }
                catch (Exception ex)
                {
                    

                        label5.Text = "数据库未连接";

                }
 
            }
        }
        public void ConnectionDB()
        {
            SqlTransaction Transaction=null;
            string ConnectionString = "server=192.168.72.128;uid=sa;pwd=hackerxiaoke;database=Test_user";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlcmd = new SqlCommand();
                
                
                try
                {
                    conn.Open();
                    Transaction=conn.BeginTransaction();
                    sqlcmd.Connection = conn;
                    sqlcmd.Transaction = Transaction;
                    sqlcmd.CommandText = "insert into User_info values (@User_name,@User_tel,@User_Id_Card,@User_sex,@User_introduction)";
                    sqlcmd.Parameters.AddWithValue("@User_name", textBox1.Text);
                    sqlcmd.Parameters.AddWithValue("@User_tel", textBox3.Text);
                    sqlcmd.Parameters.AddWithValue("@User_Id_Card", textBox2.Text);
                    sqlcmd.Parameters.AddWithValue("@User_sex", radioButton1.Checked ? "男" : "女");
                    sqlcmd.Parameters.AddWithValue("@User_introduction", textBox4.Text);
                    sqlcmd.ExecuteNonQuery();
                    Transaction.Commit();
                    /*
                     sqlcmd.Parameters["@User_name"].Value=textBox1.Text;
                    sqlcmd.Parameters["@User_tel"].Value=textBox3.Text;
                    sqlcmd.Parameters["@User_Id_Card"].Value=textBox2.Text;
                    sqlcmd.Parameters["@User_sex"].Value = radioButton1.Checked ? "男" : "女";
                    sqlcmd.Parameters["@User_introduction"].Value=textBox4.Text;
                     */
                    conn.Close();
                    MessageBox.Show("用户数据添加成功");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("连接数据库错误:" + ex.Message);
                }
 
            }
           
 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }



    }
}
