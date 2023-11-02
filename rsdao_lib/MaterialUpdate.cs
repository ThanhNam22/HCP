using adao_lib;
using rsbo_lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace rsdao_lib
{
    public class MaterialUpdate : BASE_DAO
    {
        public MaterialUpdate() : base()
        {
        }
        public DataTable getDataTable(string patientid = null, string sessionid = null)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", patientid);
            parameters.Add("@sessionid", sessionid);
            DataTable ds = new DataTable();
            if (patientid == null)
                ds = executeReaderDataTable("SELECT [DATE], [MATERIAL_CODE] FROM [MATERIAL]");
            else
                ds = executeReaderDataTable("SELECT  [DATE], [MATERIAL_CODE] FROM [MATERIAL] WHERE [patient_ID] = @patientid AND [SESSION_ID] = @sessionid", parameters);
            return ds;
        }


        public void insert(Medicine rs)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", rs.patient_ID);
            parameters.Add("@materialcode", rs.medicine_code);
            parameters.Add("@materialname", rs.medicine_name);
            parameters.Add("@unit", rs.medicine_type);
            parameters.Add("@volume", rs.amount);
            parameters.Add("@date", rs.date);
            parameters.Add("@status", rs.status);
            parameters.Add("@sessionid", rs.session_id);


            executeNonQuery("INSERT INTO [material]([material_ID],[material_CODE], [material_NAME], [Unit], " +
                    "[Volume], [DATE], [STATUS], [SESSION_ID])" +
                    " VALUES(@patientid,@materialcode, @materialname, @unit, @volume, @date, @status, @sessionid)", parameters);
        }

        public void update(Medicine rs)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", rs.patient_ID);
            parameters.Add("@materialcode", rs.medicine_code);
            parameters.Add("@materialname", rs.medicine_name);
            parameters.Add("@unit", rs.medicine_type);
            parameters.Add("@volume", rs.amount);
            parameters.Add("@date", rs.date);
            parameters.Add("@status", rs.status);
            parameters.Add("@sessionid", rs.session_id);

            executeNonQuery("UPDATE [material] SET [patient_ID] = @patientid, [material_CODE] = @materialcode, [material_NAME] = @materialname" +
                ", [UNIT] = @unit, [volume] = @volume" +
                ", [DATE] = @date, [STATUS] = @status, [SESSION_ID] = @sessionid " +
                "WHERE [patient_ID] = @patientid AND [SESSION_ID] = @sessionid", parameters);
        }

        public void delete(string patientid, string sessionid)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", patientid);
            parameters.Add("@sessionid", sessionid);

            executeNonQuery("DELETE FROM [material] WHERE [patient_ID] = @patientid AND [SESSION_ID] = @sessionid", parameters);
        }

        public DataTable getMaterial(string patientid, string sessionid)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", patientid);
            parameters.Add("@sessionid", sessionid);
            DataTable ds = new DataTable();
            ds = executeReaderDataTable("SELECT  materiale_CODE, material_NAME FROM [material] WHERE [patient_ID] = @patientid AND [SESSION_ID] = @sessionid", parameters);
            return ds;
        }
}
}
