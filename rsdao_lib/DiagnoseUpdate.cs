using abo_lib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Data;

namespace adao_lib
{
    public class DiagnoseUpdate : BASE_DAO
    {
        public DiagnoseUpdate() : base()
        {
        }

        
        public List<Diagnose> getList(string profileid = null)
        {
            List<Diagnose> lst = new List<Diagnose>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            SqlDataReader reader;
            parameters.Add("@patientid", profileid);
            if (profileid == null)
                reader = executeReader("SELECT [patient_ID], [DATE], [DISEASE_CODE], [DIAGNOSE] FROM Diagnose");
            else
                reader = executeReader("SELECT [patient_ID], [DATE], [DISEASE_CODE], [DIAGNOSE] FROM Diagnose WHERE [patient_ID] = @patientid");

            while (reader.Read())
            {
                Diagnose cs = new Diagnose();
                cs.patient_ID = reader.GetDecimal(reader.GetOrdinal("patient_ID"));
                cs.date = reader.GetDateTime(reader.GetOrdinal("DATE"));
                cs.disease_code = reader.GetString(reader.GetOrdinal("DISEASE_CODE"));
                cs.diagnose = reader.GetString(reader.GetOrdinal("DIAGNOSE"));
               
                lst.Add(cs);
            }
            reader.Close();
            return lst;
        }

        public DataTable getDataTable(string patientid = null)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", patientid);
            DataTable ds = new DataTable();
            if (patientid == null)
                  ds = executeReaderDataTable("SELECT [DATE], [DISEASE_CODE] FROM [Diagnose]");
            else
                  ds = executeReaderDataTable("SELECT  [DATE], [DISEASE_CODE] FROM [Diagnose] WHERE [patient_ID] = @patientid", parameters);
            return ds;
        }


        public void insert(Diagnose rs)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", rs.patient_ID);
            parameters.Add("@date", rs.date);
            parameters.Add("@diseasecode", rs.disease_code);
            parameters.Add("@diagnose", rs.diagnose);
          
            executeNonQuery("INSERT INTO [Diagnose]([patient_ID],[DATE], [DISEASE_CODE],[DIAGNOSE])" +
                " VALUES(@patientid,@date, @diseasecode, @diagnose)", parameters);
        }

        public void update(Diagnose rs)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", rs.patient_ID);
            parameters.Add("@date", rs.date);
            parameters.Add("@diseasecode", rs.disease_code);
            parameters.Add("@diagnose", rs.diagnose);

            executeNonQuery("UPDATE [DIAGNOSE] SET [patient_ID] = @patientid, [DATE] = @date, [DISEASECODE] = @diseasecode, [DIAGNOSE] = @diagnose " +
                "WHERE [patient_ID] = @patientid AND [DATE] = @date", parameters);
        }
        public void delete(string patientid, string diseasecode)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", patientid);
           
            parameters.Add("@diseasecode", diseasecode);
           
            executeNonQuery("DELETE FROM [Diagnose] WHERE [patient_ID] = @patientid AND [DISEASE_CODE] = @diseasecode", parameters);
        }

        public DataTable getDiagnose(string patientid, string date)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", patientid);
            parameters.Add("@date", date);
            DataTable ds = new DataTable();
            ds = executeReaderDataTable("SELECT  [DIAGNOSE] FROM [Diagnose] WHERE [patient_ID] = @patientid AND [DATE] = @date", parameters);
            return ds;
        }

    }
}
