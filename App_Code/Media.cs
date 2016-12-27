using System;
using System.Data;
using System.Data.OleDb;
using System.Web.Configuration;

/// <summary>
/// Summary description for DemoClass
/// </summary>
namespace DemoClass
{
    public class Media
    {
        public int MediaId { get; set; }
        public string MediaDate { get; set; }
        public string Subject { get; set; }
        public string CategoryCode { get; set; }
        public string Category { get; set; }
        public string UploadedBy { get; set; }
        public string ImageFile { get; set; }
        public string AudioFile { get; set; }
        public string VideoFile { get; set; }
        public string YoutubeLink { get; set; }
        public string Summary { get; set; }

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
                cmd.CommandText = "DELETE FROM MEDIA " +
                                  " WHERE MEDIA_ID = @MEDIA_ID ";

                // Create parameters for cmd
                cmd.Parameters.AddWithValue("@MEDIA_ID", MediaId);

                using (conn)
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Media Delete Failed", ex);
            }
        }

        public Media GetData(string pDatabaseName, int pMediaId)
        {
            DataTable _dt = new DataTable();
            DataRow[] dr = null;
            Media obj = new Media();

            try
            {
                strSql = "SELECT M.MEDIA_ID " +
                         "      ,FORMAT(M.MEDIA_DATE,'mm/dd/yyyy') AS MEDIA_DATE " +
                         "      ,M.SUBJECT " +
                         "      ,M.CATEGORY_CODE " +
                         "      ,L.MEANING AS CATEGORY " +
                         "      ,M.UPLOADED_BY " +
                         "      ,M.IMAGE_FILE " +
                         "      ,M.AUDIO_FILE " +
                         "      ,M.VIDEO_FILE " +
                         "      ,M.YOUTUBE_LINK " +
                         "      ,M.SUMMARY " +
                         "  FROM MEDIA M " +
                         "      ,LOOKUP_VALUES L " +
                         " WHERE M.MEDIA_ID         = " + pMediaId.ToString() +
                         "   AND L.LOOKUP_TYPE_CODE = 'MEDIA_CATEGORY' " +
                         "   AND L.LOOKUP_CODE      = M.CATEGORY_CODE ";

                _dt = Sql.GetDataTable(pDatabaseName, strSql);

                if (_dt.Rows.Count == 1)
                {
                    dr = _dt.Select("");

                    obj.MediaId = dr[0]["MEDIA_ID"] != DBNull.Value ? Convert.ToInt32(dr[0]["MEDIA_ID"]) : 0;
                    obj.MediaDate = dr[0]["MEDIA_DATE"] != DBNull.Value ? dr[0]["MEDIA_DATE"].ToString() : "";
                    obj.Subject = dr[0]["SUBJECT"] != DBNull.Value ? dr[0]["SUBJECT"].ToString().Trim() : "";
                    obj.CategoryCode = dr[0]["CATEGORY_CODE"] != DBNull.Value ? dr[0]["CATEGORY_CODE"].ToString().Trim() : "";
                    obj.Category = dr[0]["CATEGORY"] != DBNull.Value ? dr[0]["CATEGORY"].ToString().Trim() : "";
                    obj.UploadedBy = dr[0]["UPLOADED_BY"] != DBNull.Value ? dr[0]["UPLOADED_BY"].ToString().Trim() : "";
                    obj.ImageFile = dr[0]["IMAGE_FILE"] != DBNull.Value ? dr[0]["IMAGE_FILE"].ToString().Trim() : "";
                    obj.AudioFile = dr[0]["AUDIO_FILE"] != DBNull.Value ? dr[0]["AUDIO_FILE"].ToString() : "";
                    obj.VideoFile = dr[0]["VIDEO_FILE"] != DBNull.Value ? dr[0]["VIDEO_FILE"].ToString() : "";
                    obj.YoutubeLink = dr[0]["YOUTUBE_LINK"] != DBNull.Value ? dr[0]["YOUTUBE_LINK"].ToString() : "";
                    obj.Summary = dr[0]["SUMMARY"] != DBNull.Value ? dr[0]["SUMMARY"].ToString() : "";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Media GetData Failed", ex);
            }

            return obj;
        }

        public DataTable GetList(string pDatabaseName)
        {
            DataTable _dt = new DataTable();

            try
            {
                strSql = "SELECT M.MEDIA_ID " +
                         "      ,M.MEDIA_DATE " +
                         "      ,M.SUBJECT " +
                         "      ,M.CATEGORY_CODE " +
                         "      ,L.MEANING AS CATEGORY " +
                         "      ,M.UPLOADED_BY " +
                         "      ,M.IMAGE_FILE " +
                         "      ,M.AUDIO_FILE " +
                         "      ,M.VIDEO_FILE " +
                         "      ,M.YOUTUBE_LINK " +
                         "      ,M.SUMMARY " +
                         "  FROM MEDIA M " +
                         "      ,LOOKUP_VALUES L " +
                         " WHERE L.LOOKUP_TYPE_CODE = 'MEDIA_CATEGORY' " +
                         "   AND L.LOOKUP_CODE      = M.CATEGORY_CODE ";

                _dt = Sql.GetDataTable(pDatabaseName, strSql);
            }
            catch (Exception ex)
            {
                throw new Exception("Media GetList Failed", ex);
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
                cmd.CommandText = "INSERT INTO MEDIA (" +
                                  "       MEDIA_DATE " +
                                  "      ,SUBJECT " +
                                  "      ,CATEGORY_CODE " +
                                  "      ,UPLOADED_BY " +
                                  "      ,IMAGE_FILE " +
                                  "      ,AUDIO_FILE " +
                                  "      ,VIDEO_FILE " +
                                  "      ,YOUTUBE_LINK " +
                                  "      ,SUMMARY " +
                                  ") VALUES (" +
                                  "       @MEDIA_DATE " +
                                  "      ,@SUBJECT " +
                                  "      ,@CATEGORY_CODE " +
                                  "      ,@UPLOADED_BY " +
                                  "      ,@IMAGE_FILE " +
                                  "      ,@AUDIO_FILE " +
                                  "      ,@VIDEO_FILE " +
                                  "      ,@YOUTUBE_LINK " +
                                  "      ,@SUMMARY " +
                                  "      ) ";

                // Create parameters for cmd
                cmd.Parameters.AddWithValue("@MEDIA_DATE", MediaDate);
                cmd.Parameters.AddWithValue("@SUBJECT", Subject);
                cmd.Parameters.AddWithValue("@CATEGORY_CODE", CategoryCode);
                cmd.Parameters.AddWithValue("@UPLOADED_BY", UploadedBy);
                cmd.Parameters.AddWithValue("@IMAGE_FILE", ImageFile);
                cmd.Parameters.AddWithValue("@AUDIO_FILE", AudioFile);
                cmd.Parameters.AddWithValue("@VIDEO_FILE", VideoFile);
                cmd.Parameters.AddWithValue("@YOUTUBE_LINK", YoutubeLink);
                cmd.Parameters.AddWithValue("@SUMMARY", Summary);

                using (conn)
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Select @@Identity";
                    intId = (int)cmd.ExecuteScalar();
                    MediaId = intId;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Media Insert Failed", ex);
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
                cmd.CommandText = "UPDATE MEDIA " +
                                  "   SET MEDIA_DATE    = @MEDIA_DATE " +
                                  "      ,SUBJECT       = @SUBJECT " +
                                  "      ,CATEGORY_CODE = @CATEGORY_CODE " +
                                  "      ,UPLOADED_BY   = @UPLOADED_BY " +
                                  "      ,IMAGE_FILE    = @IMAGE_FILE " +
                                  "      ,AUDIO_FILE    = @AUDIO_FILE " +
                                  "      ,VIDEO_FILE    = @VIDEO_FILE " +
                                  "      ,YOUTUBE_LINK  = @YOUTUBE_LINK " +
                                  "      ,SUMMARY       = @SUMMARY " +
                                  " WHERE MEDIA_ID      = @MEDIA_ID ";

                // Create parameters for cmd
                cmd.Parameters.AddWithValue("@MEDIA_DATE", MediaDate);
                cmd.Parameters.AddWithValue("@SUBJECT", Subject);
                cmd.Parameters.AddWithValue("@CATEGORY_CODE", CategoryCode);
                cmd.Parameters.AddWithValue("@UPLOADED_BY", UploadedBy);
                cmd.Parameters.AddWithValue("@IMAGE_FILE", ImageFile);
                cmd.Parameters.AddWithValue("@AUDIO_FILE", AudioFile);
                cmd.Parameters.AddWithValue("@VIDEO_FILE", VideoFile);
                cmd.Parameters.AddWithValue("@YOUTUBE_LINK", YoutubeLink);
                cmd.Parameters.AddWithValue("@SUMMARY", Summary);
                cmd.Parameters.AddWithValue("@MEDIA_ID", MediaId);

                using (conn)
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Media Update Failed", ex);
            }
        }
    }
}