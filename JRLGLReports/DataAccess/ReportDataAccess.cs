using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DataAccess
{
    public class ReportDataAccess
    {
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        string sql;
        string constr;

        private void SetSqlConnection()
        {
            constr = System.Configuration.ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            sqlcon = new SqlConnection();
            sqlcon.ConnectionString = constr;
            sqlcon.Open();
        }
        public DataTable GetTable( string tableName)
        {
            DataTable dt;
            dt = new DataTable();
            sqlcmd = new SqlCommand();
            sql = "SELECT * FROM " + tableName;
            SetSqlConnection();
            sqlcmd.CommandText = sql;
            sqlcmd.Connection = sqlcon;
            
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
            //sqlda.SelectCommand = sqlcmd;
            sqlda.Fill(dt);
            CloseSqlConnection();
            return dt;
        }

        public DataTable GetTable (string tableName, string keyName, string value)
        {
            DataTable dt;
            dt = new DataTable();
            sqlcmd = new SqlCommand();
            SetSqlConnection();
            sql = "SELECT * FROM " + tableName + " WHERE " + keyName +" = '" + value +"'";
            sqlcmd.CommandText = sql;
            sqlcmd.Connection = sqlcon;
            
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
            //sqlda.SelectCommand = sqlcmd;
            sqlda.Fill(dt);
            CloseSqlConnection();
            return dt;
        }

        public DataTable GetTable(string tableName, string keyName, int value)
        {
            DataTable dt;
            dt = new DataTable();
            sqlcmd = new SqlCommand();
            SetSqlConnection();
            sql = "SELECT * FROM " + tableName + " WHERE " + keyName + " = " + value;
            sqlcmd.CommandText = sql;
            sqlcmd.Connection = sqlcon;
            
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
            //sqlda.SelectCommand = sqlcmd;
            sqlda.Fill(dt);
            CloseSqlConnection();
            return dt;
        }

        public DataTable GetTable ( SqlCommand cmd )
        {
            DataTable dt;
            dt = new DataTable();
            sqlcmd = new SqlCommand();
            SetSqlConnection();
            sqlcmd = cmd;
            
            sqlcmd.Connection = sqlcon;
            
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
            //sqlda.SelectCommand = ;
            sqlda.Fill(dt);
            CloseSqlConnection();
            return dt;
        }

        public void ExecuteCmd ( SqlCommand cmd)
        {
            sqlcmd = new SqlCommand();
            sqlcmd = cmd;
            SetSqlConnection();
            //sqlcmd.CommandText = sql;
            sqlcmd.Connection = sqlcon;
            
            sqlcmd.ExecuteNonQuery();
            CloseSqlConnection();
        }
        private void CloseSqlConnection()
        {
            sqlcon.Close();
        }
    }
}
