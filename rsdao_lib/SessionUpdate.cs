using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using abo_lib;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace adao_lib
{
    public class SessionUpdate : BASE_DAO
    {
        public SessionUpdate()
            : base()
        {
        }

        public List<Session> getListSession()
        {
            List<Session> lstSession = new List<Session>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            SqlDataReader reader = executeReader("SELECT * FROM [session] ORDER BY [date] DESC");
            while (reader.Read())
            {
                Session cs = new Session();
                cs.ID = reader.GetString(reader.GetOrdinal("ID"));
                cs.date = reader.GetDateTime(reader.GetOrdinal("date"));
                cs.status = reader.GetInt32(reader.GetOrdinal("status"));
                lstSession.Add(cs);
            }
            reader.Close();
            return lstSession;
        }

        public Session getSession(string ssID)
        {
            Session ss = new Session();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", ssID);
            SqlDataReader reader = executeReader("SELECT * FROM [session] WHERE [ID] = @ID", parameters);
            if (reader.HasRows)
            {
                reader.Read();
                ss.ID = reader.GetString(reader.GetOrdinal("ID"));
                ss.date = reader.GetDateTime(reader.GetOrdinal("date"));
                ss.status = reader.GetInt32(reader.GetOrdinal("status"));
            }
            else
            {
                ss.ID = "";
                ss.date = DateTime.Today;
                ss.status = 0;
            }
                
            reader.Close();
            return ss;
        }


        public void insertSession(Session rs)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", rs.ID);
            parameters.Add("@date", rs.date);           
            parameters.Add("@status", rs.status);
            executeNonQuery("INSERT INTO [SESSION]([ID],[date], [status]) " +
                "VALUES(@ID,@date,@status)", parameters);
        }

        public void updateSession(Session rs)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", rs.ID);
            parameters.Add("@date", rs.date);           
            parameters.Add("@status", rs.status);
            executeNonQuery("UPDATE [SESSION] SET [ID] = @ID, [date] = @date, [status] = @status WHERE [ID] = @ID", parameters);
        }
        public void deleteSetting(string ID)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", ID);
            executeNonQuery("DELETE [SESSION] WHERE [ID] = @ID ", parameters);
        }

        public Session SaveSession()
        {
            Session ss = new Session();
            SessionUpdate ssu = new SessionUpdate();
            ss.ID = DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString();
            ss.date = DateTime.Today;
            
            Session getss = ssu.getSession(ss.ID);
            if (getss.ID == "")
            {
                ss.status = 0;
                ssu.insertSession(ss);
            }              
            else
            {
                ss.status = getss.status + 1;
                ssu.updateSession(ss);
            }
               
            return ss;
        }
    }
}
