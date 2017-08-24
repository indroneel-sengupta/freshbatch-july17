using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormDemo
{
    class SqlHelper
    {
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlCommand;
        public SqlDataAdapter _sqlDataAdapter;
        public string sqlQuerry = null;
        public string conString = @"Data Source=INDRONEEL-S;Initial Catalog=LoginDemo;Integrated Security=True;Pooling=False";
        public SqlHelper()
        {
            _sqlConnection = new SqlConnection(conString);
            if (_sqlConnection.State == System.Data.ConnectionState.Closed) _sqlConnection.Open();
            Console.WriteLine("Connection is open");
        }

        public DataTable GetDatatable(string sqlQuerry)
        {
            var ds = new DataSet();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuerry, conString);
            _sqlDataAdapter.Fill(ds, "login");
            return ds.Tables[0];
        }

        public bool ExecuteNonQuery(string sql)
        {
            var result = false;
            _sqlCommand = new SqlCommand(sql, _sqlConnection);
            var count = _sqlCommand.ExecuteNonQuery();
            result = (count > 0) ? true : false;
            return result;
        }

        public void Update(string userName, string password)
        {
            sqlQuerry = string.Format(@"select * from Login where UserName = '{0}' ",userName);
            var ds = new DataSet();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuerry, conString);
            SqlCommandBuilder sb = new SqlCommandBuilder(_sqlDataAdapter);
            _sqlDataAdapter.Fill(ds, "login");
            DataTable dt = ds.Tables[0];
            if(dt.Rows.Count > 0)
            {
                dt.Rows[0][1] = userName;
                dt.Rows[0][2] = password;
                _sqlDataAdapter.Update(dt);
            }
            

        }
    }
}
