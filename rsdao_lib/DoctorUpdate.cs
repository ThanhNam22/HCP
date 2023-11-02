using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using abo_lib;

namespace adao_lib
{

    public class DoctorUpdate : BASE_DAO
    {
        public DoctorUpdate() : base()
        {
        }

        public List<Doctor> getListResults()
        {
            List<Doctor> lst = new List<Doctor>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            SqlDataReader reader = executeReader("SELECT * FROM [Patient] ORDER BY ID");
            while (reader.Read())
            {
                Doctor cs = new Doctor();
                cs.ID = reader.GetString(reader.GetOrdinal("ID"));
                cs.name = reader.GetString(reader.GetOrdinal("Name"));
                cs.dateofbirth = reader.GetString(reader.GetOrdinal("DateOfBirth"));
                cs.gender = reader.GetString(reader.GetOrdinal("gender"));
                cs.tel = reader.GetString(reader.GetOrdinal("tel"));
                cs.email = reader.GetString(reader.GetOrdinal("email"));
                cs.major = reader.GetString(reader.GetOrdinal("major"));               
                cs.location = reader.GetString(reader.GetOrdinal("location"));
                cs.degree = reader.GetString(reader.GetOrdinal("degree"));               
                cs.active = reader.GetBoolean(reader.GetOrdinal("active"));
                lst.Add(cs);
            }
            reader.Close();
            return lst;
        }

        public DataTable getDoctor(string pID)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pID);
            DataTable ds = executeReaderDataTable("SELECT * FROM [Doctor] WHERE [ID] = @ID", parameters);
            return ds;
        }
        public string getMaxID()
        {
            string maxID = "";
            DataTable ds = executeReaderDataTable("SELECT MAX(ID) as MAX FROM [DOCTOR]");
            if (ds.Rows.Count > 0 && ds.Rows[0].Field<string>("MAX") != null)
            {
                long m = long.Parse(ds.Rows[0].Field<string>("MAX")) + 1;
                maxID = m.ToString();
            }
            return maxID;
        }
        public DataTable getAllDoctor()
        {
            DataTable ds = executeReaderDataTable("SELECT * FROM [Doctor] ORDER BY [ID]");
            return ds;
        }

        public DataTable getDoctor(int status)
        {

            DataTable ds = new DataTable();
            if (status == 1)
                ds = executeReaderDataTable("SELECT * FROM [Doctor] WHERE Active = 1");
            else if (status == 0)
                ds = executeReaderDataTable("SELECT * FROM [Doctor] WHERE Active = 0");
            else
                ds = executeReaderDataTable("SELECT * FROM [Doctor]");
            return ds;
        }

        public DataSet getdatasetDoctor(string pID)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pID);
            DataSet ds = executeReaderDataset("SELECT * FROM [Doctor] WHERE [ID] = @ID", parameters);
            return ds;
        }


        public void update(Doctor pt)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pt.ID);
            parameters.Add("@name", pt.name);
            parameters.Add("@gender", pt.gender);
            parameters.Add("@tel", pt.tel);
            parameters.Add("@email", pt.email);
            parameters.Add("@dateofbirth", pt.dateofbirth);
            parameters.Add("@major", pt.major);
            parameters.Add("@location", pt.location);
            parameters.Add("@degree", pt.degree);
            parameters.Add("@active", pt.active);

            executeNonQuery("UPDATE [DOCTOR] SET [ID] = @ID, [name] = @name," +
                " [gender] = @gender, [tel] = @tel, [email] = @email, [dateofbirth] = @dateofbirth," +
                " [major] = @major, [location] = @location, [degree] = @degree," +
                " [Active] = @active WHERE [ID] = @ID", parameters);
        }

        public void Insert(Doctor pt)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pt.ID);
            parameters.Add("@name", pt.name);
            parameters.Add("@gender", pt.gender);
            parameters.Add("@tel", pt.tel);
            parameters.Add("@email", pt.email);
            parameters.Add("@dateofbirth", pt.dateofbirth);
            parameters.Add("@major", pt.major);
            parameters.Add("@location", pt.location);
            parameters.Add("@degree", pt.degree);
            parameters.Add("@active", pt.active);

            executeNonQuery("INSERT INTO [DOCTOR]([ID], [name]," +
                " [gender], [tel], [email], [Dateofbirth], [major], [location], [degree], [Active])" +
                " VALUES(@ID, @name,@gender,@tel,@email,@dateofbirth, @major," +
                " @location, @degree,@active)", parameters);


        }

        public void delete(string pID)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pID);
            executeNonQuery("DELETE FROM DOCTOR WHERE ID = @ID", parameters);

        }
    }
}
