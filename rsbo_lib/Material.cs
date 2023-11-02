using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rsbo_lib
{
    [Serializable]
    public class Material
    {
        public decimal patient_ID { get; set; }
        public decimal material_code { get; set; }
        public string material_name { get; set; }
        public string unit { get; set; }
        public double volume { get; set; }
        public Boolean status { get; set; }
        public DateTime date { get; set; }
        public string session_id { get; set; }
    }
}
