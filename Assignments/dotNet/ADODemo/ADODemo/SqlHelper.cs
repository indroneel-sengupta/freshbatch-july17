using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADODemo
{
    class SqlHelper
    {
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlCommand;
        public SqlDataAdapter  _sqlDataAdapter;
        public string sqlQuerry = null;
        public string conString = @"Data Source=INDRONEEL-S;Initial Catalog=DemoStudent;Integrated Security=True";
        public SqlHelper()
        {
            _sqlConnection = new SqlConnection(conString);
            if(_sqlConnection.State == System.Data.ConnectionState.Closed) _sqlConnection.Open();
            Console.WriteLine("Connection is open");
        }

        public DataSet GetDataSet(string sqlQuerry)
        {
            var ds = new DataSet();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuerry,conString);
            _sqlDataAdapter.Fill(ds,"student");
            return ds;
        }

        public DataTable GetDatatable(string sqlQuerry)
        {
            var ds = new DataSet();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuerry, conString);
            _sqlDataAdapter.Fill(ds, "student");
            return ds.Tables[0];
        }

        public void Update(int rNo,string sName)
        {
            sqlQuerry = "select * from DemoTable";
            var ds = new DataSet();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuerry, conString);
            SqlCommandBuilder sb = new SqlCommandBuilder(_sqlDataAdapter);
            _sqlDataAdapter.Fill(ds, "student");
            DataTable dt = ds.Tables[0];
            dt.Rows[0][0] = rNo;
            dt.Rows[0][1] = sName;
            _sqlDataAdapter.Update(dt);
            
        }

        public SqlDataReader ExecuteQuery(string sqlQuery)
        {
            _sqlCommand = new SqlCommand(sqlQuery,_sqlConnection);
            //_sqlCommand.CommandText = sqlQuery();
            //_sqlCommand.Connection = _sqlConnection;
            return _sqlCommand.ExecuteReader();
        }

        public string ExecuteScalar(string sqlQuery)
        {
            _sqlCommand = new SqlCommand(sqlQuery, _sqlConnection);
            return _sqlCommand.ExecuteScalar().ToString();
        }

        public bool ExecuteNonQuery(string sql)
        {
            var result = false;
            _sqlCommand = new SqlCommand(sql, _sqlConnection);
            var count = _sqlCommand.ExecuteNonQuery();
            result = (count > 0) ? true : false;
            return result;
        }

    }
}
