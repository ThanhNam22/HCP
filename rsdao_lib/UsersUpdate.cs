using abo_lib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace adao_lib
{
    public class UsersUpdate : BASE_DAO
    {
        public UsersUpdate() : base()
        {
        }

        public List<Users> getListResults()
        {
            List<Users> lst = new List<Users>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            SqlDataReader reader = executeReader("SELECT * FROM [Users] ORDER BY loginname");
            while (reader.Read())
            {
                Users cs = new Users();               
                cs.name = reader.GetString(reader.GetOrdinal("Name"));
                cs.loginname = reader.GetString(reader.GetOrdinal("loginname"));
                cs.password = reader.GetString(reader.GetOrdinal("password"));
                cs.staffcode = reader.GetString(reader.GetOrdinal("staffcode"));
                cs.active = reader.GetBoolean(reader.GetOrdinal("active"));
                lst.Add(cs);
            }
            reader.Close();
            return lst;
        }

        public DataTable getUser(string pID)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pID);
            DataTable ds = executeReaderDataTable("SELECT * FROM [Users] WHERE [loginname] = @ID", parameters);
            return ds;
        }

        public DataTable getUserPass(string pID, string pass)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pID);
            parameters.Add("@password", pass);
            DataTable ds = executeReaderDataTable("SELECT * FROM [Users] WHERE [loginname] = @ID AND [password] = @password AND [Active] = 1", parameters);
            return ds;
        }

        public string getstaffcode(string uID)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", uID);           
            DataTable ds = executeReaderDataTable("SELECT [staffcode] FROM [Users] WHERE [loginname] = @ID", parameters);
            if (ds.Rows.Count == 0)
                return "";
            else
                return ds.Rows[0]["staffcode"].ToString();
        }

        public bool ExistLoginName(string loginname)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", loginname);
            DataTable ds = executeReaderDataTable("SELECT * FROM [Users] where [loginname] = @ID", parameters);
            if (ds.Rows.Count > 0)
                return true;
            else 
                return false;             
        }

        public bool AllowEnter(string loginname, string password)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", loginname);
            parameters.Add("@password", password);
            DataTable ds = executeReaderDataTable("SELECT * FROM [Users] where [loginname] =@ID AND [password] = @password", parameters);
            if (ds.Rows.Count > 0)
                return true;
            else 
                return false;
        }


        public DataTable getAllUsers()
        {
            DataTable ds = executeReaderDataTable("SELECT * FROM [Users]");
            return ds;
        }

        public DataTable getUser(int status)
        {

            DataTable ds = new DataTable();
            if(status==0)
                ds = executeReaderDataTable("SELECT [Loginname], [Name], [staffcode], [Active] FROM [Users] WHERE [Active] = 0");
            else if(status==1)
                ds = executeReaderDataTable("SELECT [Loginname], [Name], [staffcode], [Active] FROM [Users] WHERE [Active] = 1");
            else
                ds = executeReaderDataTable("SELECT [Loginname], [Name], [staffcode], [Active] FROM [Users]");
            return ds;
        }

        public DataTable getdatatableUser(string pID)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pID);
            DataTable ds = executeReaderDataTable("SELECT * FROM [Users] WHERE [loginname] = @ID", parameters);
            return ds;
        }



        public DataSet getdatasetUser(string pID)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pID);
            DataSet ds = executeReaderDataset("SELECT * FROM [Users] WHERE [loginname] = @ID", parameters);
            return ds;
        }


        public void update(Users pt)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@loginname", pt.loginname);
            parameters.Add("@name", pt.name);           
            parameters.Add("@staffcode", pt.staffcode);
            parameters.Add("@active", pt.active);

            executeNonQuery("UPDATE [Users] SET [name] = @name," +
                " [staffcode] = @staffcode, [active] = @active WHERE [loginname] = @loginname", parameters);
        }

        public void updatePass(string uID, string uPass)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", uID);
            parameters.Add("@password", uPass);      

            executeNonQuery("UPDATE [Users] SET [password] = @password WHERE [loginname] = @ID", parameters);
        }

        public void Insert(Users pt)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();            
            parameters.Add("@name", pt.name);
            parameters.Add("@loginname", pt.loginname);
            parameters.Add("@password", pt.password);
            parameters.Add("@staffcode", pt.staffcode);
            parameters.Add("@active", pt.active);

            executeNonQuery("INSERT INTO [Users]([name], [loginname], [password], [staff_code], [active])" +
                " VALUES(@name,@loginname,@password, @staffcode, @active)", parameters);
        }

        public void delete(string pID)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ID", pID);
            executeNonQuery("DELETE FROM Users WHERE loginname = @ID", parameters);

        }
    }
}
