using adao_lib;
using rsbo_lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace rsdao_lib
{
    public class MedicineUpdate : BASE_DAO
    {
        public MedicineUpdate() : base()
        {
        }
        public DataTable getDataTable(string patientid = null, string sessionid = null)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", patientid);
            parameters.Add("@sessionid", sessionid);
            DataTable ds = new DataTable();
            if (patientid == null)
                ds = executeReaderDataTable("SELECT [DATE], [MEDICINE_CODE] FROM [MEDICINE]");
            else
                ds = executeReaderDataTable("SELECT  [DATE], [MEDICINE_CODE] FROM [MEDICINE] WHERE [patient_ID] = @patientid AND [SESSION_ID] = @sessionid", parameters);
            return ds;
        }


        public void insert(Medicine rs)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", rs.patient_ID);
            parameters.Add("@medicinecode", rs.medicine_code);
            parameters.Add("@medicinename", rs.medicine_name);
            parameters.Add("@medicinetype", rs.medicine_type);
            parameters.Add("@amount", rs.amount);
            parameters.Add("@dosage", rs.dosage);
            parameters.Add("@duration", rs.duaration);
            parameters.Add("@date", rs.date);
            parameters.Add("@status", rs.status);
            parameters.Add("@sessionid", rs.session_id);


            executeNonQuery("INSERT INTO [MEDICINE]([MEDICINE_ID],[MEDICINE_CODE], [MEDICINEE_NAME], [MEDICINE_TYPE], " +
                    "[AMOUNT], [DOSAGE], [DURATION], [DATE], [STATUS], [SESSION_ID])" +
                    " VALUES(@patientid,@medicinecode, @medicinename, @medicinetype, @amount, @dosage, @duration, @date, @status, @sessionid)", parameters);
        }

        public void update(Medicine rs)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", rs.patient_ID);
            parameters.Add("@medicinecode", rs.medicine_code);
            parameters.Add("@medicinename", rs.medicine_name);
            parameters.Add("@medicinetype", rs.medicine_type);
            parameters.Add("@amount", rs.amount);
            parameters.Add("@dosage", rs.dosage);
            parameters.Add("@duration", rs.duaration);
            parameters.Add("@date", rs.date);
            parameters.Add("@status", rs.status);
            parameters.Add("@sessionid", rs.session_id);

            executeNonQuery("UPDATE [MEDICINE] SET [patient_ID] = @patientid, [MEDICINE_CODE] = @medicinecode, [MEDICINE_NAME] = @medicinename" +
                ", [MEDICINE_TYPE] = @medicinetype, [AMOUNT] = @amount, [DOSAGE] = @dosage, [DURATION = @duration" +
                ", [DATE] = @date, [STATUS] = @status, [SESSION_ID] = @sessionid " +
                "WHERE [patient_ID] = @patientid AND [SESSION_ID] = @sessionid", parameters);
        }

        public void delete(string patientid, string sessionid)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", patientid);
            parameters.Add("@sessionid", sessionid);

            executeNonQuery("DELETE FROM [medicine] WHERE [patient_ID] = @patientid AND [SESSION_ID] = @sessionid", parameters);
        }

        public DataTable getMEDICINE(string patientid, string sessionid)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@patientid", patientid);
            parameters.Add("@sessionid", sessionid);
            DataTable ds = new DataTable();
            ds = executeReaderDataTable("SELECT  medicine_CODE, medicine_NAME FROM [medicine] WHERE [patient_ID] = @patientid AND [SESSION_ID] = @sessionid", parameters);
            return ds;
        }
    }
}
