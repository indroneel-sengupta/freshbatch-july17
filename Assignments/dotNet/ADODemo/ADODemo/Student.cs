using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADODemo
{
    class Student
    {
        public SqlHelper _sqlHelper;
        public string sqlQuerry;
        public Student()
        {
            _sqlHelper = new SqlHelper();
        }

        public void GetData()
        {
            sqlQuerry = "select COUNT(*) from DemoTable";
            var sqlReader = _sqlHelper.ExecuteScalar(sqlQuerry);

            Console.WriteLine("count : {0}",sqlReader);
            //while (sqlReader.Read())
            //{
            //    //sqlReader.Read();
            //    Console.WriteLine("Roll no : {0}    Student Name : {1}", sqlReader.ToString(), sqlReader.ToString());
                
            ////}
            //sqlReader;
            //if (sqlReader.HasRows)
            //{
            //    foreach (var row in sqlReader)
            //    {
            //    }
            //}
        }

        public void SaveData()
        {
            Console.WriteLine("Enter rol no");
            int rNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student name");
            string sName = Console.ReadLine();
            sqlQuerry =string.Format( @"insert into DemoTable values ({0}, '{1}')",rNo,sName);
            var sqlWriter = _sqlHelper.ExecuteNonQuery(sqlQuerry);
        }

        public void GetDataSet()
        {
            sqlQuerry = "Select * from DemoTable";
            DataTable dt = _sqlHelper.GetDatatable(sqlQuerry);
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine("Roll no : {0}    Student Name : {1}", dr[0].ToString(), dr[1].ToString());
            }
            dt.WriteXml("student.xls");
        }
        public void Update()
        {
            _sqlHelper.Update(224,"Naidu");
        }
        
    }
}
