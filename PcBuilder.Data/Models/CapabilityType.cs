using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class CapabilityType
    {
        public CapabilityType()
        {
            OpticalDrive = new HashSet<OpticalDrive>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OpticalDrive> OpticalDrive { get; set; }
    }
}
