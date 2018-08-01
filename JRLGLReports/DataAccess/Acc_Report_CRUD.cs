using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class Acc_Report_CRUD
    {
        string sql;
        SqlCommand cmd;
        ReportDataAccess db;
        /// <summary>
        /// This method is used to save Reportformat definition to the table ReportFormat
        /// The form will set the initial setting up based upon the menu.
        /// </summary>
        /// <param name="obj"></param>
        public ReportFormat SaveFormat( ReportFormat obj)
        {
            db = new ReportDataAccess();
            //DataTable dt = db.GetTable("gl_ReportFomat", "ReportFormatName", obj.ReportFormatName);

            if (obj.id==null)
            {
                //Do Insert here to the table ReportFormat
                sql = "INSERT INTO gl_ReportFomat ( ReportFormatName,ReportCategory,	CreatedDate,	CreatedBy)" +
                    " VALUES (@ReportFormatName,@ReportCategory,	@CreatedDate,	@CreatedBy)";
                cmd = new SqlCommand();
                cmd.CommandText = sql;
            }
            else
            {
                //Do updation to the table ReportFormat
                sql = "UPDATE gl_ReportFomat SET ( ReportFormatName = @ReportFormatName, ReportCategory=@ReportCategory )" +
                    " WHERE ReportFormatName = @ReportFormatName";
                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = obj.id;
            }
            cmd.Parameters.Add(new SqlParameter("@ReportFormatName", System.Data.SqlDbType.NVarChar)).Value = obj.ReportFormatName;
            cmd.Parameters.Add(new SqlParameter("@ReportCategory", System.Data.SqlDbType.NVarChar)).Value = obj.ReportCategory;
            cmd.Parameters.Add(new SqlParameter("@CreatedDate", System.Data.SqlDbType.DateTime)).Value = obj.CreatedDate;
            cmd.Parameters.Add(new SqlParameter("@CreatedBy", System.Data.SqlDbType.NVarChar)).Value = obj.CreatedBy;
            db.ExecuteCmd(cmd);
            int formatId = -1;
            DataTable fdt = db.GetTable("gl_ReportFomat", "ReportFormatName", obj.ReportFormatName);
            if (fdt.Rows.Count > 0)
                formatId =int.Parse( fdt.Rows[0]["id"].ToString());
            obj.id = formatId;
            return obj;
        }
        /// <summary>
        /// The method will save the header text to the ACC-REPORT table. The AccountCode will always be filled with spaces
        /// in order to keep the hierachy of the report.
        /// </summary>
        /// <param name="obj"></param>
        public Acc_Report SaveHead( Acc_Report obj)
        {
            db = new ReportDataAccess();
            if (obj.id == null)
            {
                // Do Insert
                sql = "INSERT INTO [ACC-REPORT] ( AccountCode,	ParentCode,	AccType,	LevelofDisplay	,AccountCat	,AccountDesc,	AccountDesc2	,ReportHead) " +
                     " VALUES (@AccountCode	,@ParentCode,@AccType,	@LevelofDisplay,	@AccountCat,	@AccountDesc,	@AccountDesc2,	@ReportHead)";

                cmd = new SqlCommand();
                cmd.CommandText = sql;
                
            }
            else
            {
                //Do update
                sql = " UPDATE [ACC-REPORT] SET AccountCode = @AccountCode, ParentCode=@ParentCode, AccType=@AccType, " +
                    " LevelofDisplay=@LevelofDisplay, AccountCat=@AccountCat, AccountDesc=@AccountDesc, AccountDesc2=@AccountDesc2, ReportHead=@ReportHead " +
                    " WHERE id = @id";
                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = obj.id;
            }
            cmd.Parameters.Add(new SqlParameter("@AccountCode", System.Data.SqlDbType.NVarChar)).Value = obj.AccountCode;
            cmd.Parameters.Add(new SqlParameter("@ParentCode", System.Data.SqlDbType.NVarChar)).Value = obj.ParentCode;
            cmd.Parameters.Add(new SqlParameter("@AccType", System.Data.SqlDbType.NVarChar)).Value = obj.AccType;
            cmd.Parameters.Add(new SqlParameter("@LevelofDisplay", System.Data.SqlDbType.Int)).Value = obj.LevelofDisplay;
            cmd.Parameters.Add(new SqlParameter("@AccountCat", System.Data.SqlDbType.NVarChar)).Value = obj.AccountCat;
            cmd.Parameters.Add(new SqlParameter("@AccountDesc", System.Data.SqlDbType.NVarChar)).Value = obj.AccountDesc;
            cmd.Parameters.Add(new SqlParameter("@AccountDesc2", System.Data.SqlDbType.NVarChar)).Value = obj.AccountDesc2;
            cmd.Parameters.Add(new SqlParameter("@ReportHead", System.Data.SqlDbType.Int)).Value = obj.ReportHead;
            db.ExecuteCmd(cmd);
            int accid = -1;
            DataTable fdt = db.GetTable(" [ACC-REPORT]", "AccountDesc", obj.AccountDesc);
            if (fdt.Rows.Count > 0)
                accid = int.Parse(fdt.Rows[0]["id"].ToString());
            obj.id = accid;
            return obj;
        }
        public ReportFormatDetail SaveFormatDetail( ReportFormatDetail obj)
        {
            db = new ReportDataAccess();
            if (obj.id == null)
            {
                //Do Insert ReportFormatDeatil
                sql = "INSERT INTO gl_ReportFormatDetail (FormatId,	AccountId,	ParentId	,DisplayLevel,PrintOrder)" +
                " VALUES (@FormatId,	@AccountId	,@ParentId	,@DisplayLevel,@PrintOrder)";
                cmd = new SqlCommand();
                cmd.CommandText = sql;
            }
            else
            {
                // Do Updating ReportFormatDeatil
                sql = "UPDATE gl_ReportFormatDetail SET FormatId = @FormatId, AccountId=@AccountId, ParentId=@ParentId, DisplayLevel=@DisplayLevel" +
                ", PrintOrder = @PrintOrder WHERE id =@id";
                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int)).Value = obj.id;

            }
            cmd.Parameters.Add(new SqlParameter("@FormatId", System.Data.SqlDbType.Int)).Value = obj.FormatId;
            cmd.Parameters.Add(new SqlParameter("@AccountId", System.Data.SqlDbType.Int)).Value = obj.AccountId;
            cmd.Parameters.Add(new SqlParameter("@ParentId", System.Data.SqlDbType.Int)).Value = obj.ParentId;
            cmd.Parameters.Add(new SqlParameter("@DisplayLevel", System.Data.SqlDbType.Int)).Value = obj.DisplayLevel;
            cmd.Parameters.Add(new SqlParameter("@PrintOrder", System.Data.SqlDbType.Int)).Value = obj.PrintOrder;
            db.ExecuteCmd(cmd);
            obj = GetFormatDetail(obj.AccountId, obj.FormatId);
            return obj;
        }
        public ReportFormat GetExisitngFormat( string formatName)
        {
            ReportFormat dbobj = new ReportFormat();
            DataTable fdt = db.GetTable("gl_ReportFomat", "ReportFormatName", formatName);
            if (fdt.Rows.Count > 0)
            {
                dbobj.id = int.Parse(fdt.Rows[0]["id"].ToString());
                dbobj.ReportCategory = fdt.Rows[0]["ReportCategory"].ToString();
                dbobj.ReportFormatName = fdt.Rows[0]["ReportFormatName"].ToString();
                dbobj.ReportCategory = fdt.Rows[0]["ReportCategory"].ToString();
                dbobj.CreatedDate = DateTime.Parse(fdt.Rows[0]["CreatedDate"].ToString());
                dbobj.CreatedBy = fdt.Rows[0]["CreatedBy"].ToString();

            }
            return dbobj;
        }

        public ReportFormatDetail GetFormatDetail( int? accountid, int? formatid)
        {
            ReportFormatDetail dbObj = new ReportFormatDetail();
            SqlCommand cmd = new SqlCommand();
            string sql = "Select * From gl_ReportFormatDetail Where AccountId = @accountId AND FormatId=@formatid";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@accountId", SqlDbType.Int)).Value = accountid;
            cmd.Parameters.Add(new SqlParameter("@formatid", SqlDbType.Int)).Value = formatid;
            db = new ReportDataAccess();
            DataTable dt = db.GetTable(cmd);
            if (dt.Rows.Count == 1)
            {
                dbObj.AccountId = int.Parse(dt.Rows[0]["accountid"].ToString());
                dbObj.DisplayLevel = int.Parse(dt.Rows[0]["DisplayLevel"].ToString());
                dbObj.FormatId = int.Parse(dt.Rows[0]["FormatId"].ToString());
                dbObj.id = int.Parse(dt.Rows[0]["id"].ToString());
                dbObj.ParentId = int.Parse(dt.Rows[0]["ParentId"].ToString());
                dbObj.PrintOrder = int.Parse(dt.Rows[0]["PrintOrder"].ToString());
            }
            return dbObj;
        }

        public DataTable GetMasterAccounts()
        {
            DataTable dt;
            SqlCommand cmd = new SqlCommand();
            db = new ReportDataAccess();
            string sql = "select * from viewAccountsRelation where AccountCode = ParentCode";
            cmd.CommandText = sql;
            dt = db.GetTable(cmd);
            return dt;
        }
        public DataTable GetDetailAcoounts()
        {
            DataTable dt;
            SqlCommand cmd = new SqlCommand();
            string sql = "select * from viewAccountsRelation where AccountCode <> ParentCode";
            db = new ReportDataAccess();
            cmd.CommandText = sql;
            dt = db.GetTable(cmd);
            return dt;
        }

        public DataTable GetReportData (SqlCommand sqlcmd)
        {
            db = new ReportDataAccess();
            DataTable dtret = new DataTable();
            dtret = db.GetTable(sqlcmd);
            return dtret;
        }
    }
}
