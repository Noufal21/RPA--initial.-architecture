using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICreator.Classes
{
    public class Attributes
    {
        public string key { get; set; }
        public string Value { get; set; }

        public Attributes(string key, string Value)
        {
            this.key = key;
            this.Value = Value;
        }
    }
}
