using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace 도서판매관리_1512035_류주성
{
    class DBConn
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        // string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=데이터.mdb";

        // for ASP.NET
        //string connectionString = WebConfigurationManager.ConnectionStrings["haksa"].ConnectionString;  // for ASP.NET

        public OleDbConnection conn;

        public DBConn(String path)
        {
            conn = new OleDbConnection(connectionString+path);
            conn.Open();
        }

        public void Close()
        {
            conn.Close();
        }

        public OleDbConnection GetConn()
        {
            return conn;
        }

        public void ExecuteNonQuery(string sql)
        {
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public OleDbDataReader ExecuteReader(string sql)
        {
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            return cmd.ExecuteReader();
        }

        public object ExecuteScalar(string sql)
        {
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            return cmd.ExecuteScalar();
        }
    }
}
