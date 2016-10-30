using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Listbox元素的移动
{
    public partial class Form1 : Form
    {
        public List<Listitem> listitems = new List<Listitem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 1;
           /* while (i <= 10)
            {
                leftListbox.Items.Add("左第" + i + "项");
                rightListbox.Items.Add("右第" + i + "项");
                i++;
 
            }*/
           
            Listitem java = new Listitem("Java", 4, 25);
            Listitem c = new Listitem("C", 4, 30);
            Listitem Csharp=new Listitem("C#",3,25);
            Listitem 算法设计=new Listitem("算法设计",5,40);
            Listitem 软件代码开发技术=new Listitem("软件代码开发技术",3,30);
            listitems.Add(java);
            listitems.Add(c);
            listitems.Add(Csharp);
            listitems.Add(算法设计);
            listitems.Add(软件代码开发技术);


            leftListbox.Items.Add(java.Name);
            leftListbox.Items.Add(c.Name);
            leftListbox.Items.Add(Csharp.Name);
            leftListbox.Items.Add(算法设计.Name);
            leftListbox.Items.Add(软件代码开发技术.Name);
            xuefenglabel.Text = "没有选择课程";
            xueshilabel.Text = "没有选择课程";
           
            
          
        }

        private void toleftbutton_Click(object sender, EventArgs e)
        {
            if (rightListbox.SelectedIndex > -1)//如何右边的listbox选中
            {
               addtolistbox(leftListbox, rightListbox.SelectedIndex,rightListbox.SelectedItem.ToString());
               removeatlistbox(this.rightListbox, rightListbox.SelectedIndex);
               

            }
            else
            {
                MessageBox.Show("请选择要移动的元素");
            }
             if (rightListbox.SelectedIndex > -1)
            {
                xueshilabel.Text = allxueshi().ToString();
                xuefenglabel.Text = allxuefeng().ToString();
            }
            else
            {
                xueshilabel.Text =xuefenglabel.Text= "没有选择课程";
                ;
            }
        }
        /// <summary>
        /// 从列表中移除元素
        /// </summary>
        /// <param name="listbox">要移除的列表</param>
        /// <param name="indexoflistbox">选择的序号</param>
        private void removeatlistbox(ListBox listbox,int indexoflistbox)
        {
            for (int i = listbox.Items.Count-1; i >= 0; i--)
            {
                if (listbox.SelectedIndex == i)
                {
                    listbox.Items.RemoveAt(i);
                    
                 
                }
                

            }
           
 
        }
        /// <summary>
        /// 添加元素到需要移动的列表box
        /// </summary>
        /// <param name="listbox">需要从什么列表中移动</param>
        /// <param name="indexoflistbox">需要移动的列表的开始号(从0开始)</param>
       
        private void addtolistbox(ListBox listbox,int indexoflistbox,string value)
        {
            if (listbox == leftListbox)
            {
                leftListbox.Items.Add(value);
            }
            if (listbox == rightListbox)
            {
                rightListbox.Items.Add(value);
            }
           
        }

        private void torightbutton_Click(object sender, EventArgs e)
        {
            if (leftListbox.SelectedIndex > -1)//如何右边的listbox选中
            {
                addtolistbox(rightListbox, leftListbox.SelectedIndex, leftListbox.SelectedItem.ToString());
                removeatlistbox(this.leftListbox, leftListbox.SelectedIndex);


            }
            else
            {
                MessageBox.Show("请选择要移动的元素");
            }
            if (rightListbox.Items.Count >0)
            {
                xueshilabel.Text = allxueshi().ToString();
                xuefenglabel.Text = allxuefeng().ToString();
                
            }
            else
            {
                xueshilabel.Text =xuefenglabel.Text= "没有选择课程";
                
            }
        }

        private void toleftallbutton_Click(object sender, EventArgs e)
        {
            if (rightListbox.Items.Count!=0)//如果右边的listbox中的元素不为空
            {
                for (int i = rightListbox.Items.Count-1; i >= 0; i--)
                {
                    addtolistbox(leftListbox, rightListbox.SelectedIndex, rightListbox.Items[i].ToString());
                    
                }

                rightListbox.Items.Clear();
             }
            else
            {
                MessageBox.Show("没有要移动的元素");
            }

            if (rightListbox.Items.Count > 0)
            {
                xueshilabel.Text = allxueshi().ToString();
                xuefenglabel.Text = allxuefeng().ToString();
            }
            else
            {
                xueshilabel.Text =xuefenglabel.Text= "没有选择课程";
             }

        }

        private void torightallbutton_Click(object sender, EventArgs e)
        {
            if (leftListbox.Items.Count != 0)//如果右边的listbox中的元素不为空
            {
                for (int i = leftListbox.Items.Count - 1; i >= 0; i--)
                {
                    addtolistbox(rightListbox, leftListbox.SelectedIndex, leftListbox.Items[i].ToString());

                }

                leftListbox.Items.Clear();
            }
            else
            {
                MessageBox.Show("没有要移动的元素");
            }
            if (rightListbox.Items.Count > 0)
            {
                xueshilabel.Text = allxueshi().ToString();
                xuefenglabel.Text = allxuefeng().ToString();
            }
            else
            {
                xueshilabel.Text = xuefenglabel.Text = "没有选择课程";
            }  
        }
        /// <summary>
        /// 包含课程名，学时和学分的一个集合类
        /// </summary>
        public class Listitem
        {
            private string name = "";
            private int xuefeng = 0;
            private int xueshi = 0;
            public Listitem(string name,int xuefeng,int  xueshi)
            {
                this.xuefeng = xuefeng;
                this.name = name;
                this.xueshi = xueshi;
 
            }

            public string Name
            {
                set { this.name = value; }
                get { return name; }
            }
            public int Xuefeng
            {
                get { return xuefeng; }
                set { this.xuefeng = value; }
            }
            public int Xueshi
            {
                get { return xueshi; }
                set { this.xueshi = value; }
            }
        }
        public int allxuefeng()
        {
            int result = 0;
            for (int i = rightListbox.Items.Count-1; i >= 0; i--)
            {
                foreach (Listitem it in listitems)
                {
                    if (it.Name == rightListbox.Items[i].ToString())
                    {
                        result += it.Xuefeng;
                    }
 
                }
 
            }
            return result;
 
        }
        public int allxueshi()
        {
            int result = 0;
            for (int i = rightListbox.Items.Count-1; i >= 0; i--)
            {
                foreach (Listitem it in listitems)
                {
                    if (it.Name == rightListbox.Items[i].ToString())
                    {
                        result += it.Xueshi;
                    }

                }

            }
            return result;

 
        }




    
    }
}
