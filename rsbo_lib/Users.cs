using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abo_lib
{
    [Serializable]
    public class Users
    {
        public string name { get; set; }
        public string loginname { get; set; }
        public string password { get; set; }
        public string staffcode { get; set; }
        public bool active { get; set; }

    }
}
