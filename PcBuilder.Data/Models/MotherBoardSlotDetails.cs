using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class MotherBoardSlotDetails
    {
        public int Id { get; set; }
        public int MotherBoardSlotId { get; set; }
        public int? Count { get; set; }
        public string Name { get; set; }

        public virtual MotherBoardSlot MotherBoardSlot { get; set; }
    }
}
