using abo_lib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

namespace adao_lib
{
    public class DiseaseUpdate: BASE_DAO
    {
        public DiseaseUpdate() : base()
        {
        }

        public List<Disease> getListResults()
        {
            List<Disease> lst = new List<Disease>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            SqlDataReader reader = executeReader("SELECT * FROM [Disease] ORDER BY ID");
            while (reader.Read())
            {
                Disease cs = new Disease();
                cs.ID = reader.GetString(reader.GetOrdinal("ID"));
                cs.name = reader.GetString(reader.GetOrdinal("Name"));
                cs.symptom = reader.GetString(reader.GetOrdinal("Disease"));
                cs.direction = reader.GetString(reader.GetOrdinal("Direction"));
                cs.description = reader.GetString(reader.GetOrdinal("description"));
                cs.priority = reader.GetString(reader.GetOrdinal("priority"));

                lst.Add(cs);
            }
            reader.Close();
            return lst;
        }

        public DataTable getDisease(string pID)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pID);
            DataTable ds = executeReaderDataTable("SELECT * FROM [Disease] WHERE [ID] = @ID", parameters);
            return ds;
        }
        public string getMaxID()
        {
            string maxID = "";
            DataTable ds = executeReaderDataTable("SELECT MAX(ID) as MAX FROM [Disease]");
            if (ds.Rows.Count > 0 && ds.Rows[0]["MAX"] != null)
            {
                Int32 m = ds.Rows[0].Field<Int32>("MAX") + 1;
                maxID = m.ToString();
            }
            return maxID;
        }

        public string getMAXPriority()
        {
            string maxID = "";
            DataTable ds = executeReaderDataTable("SELECT MAX(Priority) as MAX FROM [Disease]");
            if (ds.Rows.Count > 0 && ds.Rows[0]["MAX"] != null)
            {
                Int32 m = ds.Rows[0].Field<Int32>("MAX");
                maxID = m.ToString();
            }
            return maxID;
        }


        public DataTable getAllDisease()
        {
            DataTable ds = executeReaderDataTable("SELECT * FROM [Disease] ORDER BY [Name]");
            return ds;
        }

        public DataTable getDisease()
        {

            DataTable ds = new DataTable();          
            ds = executeReaderDataTable("SELECT * FROM [Disease]");           
            return ds;
        }

        public DataSet getdatasetDisease(string pID)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pID);
            DataSet ds = executeReaderDataset("SELECT * FROM [Disease] WHERE [ID] = @ID", parameters);
            return ds;
        }


        public void update(Disease pt)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pt.ID);
            parameters.Add("@name", pt.name);
            parameters.Add("@symptom", pt.symptom);
            parameters.Add("@direction", pt.direction);
            parameters.Add("@description", pt.description);
            parameters.Add("@priority", pt.priority);

            executeNonQuery("UPDATE [Disease] SET [ID] = @ID, [name] = @name," +
                " [symptom] = @symptom, [direction] = @direction, [description] = @description, [priority] = @priority WHERE [ID] = @ID", parameters);
        }

        public void Insert(Disease pt)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pt.ID);
            parameters.Add("@name", pt.name);
            parameters.Add("@symptom", pt.symptom);
            parameters.Add("@direction", pt.direction);
            parameters.Add("@description", pt.description);
            parameters.Add("@priority", pt.priority);

            executeNonQuery("INSERT INTO [Disease]([ID], [name]," +
                " [symptom], [direction], [description], [priority]) VALUES(@ID, @name,@symptom,@direction, @description, @priority)", parameters);
        }

        public void delete(string pID)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pID);
            executeNonQuery("DELETE FROM Disease WHERE ID = @ID", parameters);

        }
    }
}

