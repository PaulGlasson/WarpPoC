using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ConfigurationItem
    {
        public ConfigurationItem()
        {
            this.Configurations = new List<Configuration>();
        }

        public short ConfigurationItemID { get; set; }
        public string Name { get; set; }
        public byte ConfigurationTypeID { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Configuration> Configurations { get; set; }
        public virtual ConfigurationType ConfigurationType { get; set; }
    }
}
