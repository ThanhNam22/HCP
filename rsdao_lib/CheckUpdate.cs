using adao_lib;
using rsbo_lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace rsdao_lib
{
    public class CheckUpdate : BASE_DAO
    {
        public CheckUpdate() : base()
        {
        }
        public DataTable getDataTable(string sessionid = null)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sessionid", sessionid);         
            DataTable ds = new DataTable();
            if (sessionid == null)
                ds = executeReaderDataTable("SELECT * FROM [CHECK]");
            else
                ds = executeReaderDataTable("SELECT  * FROM [CHECK] WHERE [SESSION_ID] = @sessionid", parameters);
            return ds;
        }


        public void insert(Check rs)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", rs.id);
            parameters.Add("@date", rs.date);
            parameters.Add("@sessionid", rs.session_id);
            parameters.Add("@endtime", rs.end_time);
            parameters.Add("@status", rs.status);



            executeNonQuery("INSERT INTO [CHECK]([ID],[DATE], [SESSION_ID], [END_TIME], " +
                    "[STATUS])" +
                    " VALUES(@id,@date, @sessionid, @endtime, @status)", parameters);
        }

        public void upcheckid(Check rs)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", rs.id);
            parameters.Add("@date", rs.date);
            parameters.Add("@sessionid", rs.session_id);
            parameters.Add("@endtime", rs.end_time);
            parameters.Add("@status", rs.status);


            executeNonQuery("UPcheckid [CHECK] SET [ID] = @id, [DATE] = @date, [SESSION_ID] = @sessionid" +
                ", [END_TIME] = @endtime, [STATUS] = @status " +
                "WHERE [ID] = @id", parameters);
        }

        public void delete(string sessionid)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sessionid", sessionid);
          

            executeNonQuery("DELETE FROM [CHECK] WHERE [SESSION_ID] = @sessionid", parameters);
        }

        public DataTable getCheck(string sessionid)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sessionid", sessionid);
           
            DataTable ds = new DataTable();
            ds = executeReaderDataTable("SELECT * FROM [CHECK] WHERE [SESSION_ID] = @sessionid", parameters);
            return ds;
        }

    }
}
