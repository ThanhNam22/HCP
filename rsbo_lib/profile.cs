using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abo_lib
{
    [Serializable]
    public class profile
    {
        public decimal ID { get; set; }
        public decimal patient_id { get; set; }
        public string patient_name { get; set; }
        public decimal intime { get; set; }
        public decimal outtime { get; set; }
        public decimal inroom_id { get; set; }
        public decimal indepartment_id { get; set; }
        public string doctor_loginname { get; set; }
        public bool status { get; set; }
    }
}
