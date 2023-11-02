using abo_lib;
using adao_lib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace adao_lib
{
    public class ProfileUpdate : BASE_DAO
    {
        public ProfileUpdate()
          : base()
        {
        }

        public List<profile> getListResults()
        {
            List<profile> lst = new List<profile>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            SqlDataReader reader = executeReader("SELECT * FROM [Profile] ORDER BY ID");
            while (reader.Read())
            {
                profile cs = new profile();
                cs.ID = reader.GetDecimal(reader.GetOrdinal("ID"));
                cs.patient_id = reader.GetDecimal(reader.GetOrdinal("PATIENT_ID"));
                cs.patient_name = "";
                cs.intime = reader.GetDecimal(reader.GetOrdinal("IN_TIME"));
                cs.outtime = reader.GetDecimal(reader.GetOrdinal("OUT_TIME"));
                cs.inroom_id = reader.GetDecimal(reader.GetOrdinal("IN_ROOM_ID"));
                cs.indepartment_id = reader.GetDecimal(reader.GetOrdinal("IN_DEPARTMENT_ID"));
                cs.doctor_loginname = reader.GetString(reader.GetOrdinal("DOCTOR_LOGINNAME"));
                cs.status = reader.GetBoolean(reader.GetOrdinal("STATUS"));
               
                lst.Add(cs);
            }
            reader.Close();
            return lst;
        }

        public DataTable getPatient(string pID)
        {
           
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pID);
            DataTable ds = executeReaderDataTable("SELECT * FROM [PROFILE] WHERE [ID] = @ID", parameters);            
            return ds;
        }

        public DataTable getProfile(string session)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@session_id", session);
            DataTable ds = executeReaderDataTable("SELECT ID, [PATIENT_ID],[IN_TIME],[IN_ROOM_ID],[IN_DEPARTMENT_ID],[DOCTOR_LOGINNAME] FROM [PROFILE] WHERE [SESSION_ID] = @session_id ORDER BY [ID]", parameters);
            return ds;
        }
        public DataTable getProfileV(string session)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@session_id", session);
            DataTable ds = executeReaderDataTable("SELECT ID, [PATIENT_ID],[IN_TIME],[IN_ROOM_ID],[IN_DEPARTMENT_ID],[DOCTOR_LOGINNAME] FROM [V_PROFILE] WHERE [SESSION_ID] = @session_id ORDER BY [ID]", parameters);
            return ds;
        }

        public string getMaxID()
        {
            string maxID = "";
            DataTable ds = executeReaderDataTable("SELECT MAX(ID) as MAX FROM [PROFILE]");
            if (ds.Rows.Count > 0 && ds.Rows[0].Field<string>("MAX") != null)
            {
                long m = long.Parse(ds.Rows[0].Field<string>("MAX")) + 1;
                maxID = m.ToString();
            }
               
            return maxID;
        }
        public DataTable getAllPatient()
        {           
            DataTable ds = executeReaderDataTable("SELECT * FROM [PROFILE]");
            return ds;
        }

        public DataTable getPatient(int status)
        {
           
            DataTable ds = new DataTable();
            if(status==1)
               ds = executeReaderDataTable("SELECT * FROM [PROFILE] WHERE STATUS = 1");
            else if(status==0)
                ds = executeReaderDataTable("SELECT * FROM [PROFILE] WHERE STATUS = 0");
            else
                ds = executeReaderDataTable("SELECT * FROM [PROFILE]");
            return ds;
        }

        public DataSet getdatasetPatient(string pID)
        {            
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pID);
            DataSet ds = executeReaderDataset("SELECT * FROM [PROFILE] WHERE [ID] = @ID ORDER BY ID", parameters);
            return ds;
        }
        
       
       public void update(profile pt)
        {
            
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pt.ID);
            parameters.Add("@patient_id", pt.patient_id);
            parameters.Add("@patient_name", pt.patient_name);
            parameters.Add("@intime", pt.intime);
            parameters.Add("@outtime", pt.outtime);
            parameters.Add("@inroom_id", pt.inroom_id);
            parameters.Add("@indepartment_id", pt.indepartment_id);
            parameters.Add("@doctor_loginname", pt.doctor_loginname);
            parameters.Add("@status", pt.status);
         
            

            executeNonQuery("UPDATE [PROFILE] SET [ID] = @ID, [PATIENT_ID] = @patient_id, [IN_TIME] = @intime, [OUT_TIME] = @outtime," + 
                "[IN_ROOM_ID] = @inroom_id, [OUT_ROOM_ID] = @outroom_id, [IN_DEPARTMENT_ID] = @indepartment_id, [DOCTOR_LOGINNAME] = @doctor_loginname," + 
                "[STATUS]  = @status WHERE [ID] = @ID", parameters);
        }

        public void Insert(profile pt)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pt.ID);
            parameters.Add("@patient_id", pt.patient_id);
            parameters.Add("@patient_name", pt.patient_name);
            parameters.Add("@intime", pt.intime);
            parameters.Add("@outtime", pt.outtime);
            parameters.Add("@inroom_id", pt.inroom_id);
            parameters.Add("@indepartment_id", pt.indepartment_id);
            parameters.Add("@doctor_loginname", pt.doctor_loginname);
            parameters.Add("@status", pt.status);

            executeNonQuery("INSERT INTO [PROFILE]([ID],[PATIENT_ID], [PATIENT_NAME], [INTIME]," +
                " [OUTTIME], [IN_ROOM_ID], [IN_DEPARTMENT_ID], [DOCTOR_LOGINNAME], [STATUS]," +
                " VALUES(@ID,@patient_id,@patient_name, @dintime, @outtime,@inroom_id,@indepartment_id,@doctor_loginname, @atstus)", parameters);

        }

        public void delete(string pID)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pID);  
            executeNonQuery("DELETE FROM PATIENT WHERE ID = @ID", parameters);

        }
    }
}
