using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace 用户数据录入
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“test_userDataSet2.User_info”中。您可以根据需要移动或删除它。
            // TODO: 这行代码将数据加载到表“test_userDataSet1.User_info”中。您可以根据需要移动或删除它。
            // TODO: 这行代码将数据加载到表“test_userDataSet.User_info”中。您可以根据需要移动或删除它。
            /*
            DataSet dataset=new DataSet();
            string ConnectionString = "server=192.168.72.128;uid=sa;pwd=hackerxiaoke;database=Test_user;Connect Timeout=1";
            SqlConnection conn = new SqlConnection(ConnectionString);
            string querystring = "select * from User_info";
            SqlDataAdapter Adapter = new SqlDataAdapter(querystring, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(Adapter);
            Adapter.InsertCommand = builder.GetInsertCommand();
            Adapter.DeleteCommand = builder.GetDeleteCommand();
            Adapter.UpdateCommand = builder.GetUpdateCommand();
            Adapter.Fill(dataset);
            this.dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Update();
            */
            //使用存储过程实现查询数据库..
            string ConnectionString = "server=192.168.72.128;uid=sa;pwd=hackerxiaoke;database=Test_user;Connect Timeout=1";
            using(SqlConnection conn=new SqlConnection(ConnectionString))
                try
                {
                    SqlCommand sqlcmd = new SqlCommand("sp_getdata", conn);
                    conn.Open();
                    sqlcmd.CommandType = CommandType.StoredProcedure;//设定sqlcmd的命令的格式是执行的存储过程
                    SqlParameter param = new SqlParameter("@region", SqlDbType.NVarChar, 50);
                    sqlcmd.Parameters.Add(param);
                    param.Direction = ParameterDirection.Input;
                    param.Value = "";
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                    //SqlDataReader reader = sqlcmd.ExecuteReader();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querystring;
            DataSet dataset = new DataSet();
            string ConnectionString = "server=192.168.72.128;uid=sa;pwd=hackerxiaoke;database=Test_user;Connect Timeout=1";
            SqlConnection conn = new SqlConnection(ConnectionString);
            if (textBox1.Text == "")
            {
                querystring = "select * from User_info ";

            }
            else
            {
                querystring = "select * from User_info where User_name ='" + textBox1.Text + "'";
            }
            SqlDataAdapter Adapter = new SqlDataAdapter(querystring, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(Adapter);
            Adapter.InsertCommand = builder.GetInsertCommand();
            Adapter.DeleteCommand = builder.GetDeleteCommand();
            Adapter.UpdateCommand = builder.GetUpdateCommand();
            Adapter.Fill(dataset);
            this.dataGridView1.DataSource = dataset.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a=dataGridView1.CurrentRow.Index;
            string user_id_card = dataGridView1.Rows[a].Cells["User_Id_Card"].Value.ToString();
            string querystring;
            DataSet dataset = new DataSet();
            string ConnectionString = "server=192.168.72.128;uid=sa;pwd=hackerxiaoke;database=Test_user;Connect Timeout=1";
            SqlConnection conn = new SqlConnection(ConnectionString);
            querystring = "delete from User_info  where User_Id_Card ='" + user_id_card + "'";
            conn = new SqlConnection(ConnectionString);
            SqlDataAdapter Adapter = new SqlDataAdapter(querystring, conn);
            Adapter.Fill(dataset);
            querystring = "select * from User_info";
            //DataSet dataset = new DataSet();
            conn = new SqlConnection(ConnectionString);
            Adapter = new SqlDataAdapter(querystring, conn);
            Adapter.Fill(dataset);
            //this.dataGridView1.DataSource = dataset;
            this.dataGridView1.DataSource = dataset.Tables[0];
            //newshow();


        }
        public void newshow()
        {
            string querystring;
            DataSet dataset = new DataSet();
            string ConnectionString = "server=192.168.72.128;uid=sa;pwd=hackerxiaoke;database=Test_user;Connect Timeout=1";
            SqlConnection conn = new SqlConnection(ConnectionString);
            querystring = "select * from User_info ";
            SqlDataAdapter Adapter = new SqlDataAdapter(querystring, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(Adapter);
            Adapter.InsertCommand = builder.GetInsertCommand();
            Adapter.DeleteCommand = builder.GetDeleteCommand();
            Adapter.UpdateCommand = builder.GetUpdateCommand();
            Adapter.Fill(dataset);
            this.dataGridView1.DataSource = dataset.Tables[0];

        }







    }
}
