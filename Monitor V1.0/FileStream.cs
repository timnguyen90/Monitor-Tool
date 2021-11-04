using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Collections;

namespace Monitor_V1._0
{
    /// <summary>
    /// Author:NguyenPhuc
    /// Date:12/19/2013
    /// </summary>
    class FileStream
    {
        public DateTime Date { get; set; }
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Value3 { get; set; }
        public double Value4 { get; set; }
        public string FileName { get; set; }
        public DataTable Data;
        private System.IO.FileStream fs;
        /// <summary>
        /// Khoi tao cau truc cua Datatable
        /// </summary>
        public FileStream()
        {
            Data = new DataTable("TableData");
            Data.Columns.Add("Datetime", typeof(DateTime));
            Data.Columns.Add("Value1", typeof(double));
            Data.Columns.Add("Value2", typeof(double));
            Data.Columns.Add("Value3", typeof(double));
            Data.Columns.Add("Value4", typeof(double));
        }
        /// <summary>
        /// Doc va xu ly du lieu
        /// </summary>
        public void ReadData()
        {
            fs = new System.IO.FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadLine();
            while (str != null)
            {
                //Xu ly lay du lieu
                string[] temp = str.Split('\t');
                string[] DateTemp = temp[0].Split('.');
                string[] HourTemp = temp[1].Split(':');
                //Ghi Ngay cua cac kenh
                Date = AddValue(int.Parse(DateTemp[0]), int.Parse(DateTemp[1]), int.Parse(DateTemp[2]),int.Parse(HourTemp[0]),int.Parse(HourTemp[1]),int.Parse(HourTemp[2]));
                //Ghi gia tri cua cac kenh
                Value1 = double.Parse(temp[2]);
                Value2 = double.Parse(temp[3]);
                Value3 = double.Parse(temp[4]);
                Value4 = double.Parse(temp[5]);
                //ghi vao Datatable
                DataRow row = Data.NewRow();
                row["Datetime"] = Date;
                row["Value1"] = Value1;
                row["Value2"] = Value2;
                row["Value3"] = Value3;
                row["Value4"] = Value4;
                Data.Rows.Add(row);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        /// <summary>
        /// Add gia tri ngay thang nam
        /// </summary>
        /// <param name="Day"></param>
        /// <param name="Month"></param>
        /// <param name="Year"></param>
        /// <param name="Hour"></param>
        /// <param name="Minute"></param>
        /// <param name="Second"></param>
        public DateTime AddValue(int Day,int Month,int Year,int Hour, int Minute,int Second){
            DateTime t = new DateTime(Year,Month,Day,Hour,Minute,Second);
            return t;
        }
        /// <summary>
        /// Thuc hien doc file va tra ve du lieu duoi dang datatable
        /// </summary>
        /// <returns></returns>
        public DataTable ReturnAllData()
        {
            ReadData();
            return Data;
        }
        #region 
        /// <summary>
        /// Chon ra value1 va gio tu ngay tuong tuong
        /// </summary>
        /// <returns></returns>
        //public IEnumerable SelectValue1(DateTime dt)
        //{
        //    var query = (from row in Data.AsEnumerable()
        //                 where row.Field<DateTime>("Datetime") == dt
        //                 select new
        //                 {
        //                     Datetime = row.Field<DateTime>("Datetime"),
        //                     Value1 = row.Field<int>("Value1")
        //                 });
            
        //   return query;
        //}
        #endregion
    }
}
