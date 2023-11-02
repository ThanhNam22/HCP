using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using abo_lib;

namespace adao_lib
{
    public class SettingUpdate: BASE_DAO
    {
        public SettingUpdate()
            : base()
        {
        }

        public List<Setting> getListSetting()
        {
            List<Setting> lstSetting = new List<Setting>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            SqlDataReader reader = executeReader("SELECT [Setting].[key], [Setting].[valnum], [Setting].[valstr] FROM [Setting]");
            while (reader.Read())
            {
                Setting cs = new Setting();
                cs.key = reader.GetString(reader.GetOrdinal("key")).Trim();
                if(!reader.IsDBNull(reader.GetOrdinal("valnum")))
                    cs.valnum = reader.GetFloat(reader.GetOrdinal("valnum"));
                if(!reader.IsDBNull(reader.GetOrdinal("valstr")))
                    cs.valstr = reader.GetString(reader.GetOrdinal("valstr")).Trim();
                lstSetting.Add(cs);
            }
            reader.Close();
            return lstSetting;
        }

        public Setting getSoundFile()
        {
            Setting st = new Setting();
           
            SqlDataReader reader = executeReader("SELECT [Setting].[key], [Setting].[valnum], [Setting].[valstr] FROM [Setting]" +
                "WHERE [key] = 'alarmsound'");
            while (reader.Read())
            {
                
                st.key = reader.GetString(reader.GetOrdinal("key")).Trim();
                if (!reader.IsDBNull(reader.GetOrdinal("valnum")))
                    st.valnum = reader.GetFloat(reader.GetOrdinal("valnum"));
                if (!reader.IsDBNull(reader.GetOrdinal("valstr")))
                    st.valstr = reader.GetString(reader.GetOrdinal("valstr")).Trim();
            }
            reader.Close();
            return st;
        }

        public string getLastTrain()
        {
            string lasttrain = "None";
            
            SqlDataReader reader = executeReader("SELECT [Setting].[key], [Setting].[valnum], [Setting].[valstr] FROM [Setting]" +
                "WHERE [key] = 'lasttrain'");
            if(reader.HasRows)
            {
                reader.Read();
                lasttrain = reader.GetString(reader.GetOrdinal("valstr")).Trim();
            }
            reader.Close();
            return lasttrain;
        }




        public void insertSetting(Setting rs)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();          
            parameters.Add("@key", rs.key);
            parameters.Add("@valnum", rs.valnum);
            parameters.Add("@valstr", rs.valstr);
            executeNonQuery("INSERT INTO [ECGM].[SETTING]([Key],[valnum],[valstr]) VALUES(@key,@valnum, @valstr)", parameters);
        }

        public void updateSetting(Setting rs)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@key", rs.key);
            parameters.Add("@valnum", rs.valnum);
            parameters.Add("@valstr", rs.valstr);
            executeNonQuery("UPDATE [SETTING] SET [key] = @key, [valnum] = @valnum, [valstr] = @valstr WHERE [key] = @key", parameters);
        }

        public void updateAuto(float auto)
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@key", "auto");
            parameters.Add("@valnum", auto);
            parameters.Add("@valstr", "");
            executeNonQuery("UPDATE [SETTING] SET [key] = @key, [valnum] = @valnum, [valstr] = @valstr WHERE [key] = @key", parameters);
        }

        public void deleteSetting(string Key)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@key", Key);
            executeNonQuery("DELETE [ECGM].[SETTING] WHERE [key] = @key ", parameters);
        }

    }
}
