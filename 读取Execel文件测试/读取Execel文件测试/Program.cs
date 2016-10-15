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
//HSSF is the POI Project's pure Java implementation of the Excel '97(-2007) file format. 
//XSSF is the POI Project's pure Java implementation of the Excel 2007 OOXML (.xlsx) file format. 
namespace 读取Execel文件测试
{
    class Execl
    {
        private StringBuilder strbuild=new StringBuilder();
        private List<string> str=new List<string>();
        private XSSFWorkbook xssfworkbook=null;
        private HSSFWorkbook hssfworkbook=null;
        private ISheet sheet = null;
        private string result;
        /// <summary>
        /// 将 execel中的数据读取到控制台中
        /// </summary>
        /// <param name="sheetname">excel工作簿sheet的名称</param>
        /// <param name="filePath">execel的路径</param>
        /// <returns></returns>
        public StringBuilder  ImportExcelFile(string sheetname,string filePath)
        {
            

            try
            {
                using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
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
                         hssfworkbook = new HSSFWorkbook(file);
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
                        int  cellCount = firstRow.LastCellNum;////一行最后一个cell的编号 即总的列数
                        int  startRow = sheet.FirstRowNum;
                        //最后一列的标号
                        int rowCount = sheet.LastRowNum;
                        for (int i = startRow; i <= rowCount; ++i)
                        {
                            IRow row = sheet.GetRow(i);
                            if (row == null) continue; //没有数据的行默认是null　　　　　　　
                            for (int j = row.FirstCellNum; j < cellCount; ++j)
                            {
                                if (row.GetCell(j) != null) //同理，没有数据的单元格都默认是null
                                     result = row.GetCell(j).ToString();
                                strbuild.Append(row.GetCell(j).ToString() + " ");
                            }
                            str.Add(result);
                            strbuild.Append("\n");
                        }
                    }
                    if(hssfworkbook==null&&xssfworkbook==null)
                    {
                        Console.WriteLine(filePath+"不是一个有效的xls或者xlsx文件");
                    }
                    return strbuild;
                    


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
            StringBuilder result=new Execl().ImportExcelFile(null, "F:\\test.xlsx");
            //for (int i = 0; i < result.Count;i++ )
            //{
             //   Console.WriteLine(result[i]);
           // }
            Console.WriteLine(result);
            
        }
    }
}
