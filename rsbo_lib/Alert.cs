using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rsbo_lib
{
    [Serializable]

    public class Alert
    {
        public decimal profile_ID { get; set; }
        public string rule_id { get; set; }
        public string check_id { get; set; }
        public Boolean solved { get; set; }
        public int status { get; set; }
    }
}
