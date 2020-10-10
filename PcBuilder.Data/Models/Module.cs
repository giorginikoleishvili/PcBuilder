using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class Module
    {
        public Module()
        {
            Memory = new HashSet<Memory>();
        }

        public int Id { get; set; }
        public int Count { get; set; }
        public int Volume { get; set; }
        public int VolumeTypeId { get; set; }

        public virtual VolumeType VolumeType { get; set; }
        public virtual ICollection<Memory> Memory { get; set; }
    }
}
