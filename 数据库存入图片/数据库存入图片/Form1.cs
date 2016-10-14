using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace 数据库存入图片
{
    public partial class Form1 : Form
    {
        SqlDataAdapter adapter;
        DataSet dataset = new DataSet();
        private string connectionstring="server=192.168.199.167;uid=sa;pwd=hackerxiaoke;database=Test_user";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string querystring = "select * from  Picture";
            SqlConnection conn = new SqlConnection(connectionstring);
             adapter = new SqlDataAdapter(querystring, conn);
             SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
             adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.Fill(dataset,"Picture");
            this.textBox1.DataBindings.Add(new Binding("Text", dataset, "Picture.picture_info"));//将textbox1的绑定字段和数据库中的pictu_info字段相绑定
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                this.listBox1.Items.Add(dataset.Tables[0].Rows[i][0]);//将datase中的picture_id号提取出来显示在控件中
            }
            this.listBox1.SelectedIndex = 0;

        }
        private void ShowImage()
        {
            //释放占用的资源
            if (this.pictureBox1.Image != null)
            {
                this.pictureBox1.Image.Dispose();
            }
            //如果当前记录的图像字段不是SQLserver的空值，则显示图像
            if (dataset.Tables[0].Rows[this.listBox1.SelectedIndex][1] != Convert.DBNull)
            {
                //将数据表中的picture_image字段的值存入bytes字节数组中
                byte[] bytes = (byte[])dataset.Tables[0].Rows[this.listBox1.SelectedIndex][1];
                MemoryStream ImageStream = new MemoryStream(bytes);
                //利用MemoryStream对象产生Bitmap位图对象 
                Bitmap bt = new Bitmap(ImageStream);
                //将bt赋值给picture.box,显示图像
                this.pictureBox1.Image = bt;

            }
            else
            {
                this.pictureBox1.Image = null;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "*.jpg;*.bmp;*.*|*.jpg;*.bmp;*.*";
            //如果用户选择了图像文件
            if(openfiledialog.ShowDialog()==DialogResult.OK)
            {
                //产生stream流对象
                Stream stream=openfiledialog.OpenFile();
                int length = (int)stream.Length;
                //产生字节数组对象
                byte[] bytes = new byte[length];
                //将数据放入字节数组中
                stream.Read(bytes,0,length);
                stream.Close();
                dataset.Tables[0].Rows[listBox1.SelectedIndex][1] = bytes;
                ShowImage();
            }
        }

        private void button2_Click(object sender, EventArgs e)//移除图片
        {
            dataset.Tables[0].Rows[this.listBox1.SelectedIndex][1] = Convert.DBNull;
            ShowImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //更新数据库 
                adapter.Update(dataset, "Picture");
                MessageBox.Show("保存成功");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"保存失败");

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowImage();
            this.BindingContext[dataset, "Picture"].Position = this.listBox1.SelectedIndex;
        }
       
    }
}
