using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class MemoryType
    {
        public MemoryType()
        {
            Memory = new HashSet<Memory>();
            MemorySpeed = new HashSet<MemorySpeed>();
            MortherBoardMemory = new HashSet<MortherBoardMemory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int HardwareTypeId { get; set; }

        public virtual HardwareType HardwareType { get; set; }
        public virtual ICollection<Memory> Memory { get; set; }
        public virtual ICollection<MemorySpeed> MemorySpeed { get; set; }
        public virtual ICollection<MortherBoardMemory> MortherBoardMemory { get; set; }
    }
}
