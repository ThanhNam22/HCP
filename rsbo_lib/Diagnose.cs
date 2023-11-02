using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abo_lib
{
    [Serializable]
    public class Diagnose
    {
        public decimal patient_ID { get; set; }
        public DateTime date { get; set; }
        public string diagnose { get; set; }
        public string disease_code { get; set; }
      

    }
}
