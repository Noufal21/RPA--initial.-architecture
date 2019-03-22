using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICreator.Classes
{
    public class Setting
    {
        public string Name { get; set; }
        public string value { get; set; }
        public Setting(string Name, string value)
        {
            this.Name = Name;
            this.value = value;
        }
        public Setting()
        {
            this.Name = "";
            this.value = "";
        }
    }
}
