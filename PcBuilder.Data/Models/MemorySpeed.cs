using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class MemorySpeed
    {
        public int Id { get; set; }
        public int MemoryTypeId { get; set; }
        public int Speed { get; set; }

        public virtual MemoryType MemoryType { get; set; }
    }
}
