using System;
using System.Data;
using System.Data.OleDb;
using System.Web.Configuration;

/// <summary>
/// Summary description for DemoClass
/// </summary>
namespace DemoClass
{
    public class Advertisments
    {
        public int AdvertismentId { get; set; }
        public string Subject { get; set; }
        public string ImageFile { get; set; }
        public string Url { get; set; }
        public string AlternateText { get; set; }
        public string StartDateActive { get; set; }
        public string EndDateActive { get; set; }

        string strSql;

        public void Delete(string pDatabaseName)
        {
            try
            {
                OleDbConnection conn = null;
                string _connectionString = WebConfigurationManager.ConnectionStrings[pDatabaseName].ConnectionString;
                OleDbCommand cmd = new OleDbCommand();
                conn = new OleDbConnection(_connectionString);
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM ADVERTISMENTS " +
                                  " WHERE ADVERTISMENT_ID = @ADVERTISMENT_ID ";

                // Create parameters for cmd
                cmd.Parameters.AddWithValue("@ADVERTISMENT_ID", AdvertismentId);

                using (conn)
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Advertisments Delete Failed", ex);
            }
        }

        public Advertisments GetData(string pDatabaseName, int pAdvertismentId)
        {
            DataTable _dt = new DataTable();
            DataRow[] dr = null;
            Advertisments obj = new Advertisments();

            try
            {
                strSql = "SELECT ADVERTISMENT_ID " +
                         "      ,SUBJECT " +
                         "      ,IMAGE_FILE " +
                         "      ,URL " +
                         "      ,ALTERNATE_TEXT " +
                         "      ,FORMAT(START_DATE_ACTIVE,'mm/dd/yyyy') AS START_DATE_ACTIVE " +
                         "      ,FORMAT(END_DATE_ACTIVE,'mm/dd/yyyy') AS END_DATE_ACTIVE " +
                         "  FROM ADVERTISMENTS " +
                         " WHERE ADVERTISMENT_ID       = " + pAdvertismentId.ToString();

                _dt = Sql.GetDataTable(pDatabaseName, strSql);

                if (_dt.Rows.Count == 1)
                {
                    dr = _dt.Select("");

                    obj.AdvertismentId = dr[0]["ADVERTISMENT_ID"] != DBNull.Value ? Convert.ToInt32(dr[0]["ADVERTISMENT_ID"]) : 0;
                    obj.Subject = dr[0]["SUBJECT"] != DBNull.Value ? dr[0]["SUBJECT"].ToString().Trim() : "";
                    obj.ImageFile = dr[0]["IMAGE_FILE"] != DBNull.Value ? dr[0]["IMAGE_FILE"].ToString().Trim() : "";
                    obj.Url = dr[0]["URL"] != DBNull.Value ? dr[0]["URL"].ToString().Trim() : "";
                    obj.AlternateText = dr[0]["ALTERNATE_TEXT"] != DBNull.Value ? dr[0]["ALTERNATE_TEXT"].ToString().Trim() : "";
                    obj.StartDateActive = dr[0]["START_DATE_ACTIVE"] != DBNull.Value ? dr[0]["START_DATE_ACTIVE"].ToString() : "";
                    obj.EndDateActive = dr[0]["END_DATE_ACTIVE"] != DBNull.Value ? dr[0]["END_DATE_ACTIVE"].ToString() : "";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Advertisments GetData Failed", ex);
            }

            return obj;
        }

        public DataTable GetList(string pDatabaseName)
        {
            DataTable _dt = new DataTable();

            try
            {
                strSql = "SELECT ADVERTISMENT_ID " +
                         "      ,SUBJECT " +
                         "      ,IMAGE_FILE " +
                         "      ,URL " +
                         "      ,ALTERNATE_TEXT " +
                         "      ,START_DATE_ACTIVE " +
                         "      ,END_DATE_ACTIVE " +
                         "  FROM ADVERTISMENTS ";

                _dt = Sql.GetDataTable(pDatabaseName, strSql);
            }
            catch (Exception ex)
            {
                throw new Exception("Advertisments GetList Failed", ex);
            }

            return _dt;
        }

        public int Insert(string pDatabaseName)
        {
            OleDbConnection conn = null;
            int intId = 0;

            try
            {
                string _connectionString = WebConfigurationManager.ConnectionStrings[pDatabaseName].ConnectionString;
                OleDbCommand cmd = new OleDbCommand();
                conn = new OleDbConnection(_connectionString);
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO ADVERTISMENTS (" +
                                  "       SUBJECT " +
                                  "      ,IMAGE_FILE " +
                                  "      ,URL " +
                                  "      ,ALTERNATE_TEXT " +
                                  "      ,START_DATE_ACTIVE " +
                                  "      ,END_DATE_ACTIVE " +
                                  ") VALUES (" +
                                  "       @SUBJECT " +
                                  "      ,@IMAGE_FILE " +
                                  "      ,@URL " +
                                  "      ,@ALTERNATE_TEXT " +
                                  "      ,@START_DATE_ACTIVE " +
                                  "      ,@END_DATE_ACTIVE " +
                                  "      ) ";

                // Create parameters for cmd
                cmd.Parameters.AddWithValue("@SUBJECT", Subject);
                cmd.Parameters.AddWithValue("@IMAGE_FILE", ImageFile);
                cmd.Parameters.AddWithValue("@URL", Url);
                cmd.Parameters.AddWithValue("@ALTERNATE_TEXT", AlternateText);
                cmd.Parameters.AddWithValue("@START_DATE_ACTIVE", StartDateActive);
                if (EndDateActive == "")
                    cmd.Parameters.AddWithValue("@END_DATE_ACTIVE", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@END_DATE_ACTIVE", EndDateActive);

                using (conn)
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Select @@Identity";
                    intId = (int)cmd.ExecuteScalar();
                    AdvertismentId = intId;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Advertisments Insert Failed", ex);
            }

            return intId;
        }

        public void Update(string pDatabaseName)
        {
            try
            {
                OleDbConnection conn = null;
                string _connectionString = WebConfigurationManager.ConnectionStrings[pDatabaseName].ConnectionString;
                OleDbCommand cmd = new OleDbCommand();
                conn = new OleDbConnection(_connectionString);
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE ADVERTISMENTS " +
                                  "   SET SUBJECT           = @SUBJECT " +
                                  "      ,IMAGE_FILE        = @IMAGE_FILE " +
                                  "      ,URL               = @URL " +
                                  "      ,ALTERNATE_TEXT    = @ALTERNATE_TEXT " +
                                  "      ,START_DATE_ACTIVE = @START_DATE_ACTIVE " +
                                  "      ,END_DATE_ACTIVE   = @END_DATE_ACTIVE " +
                                  " WHERE ADVERTISMENT_ID   = @ADVERTISMENT_ID ";

                // Create parameters for cmd
                cmd.Parameters.AddWithValue("@SUBJECT", Subject);
                cmd.Parameters.AddWithValue("@IMAGE_FILE", ImageFile);
                cmd.Parameters.AddWithValue("@URL", Url);
                cmd.Parameters.AddWithValue("@ALTERNATE_TEXT", AlternateText);
                cmd.Parameters.AddWithValue("@START_DATE_ACTIVE", StartDateActive);
                if (EndDateActive == "")
                    cmd.Parameters.AddWithValue("@END_DATE_ACTIVE", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@END_DATE_ACTIVE", EndDateActive);

                cmd.Parameters.AddWithValue("@ADVERTISMENT_ID", AdvertismentId);

                using (conn)
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Advertisments Update Failed", ex);
            }
        }
    }
}