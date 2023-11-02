using adao_lib;
using rsbo_lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace rsdao_lib
{
    public class AlertUpdate : BASE_DAO
    {
        public AlertUpdate() : base()
        {
        }
        public DataTable getDataTable(string profileid = null, string ruleid = null)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@profileid", profileid);
            parameters.Add("@ruleid", ruleid);
            DataTable ds = new DataTable();
            if (profileid == null)
                ds = executeReaderDataTable("SELECT * FROM [ALERT]");
            else
                ds = executeReaderDataTable("SELECT  * FROM [ALERT] WHERE [profile_ID] = @profileid AND [RULE_ID] = @ruleid", parameters);
            return ds;
        }

        public DataTable getDataTable_V(string sessionid)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sessionid", sessionid);
            DataTable ds = new DataTable();            
            ds = executeReaderDataTable("SELECT  * FROM [V_ALERT] WHERE [session_ID] = @sessionid", parameters);
            return ds;
        }
        public DataTable getDataTableResion_V(string sessionid, string profileid)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sessionid", sessionid);
            parameters.Add("@profileid", profileid);
            DataTable ds = new DataTable();
            ds = executeReaderDataTable("SELECT  * FROM [V_RESION] WHERE [session_ID] = @sessionid AND [PROFILE_ID] = @profileid", parameters);
            return ds;
        }
        public void insert(Alert rs)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@profileid", rs.profile_ID);
            parameters.Add("@ruleid", rs.rule_id);
            parameters.Add("@checkid", rs.check_id);
            parameters.Add("@solved", rs.solved);          
            parameters.Add("@status", rs.status);
          


            executeNonQuery("INSERT INTO [ALERT]([PROFILE_ID],[RULE_ID], [checkid], [SOLVED], " +
                    "[STATUS])" +
                    " VALUES(@profileid,@ruleid, @checkid, @solved, @status)", parameters);
        }

        public void upcheckid(Alert rs)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@profileid", rs.profile_ID);
            parameters.Add("@ruleid", rs.rule_id);
            parameters.Add("@checkid", rs.check_id);
            parameters.Add("@solved", rs.solved);
            parameters.Add("@status", rs.status);
           

            executeNonQuery("UPcheckid [ALERT] SET [PROFILE_ID] = @profileid, [RULE_ID] = @ruleid, [SOLVED] = @solved" +               
                ", [checkid] = @checkid, [STATUS] = @status " +
                "WHERE [PROFILE_ID] = @profileid AND [RULE_ID] = @ruleid", parameters);
        }

        public void delete(string profileid, string ruleid)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@profileid", profileid);
            parameters.Add("@ruleid", ruleid);

            executeNonQuery("DELETE FROM [ALERT] WHERE [PROFILE_ID] = @profileid AND [RULE_ID] = @ruleid", parameters);
        }

        public DataTable getMaterial(string profileid, string ruleid)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@profileid", profileid);
            parameters.Add("@ruleid", ruleid);
            DataTable ds = new DataTable();
            ds = executeReaderDataTable("SELECT * FROM [ALERT] WHERE [PROFILE_ID] = @profileid AND [RULE_ID] = @ruleid", parameters);
            return ds;
        }
    }
}
