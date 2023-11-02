using abo_lib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using adao_lib;
using rsbo_lib;

namespace rsdao_lib
{
    public class ServiceUpdate : BASE_DAO
    {
        public ServiceUpdate() : base()
        {
        }

        public DataTable getDataTable(string patientid = null, string sessionid=null)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", patientid);
            parameters.Add("@sessionid", sessionid);
            DataTable ds = new DataTable();
            if (patientid == null)
                ds = executeReaderDataTable("SELECT [DATE], [SERVICE_CODE] FROM [SERVICE]");
            else
                ds = executeReaderDataTable("SELECT  [DATE], [SERVICE_CODE] FROM [SERVICE] WHERE [patient_ID] = @patientid AND [SESSION_ID] = @sessionid", parameters);
            return ds;
        }

        public decimal patient_ID { get; set; }
        public string service_code { get; set; }
        public string service_name { get; set; }
        public decimal service_type { get; set; }
        public decimal service_unit { get; set; }
        public Boolean is_use_service_hein { get; set; }
        public Boolean is_multi_request { get; set; }
        public Boolean status { get; set; }
        public DateTime date { get; set; }
        public string session_id { get; set; }
        public void insert(Service rs)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", rs.patient_ID);
            parameters.Add("@servicecode", rs.service_code);
            parameters.Add("@servicename", rs.service_name);
            parameters.Add("@servicetype", rs.service_type);
            parameters.Add("@serviceunit", rs.service_unit);
            parameters.Add("@servicehein", rs.is_use_service_hein);
            parameters.Add("@multirequest", rs.is_multi_request);
            parameters.Add("@date", rs.date);
            parameters.Add("@status", rs.status);
            parameters.Add("@sessionid", rs.session_id);
            

        executeNonQuery("INSERT INTO [SERVICE]([patient_ID],[SERVICE_CODE], [SERVICE_NAME], [SERVICE_TYPE], " +
                "[SERVICE_UNIT], [IS_SERVICE_HEIN], [IS_MULTI_REQUEST], [DATE], [STATUS], [SESSION_ID])" +
                " VALUES(@patientid,@servicecode, @servicename, @servicetype, @serviceunit, @servicehein, @multirequest, @date, @status, @sessionid)", parameters);
        }

        public void update(Service rs)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", rs.patient_ID);
            parameters.Add("@servicecode", rs.service_code);
            parameters.Add("@servicename", rs.service_name);
            parameters.Add("@servicetype", rs.service_type);
            parameters.Add("@serviceunit", rs.service_unit);
            parameters.Add("@servicehein", rs.is_use_service_hein);
            parameters.Add("@multirequest", rs.is_multi_request);
            parameters.Add("@date", rs.date);
            parameters.Add("@status", rs.status);
            parameters.Add("@sessionid", rs.session_id);

            executeNonQuery("UPDATE [SERVICE] SET [patient_ID] = @patientid, [SERVICE_CODE] = @servicecode, [SERVICE_NAME] = @servicename" +
                ", [SERVICE_TYPE] = @servicetype, [SERVICE_UNIT] = @serviceunit, [IS_USE_SERVICE_HEIN] = @servicehein, [IS_MULTI_REQUEST = @miltirequest" +
                ", [DATE] = @date, [STATUS] = @status, [SESSION_ID] = @sessionid " +
                "WHERE [patient_ID] = @patientid AND [SESSION_ID] = @sessionid", parameters);
        }

        public void delete(string patientid, string sessionid)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", patientid);
            parameters.Add("@sessionid", sessionid);

            executeNonQuery("DELETE FROM [SERVICE] WHERE [patient_ID] = @patientid AND [SESSION_ID] = @sessionid", parameters);
        }

        public DataTable getSERVICE(string patientid, string sessionid)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", patientid);
            parameters.Add("@sessionid", sessionid);
            DataTable ds = new DataTable();
            ds = executeReaderDataTable("SELECT  SERVICE_CODE, SERVICE_NAME FROM [SERVICE] WHERE [patient_ID] = @patientid AND [SESSION_ID] = @sessionid", parameters);
            return ds;
        }

    }
}

