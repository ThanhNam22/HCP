using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abo_lib
{
    [Serializable]
    public class Session
    {
        public string ID { get; set; }
        public DateTime date { get; set; }
        public int status { get; set; }
    }
}
