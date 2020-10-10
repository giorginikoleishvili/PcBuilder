using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class PowerSupplyType
    {
        public PowerSupplyType()
        {
            PowerSupply = new HashSet<PowerSupply>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PowerSupply> PowerSupply { get; set; }
    }
}
