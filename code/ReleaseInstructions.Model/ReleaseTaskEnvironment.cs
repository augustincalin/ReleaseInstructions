using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseInstructions.Model
{
    public class ReleaseTaskEnvironment
    {
        public ReleaseTaskEnvironment()
        {

        }
        public Environment TargetEnvironment { get; set; }
        public BindingList<Server> Servers { get; set; }
    }
}
