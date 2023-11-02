using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abo_lib
{
    [Serializable]
    public class Setting
    {
        public string key { get; set; }
        public float valnum { get; set; }
        public string valstr { get; set; }
    }
}
