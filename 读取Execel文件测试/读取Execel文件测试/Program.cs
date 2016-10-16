using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.HSSF.Util;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using NPOI.POIFS.NIO;

//HSSF is the POI Project's pure Java implementation of the Excel '97(-2007) file format. 
//XSSF is the POI Project's pure Java implementation of the Excel 2007 OOXML (.xlsx) file format. 
namespace 读取Execel文件测试
{
    class Execl
    {
        private IWorkbook workbook = null;
        private List<User_Excel> User_Execel_list=new List<User_Excel>();
        private StringBuilder strbuild=new StringBuilder();
        private List<string> str=new List<string>();
        private XSSFWorkbook xssfworkbook=null;
        private HSSFWorkbook hssfworkbook=null;
        private ISheet sheet = null;
        private string result;
        /// <summary>
        /// 将 execel中的数据读取到控制台中
        /// </summary>
        /// <param name="sheetname">excel工作簿sheet的名称(默认有3个,分别是sheet1，sheet2，sheet3)</param>
        /// <param name="filePath">execel的路径</param>
        /// <returns></returns>
        public List<User_Excel>  ImportExcelFile(string sheetname,string filePath)
        {
            

            try
            {
                using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
                {

                    if (filePath.IndexOf(".xlsx") > 0)//如果文件名后缀为xlsx，则使用xssf对象
                    {
                        xssfworkbook = new XSSFWorkbook(file);
                        if (sheetname != null)
                        {
                            sheet = xssfworkbook.GetSheet(sheetname);
                            if (sheet == null)////如果没有找到指定的sheetName对应的sheet，则尝试获取第一个sheet
                            {
                                sheet = xssfworkbook.GetSheetAt(0);
                            }

                        }
                        else
                        {
                            sheet = xssfworkbook.GetSheetAt(0);
                        }

                    }
                    else if (filePath.IndexOf(".xls") > 0)//如果文件名后缀为xls,则使用hssf对象
                    {
                        workbook = new HSSFWorkbook(file);
                        if (sheetname != null)
                        {
                            sheet = hssfworkbook.GetSheet(sheetname);
                            if (sheet == null)////如果没有找到指定的sheetName对应的sheet，则尝试获取第一个sheet
                            {
                                sheet = hssfworkbook.GetSheetAt(0);
                            }
                        }
                        else
                        {
                            sheet = hssfworkbook.GetSheetAt(0);
                        }

                    }
                  
                    if (sheet != null)
                    {
                        IRow firstRow = sheet.GetRow(0);
                        int cellCount = firstRow.LastCellNum;////一行最后一个cell的编号 即总的列数
                        int startRow = sheet.FirstRowNum;
                        //最后一列的标号
                        int rowCount = sheet.LastRowNum;
                        for (int i = startRow; i <= rowCount; ++i)
                        {
                            User_Excel userinfo = new User_Excel();
                            IRow row = sheet.GetRow(i);
                            if (row == null) continue; //没有数据的行默认是null　　　　　　　
                            /*for (int j = row.FirstCellNum; j < cellCount; ++j)
                            {
                                

                                if (row.GetCell(j) != null) //同理，没有数据的单元格都默认是null
                                     result = row.GetCell(j).ToString();
                               
                                //strbuild.Append(row.GetCell(j).ToString() + " ");
                                str.Add(result);
                            }
                            str.Add("\n");*/
                            if (row != null)
                            {

                                userinfo.getsetUser_name = row.GetCell(0).ToString();
                                userinfo.getsetUser_Id = row.GetCell(1).ToString();
                                userinfo.getsetPhoneNumber = row.GetCell(2).ToString();
                                ICell icell = row.CreateCell(3);
                                 icell.SetCellType(CellType.String);
                                icell.SetCellValue("test12222");
                                userinfo.getsetSign_time = row.GetCell(3).ToString();

                            }
                            User_Execel_list.Add(userinfo);
                            // strbuild.Append("\n");
                        }
                    }


                    if (hssfworkbook == null && xssfworkbook == null)
                    {
                        Console.WriteLine(filePath + "不是一个有效的xls或者xlsx文件");
                    }
                    if (xssfworkbook != null)
                    {
                        if(File.Exists("F:\\test.xlsx"))
                        {
                            File.Delete("F:\\test.xlsx");
                        }
                        FileStream outExecl = File.OpenWrite("F:\\test.xlsx");
                        xssfworkbook.Write(outExecl);
                        outExecl.Close();
                    }
                    if (hssfworkbook != null)
                    {
                     



                    }


                    return User_Execel_list;


                }
                }
            
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        

        }
      
        static void Main(string[] args)
        {
            List<User_Excel> result=new Execl().ImportExcelFile(null, "F:\\test.xlsx");
           /* for (int i = 0; i < result.Count;i++ )
            {
                Console.Write(result[i]);
            }*/
            foreach(User_Excel userinfo in result)
            {
                Console.WriteLine(userinfo.getsetUser_name+","+userinfo.getsetUser_Id+","+userinfo.getsetPhoneNumber+","+userinfo.getsetSign_time);

            }
           // Console.WriteLine(result);
            
        }
    }
    class User_Excel
    {
        private String User_name;
        private String PhoneNumber;
        private String User_Id;
        private String Sign_time;
        public String getsetUser_name
        {
            get { return User_name; }
            set { User_name = value; }
        }
        public String getsetPhoneNumber
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }
        public String getsetUser_Id
        {
            get { return User_Id; }
            set { User_Id = value; }
        }
        public String getsetSign_time
        {
            get { return Sign_time; }
            set { Sign_time = value; }
        }
        
 
    }
}
