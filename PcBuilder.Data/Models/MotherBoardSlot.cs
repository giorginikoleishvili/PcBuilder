using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class MotherBoardSlot
    {
        public MotherBoardSlot()
        {
            MotherBoardSlotDetails = new HashSet<MotherBoardSlotDetails>();
        }

        public int Id { get; set; }
        public int MotherBoardId { get; set; }
        public int SlotTypeId { get; set; }

        public virtual MotherBoard MotherBoard { get; set; }
        public virtual SlotType SlotType { get; set; }
        public virtual ICollection<MotherBoardSlotDetails> MotherBoardSlotDetails { get; set; }
    }
}
