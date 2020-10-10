using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class MotherBoardMemorySpeed
    {
        public int Id { get; set; }
        public int MotherBoardMemoryId { get; set; }
        public int? Speed { get; set; }

        public virtual MortherBoardMemory MotherBoardMemory { get; set; }
    }
}
