using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abo_lib
{
    [Serializable]
    public class Disease
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string symptom { get; set; }
        public string direction { get; set; }       
        public string description { get; set; }
        public string priority { get; set; }

    }
}
