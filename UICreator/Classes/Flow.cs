using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UICreator.Classes
{
    public class Flow
    {
        public string FlowName { get; set; }
        public BindingList<Steps> steps { get; set; }
        public Flow()
        {
            FlowName = "";
            steps = new BindingList<Steps>();
        }
    }
}
