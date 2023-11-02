using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rsbo_lib
{
    [Serializable]

    public class Medicine
    {
        public decimal patient_ID { get; set; }
        public string medicine_code { get; set; }
        public string medicine_name { get; set; }
        public decimal medicine_type { get; set; }
        public int amount { get; set; }
        public int dosage { get; set; }
        public int duaration { get; set; }
        public Boolean status { get; set; }
        public DateTime date { get; set; }
        public string session_id { get; set; }
    }
}
