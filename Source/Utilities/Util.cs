using ExcelDataReader;

using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;

using OpenQA.Selenium;
using PageObjectModel.Drivers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace PageObjectModel.Source.Utilities
{
    class Util : DriverSetup
    {
        
        public void TakesScreenshot(string testName)
        {
            
            ITakesScreenshot sc = driver as ITakesScreenshot;
            Screenshot screenshot = sc.GetScreenshot();
            string imageFilePath = "C:\\Users\\Sukannya Ghosh\\source\\repos\\PageObjectModel\\ScreenShots\\"+testName+".png";
            screenshot.SaveAsFile(imageFilePath);
        }

        // get project root directory
        public static string getProjecrRootDirectory()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            return currentDirectory.Split("bin")[0];
        }

        private static DataTable ExcelToDataTable(string fileName)
        {
            //open file and returns as Stream
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            //Createopenxmlreader via ExcelReaderFactory
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream); //.xlsx
                                                                                           //Set the First Row as Column Name
                                                                                           // excelReader.IsFirstRowAsColumnNames = true;
                                                                                           //Return as DataSet
            DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });
            //Get all the Tables
            DataTableCollection table = result.Tables;
            //Store it in DataTable
            DataTable resultTable = table["url"];

            //return
            return resultTable;
        }

        static List<Datacollection> dataCol = new List<Datacollection>();

        public static void PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);
            Console.WriteLine(table.Rows.Count);
            
            //Iterate through the rows and columns of the Table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    //Add all the details for each row
                    dataCol.Add(dtTable);
                }
            }
        }
        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in dataCol
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
    public class Datacollection
    {
        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }
    }

   
}


