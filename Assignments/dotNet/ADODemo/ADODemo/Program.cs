using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var _student = new Student();
                _student.Update();
                _student.GetDataSet();
            }
            catch (Exception e)
            {
                Console.WriteLine("Connection Exception : {0}",e.Message);
            }
        }
    }
}
