using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 身份证验证
{
    class Program
    {
        string[] quan = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');//首先是表示第i位置上的加权因子以,分割
        string[] lastchar = ("1,0,X,9,8,7,6,5,4,3,2").Split(',');//校验码数组
        static void Main(string[] args)
        {
            string idcard=Console.ReadLine();//读取输入的数据
            Program p = new Program();
            p.isidcard(idcard);
        }
        private bool isidcard(string idcard)//判断函数
        {
            if (idcard.Length == 15&&istrue15idcard(idcard))//如果为15为身份证号切是正确的15位身份证号码
            {
                int num = 0;
                idcard = idcard.Insert(6, "19");//在15位身份证的第6位之后插入19表示年份
                for (int i = 0; i < idcard.Length; i++)
                {
                    num += int.Parse(idcard[i].ToString()) * Convert.ToInt32(quan[i]);//计算加权和
                }
                
                idcard=idcard+lastchar[num % 11];//在末尾添加一个校验码
                
                Console.WriteLine(idcard);
                return true;
 
            }
            else if (idcard.Length == 18&&istrue18idcard(idcard))//如果为18位身份证号且是正确的18位身份证号码
            {
                Console.WriteLine(idcard);
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool istrue15idcard(string idcard)//判断是否为正确的15位
        {
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";//正确省份的数组
            if (address.IndexOf(idcard.Remove(2)) == -1)//判断输入的前2位是否在address这个数组中,列入我的是51就能够找到
            {
                return false;//判断省份
            }
            string birth=idcard.Substring(6,6).Insert(4,"-").Insert(2,"-"); //转换为列如95-12-11的效果 
            DateTime dt = new DateTime();
            if (DateTime.TryParse(birth,out dt) == false)//日期验证
            {
                return false;
            }
            long id;
            if(long.TryParse(idcard,out id)==false)
            {
                return false;
            }
            Console.WriteLine("出生日期是" + birth);
            return true;
        }
        private bool istrue18idcard(string idcard)
        {
            
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(idcard.Remove(2)) == -1)
            {
                return false;//判断省份
            }
            string birth = idcard.Substring(6, 8).Insert(4, "-").Insert(7, "-"); //转换为列如1995-12-11的效果 
            DateTime dt = new DateTime();
            if (DateTime.TryParse(birth, out dt) == false)//日期验证
            {
                return false;
            }
            long id;
            if (long.TryParse(idcard.Remove(17), out id) == false)//判断前17位是否为数字
            {
                return false;
            }
            
            int num = 0;
            for (int i = 0; i < idcard.Length-1; i++)
            {
                num += int.Parse(idcard[i].ToString()) * Convert.ToInt32(quan[i]);//循环求加权和
            }
            if(lastchar[num%11]!=idcard[17].ToString())//如果求得的值和身份证的最后一位的值相同
            {
                return false;
            
            }
            return true;
        }
    }
}
