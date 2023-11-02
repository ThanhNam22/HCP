using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abo_lib
{
    [Serializable]
    public class Doctor
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string dateofbirth { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string major { get; set; }
        public string location { get; set; }
        public string degree { get; set; }    
        public bool active { get; set; }


    }
}
