using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseInstructions.Model
{
    public class TargetEnvironment
    {
        public int Id { get; set; }
        public TargetEnvironment()
        {

        }
        /// <summary>
        /// Target Environment.
        /// </summary>
        public Environment Environment { get; set; }
        /// <summary>
        /// Servers targeted by Release Task
        /// </summary>
        public BindingList<Server> TargetServers { get; set; }
        public ReleaseTask ParentTask { get; set; }
    }
}
