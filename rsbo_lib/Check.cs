using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rsbo_lib
{
    [Serializable]

    public class Check
    {
        public string id { get; set; }
        public DateTime date { get; set; }
        public string session_id { get; set; }
        public DateTime end_time { get; set; }
        public Boolean status { get; set; }
    }
}