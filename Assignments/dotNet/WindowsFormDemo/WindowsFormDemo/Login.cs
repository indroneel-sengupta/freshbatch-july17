using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormDemo
{
    class Login
    {
        public SqlHelper _sqlHelper;
        public string sqlQuerry;

        public Login()
        {
            _sqlHelper = new SqlHelper();
        }
        public bool _Login(string userName,string password)
        {
            sqlQuerry = string.Format(@"Select * from Login 
                            where UserName = '{0}'  AND Password = '{1}'", userName,password);
            DataTable dt = _sqlHelper.GetDatatable(sqlQuerry);
            
            dt.WriteXml("login.xls");
            return (dt.Rows.Count>0);
        }

        public void SaveData(string userName,string password)
        {
            
            sqlQuerry = string.Format(@"insert into Login values ('{0}', '{1}')", userName, password);
            var sqlWriter = _sqlHelper.ExecuteNonQuery(sqlQuerry);
        }

        public void Update(string usrName,string password,decimal amount)
        {
            sqlQuerry = string.Format(@"select Balance from Login 
                                        where UserName = '{0}' AND Password = '{1}'",usrName,password);
            decimal curBal = Convert.ToDecimal(_sqlHelper.ExecuteScalar(sqlQuerry));
            _sqlHelper.Update(usrName,password,(curBal+amount));
        }
    }
}
