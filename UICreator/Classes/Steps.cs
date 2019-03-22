using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICreator.Classes
{
    public class Steps
    {
        public string key { get; set; }
        public string value { get; set; }
        public string description { get; set; }
        public string type { get; set; }

        public Steps(string key, string value,string description,string type)
        {
            this.description = description;
            this.key = key;
            this.type = type;
            this.value = value;
        }
        public Steps()
        {
            this.description = "";
            this.key = "";
            this.type = "";
            this.value = "";

        }
    }
}
