using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
namespace 获取电影爬虫
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static class HtmlAgilityPackHelper
        {
            /// <summary>
            /// 根据XPATH获取筛选的字符串
            /// </summary>
            /// <param name="content">需要提取的HTML的内容</param>
            /// <param name="xpath">Xpath表达式</param>
            /// <param name="separ">提取后的内容</param>
            /// <returns></returns>
            public static string GetStrByXpath(string content, string xpath, string separ)
            {
       
                HtmlAgilityPack.HtmlDocument doc=new HtmlAgilityPack.HtmlDocument(); //创建一个HTML文档的对象
                doc.LoadHtml(content);
                HtmlAgilityPack.HtmlNodeCollection repeatNodes = doc.DocumentNode.SelectNodes(xpath);
                string text = "";
                //循环节点
                foreach(HtmlAgilityPack.HtmlNode node in repeatNodes)
                {
                    text +=node.InnerText + separ;
                }
                return text;

               
                



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static class HttpHelper
        {
            public static string Get(string url, string querystr, Encoding encoding)
            {
                string res = string.Empty;
                if (!string.IsNullOrEmpty(querystr))
                {
                    url = string.Format("(0)?{1}", url, querystr);
                }
                try
                {
                    //创建请求
                    var request = WebRequest.Create(url) as HttpWebRequest;
                    if (request == null)
                    {
                        return res;
                    }
                    //设置请求
                    request.Method = "GET";//请求方式
                    request.Timeout = 19600;//超时时间
                    request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36";

                    //获取请求的响应
                    var response = (HttpWebResponse)request.GetResponse();
                    using (Stream stream = response.GetResponseStream())
                    {
                        if (stream != null)
                        {
                            StringBuilder stringbuilder = new StringBuilder();
                            //根据encoding读取响应流的字符串
                            StreamReader reader = new StreamReader(stream, encoding);

                            while (-1 != reader.Peek())//判断是否到页面的末尾读取结束
                            {
                                stringbuilder.Append(reader.ReadLine() + "\r\n");

                            }
                            res = stringbuilder.ToString();
                        }

                    }
                    response.Close();
                }
                catch (Exception e)
                {
                    res = e.Message;
                }
                return res;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string html = HttpHelper.Get("http://www.hdtiantang.com/", "", Encoding.UTF8);//获取网页的源代码
            string xpath = "/html/body/div[3]/div[1]/div/div[1]/p[1]";
            string allMovies = HtmlAgilityPackHelper.GetStrByXpath(html,xpath,"|");
            string[]moviesName = allMovies.Split('|');
            foreach (var item in moviesName)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
