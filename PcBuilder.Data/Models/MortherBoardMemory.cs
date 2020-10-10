using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class MortherBoardMemory
    {
        public MortherBoardMemory()
        {
            MotherBoardMemorySpeed = new HashSet<MotherBoardMemorySpeed>();
        }

        public int Id { get; set; }
        public int MotherBoardId { get; set; }
        public int MemoryTypeId { get; set; }

        public virtual MemoryType MemoryType { get; set; }
        public virtual MotherBoard MotherBoard { get; set; }
        public virtual ICollection<MotherBoardMemorySpeed> MotherBoardMemorySpeed { get; set; }
    }
}
