using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rsbo_lib
{
    [Serializable]
    
    public class Service
    {
        public decimal patient_ID { get; set; }
        public string service_code { get; set; }
        public string service_name { get; set; }
        public decimal service_type { get; set; }
        public decimal service_unit { get; set; }
        public Boolean is_use_service_hein { get; set; }
        public Boolean is_multi_request { get; set; }
        public Boolean status { get; set; }
        public DateTime date { get; set; }
        public string session_id { get; set; }
    }
}
