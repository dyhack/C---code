using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car类
{
    class car
    {
        private int oil;
        private string CarBrand="";//汽车的品牌
        private string displacement = "";//汽车排量
        private string CarColor = "";//汽车颜色
        private string CarOwner="";
        public car()
        {
            oil=0;
            
        }
        public car(string CarBrand,string  displacement,string CarColor,string CarOwner,int oil)
        {
            this.CarBrand=CarBrand;
            this.displacement=displacement;
            this.CarOwner=CarOwner;
            this.oil = oil;
        }
        public string GetSetCarBrand
        {
           get{return CarBrand;}
           set{CarBrand=value;}
        }
        public string GetSetdisplacement
        {
            get{return displacement;}
            set{displacement=value;}
        }
        public string GetSetCarcolor
        {
            get{return CarColor;}
            set{CarColor=value;}
        }
        public string GetSetCarowner
        {
            get{return CarOwner;}
            set{CarOwner=value;}
        }
        public  override string ToString()
       {
           
 	     return "汽车品牌:"+CarBrand+" 颜色:"+CarColor+" 排量:"+displacement+" 主人:"+CarOwner;
       }
        public void Carrun()
        {
            if (oil == 0)
            {
                Console.WriteLine ("都没油了，跑不动了");
            }
            else
            {

                for (int i = 0; i < 20; i++)
                {

                    Console.WriteLine("当前的汽油" + oil+"汽车跑得飞快");
                    oil-=5;
                    System.Threading.Thread.Sleep(1000);
                    

                }
                Console.WriteLine("汽车没油了");
            }

        }
        
    }
    class CarDemo
    {
        static void Main(string[] args)
        {
            car DASAUTO = new car("大众", "1.5T", "Black", "张柯",128);
            Console.WriteLine(DASAUTO.ToString());
            Console.WriteLine("设置汽车品牌为兰博基尼");
            DASAUTO.GetSetCarBrand = "兰博基尼";
            Console.WriteLine(DASAUTO.GetSetCarowner + "的汽车品牌更换为" + DASAUTO.GetSetCarBrand);
            DASAUTO.Carrun();

        }
        
    }
}
